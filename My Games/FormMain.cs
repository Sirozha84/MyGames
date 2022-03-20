using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.IO;

namespace My_Games
{
    public partial class FormMain : Form
    {
        ItemComparer itemComparer = new ItemComparer();
        int lastColumn = 0;
        bool lastSort = false;
        
        public FormMain()
        {
            InitializeComponent();
            Data.Load();
            listGames.ListViewItemSorter = itemComparer;
            RefreshData();
            listGames.Columns[lastColumn].Text += " ▲";

            Graphics graphics = CreateGraphics();
            Program.scale = graphics.DpiX / 96;
            //Program.scale = 1;

            MinimumSize = new Size((int)(1000 * Program.scale), (int)(700 * Program.scale));
            int iconSize = (int)(32 * Program.scale);
            toolStrip.ImageScalingSize = new Size(iconSize, iconSize);
            toolStrip.Height = listGames.Top = panelInfo.Top = (iconSize + 18 >= toolSearch.Height) ? iconSize + 18 : toolSearch.Height;
            listGames.Height = panelInfo.Height = ClientSize.Height - toolStrip.Height - statusStrip.Height;
            toolSearch.Width = (int)(200 * Program.scale);
            listGames.Columns[0].Width = (int)(90 * Program.scale);
            listGames.Columns[1].Width = (int)(220 * Program.scale);
            listGames.Columns[2].Width = (int)(150 * Program.scale);
            listGames.Columns[3].Width = (int)(90 * Program.scale);
            listGames.Columns[4].Width = (int)(130 * Program.scale);
            listGames.Columns[5].Width = (int)(80 * Program.scale);
            listGames.Columns[6].Width = (int)(90 * Program.scale);
            listGames.Columns[7].Width = (int)(110 * Program.scale);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Left = Properties.Settings.Default.Left;
            Top = Properties.Settings.Default.Top;
            Width = Properties.Settings.Default.Width;
            Height = Properties.Settings.Default.Height;
            toolFilter.Checked = Data.data.filter.enable;
            toolInfo.Checked = Properties.Settings.Default.panelInfo;
            toolColNone.Checked = Properties.Settings.Default.colorMode == 0;
            toolColWin.Checked = Properties.Settings.Default.colorMode == 1;
            ShowHidepanelInfo(false);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Left = Left;
            Properties.Settings.Default.Top = Top;
            Properties.Settings.Default.Width = Width;
            Properties.Settings.Default.Height = Height;
            Properties.Settings.Default.panelInfo = toolInfo.Checked;
            Properties.Settings.Default.Save();
            Data.Save();
        }
        #region Панель инструментов

        private void addGame(object sender, EventArgs e)
        {
            Game game = new Game();
            FormGame form = new FormGame(game);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Data.data.games.Add(game);
                Data.Save();
                RefreshData();
            }
        }

        private void FilterChange(object sender, EventArgs e)
        {
            Filter fl = Data.data.filter;
            if (fl.enable)
                fl.enable = false;
            else
                using (FormFilter form = new FormFilter())
                    form.ShowDialog();
            toolFilter.Checked = fl.enable;
            RefreshData();
        }

        private void infoPanelTogle(object sender, EventArgs e)
        {
            toolInfo.Checked = !toolInfo.Checked;
            ShowHidepanelInfo(true);
        }

        private void dictPlatforms(object sender, EventArgs e)
        {
            FormDict form = new FormDict(1, Data.data.platforms);
            form.ShowDialog();
            Data.Save();
        }

        private void ColorNone(object sender, EventArgs e)
        {
            toolColNone.Checked = true;
            toolColWin.Checked = false;
            Properties.Settings.Default.colorMode = 0;
            RefreshData();
        }

        private void ColorWin(object sender, EventArgs e)
        {
            toolColNone.Checked = false;
            toolColWin.Checked = true;
            Properties.Settings.Default.colorMode = 1;
            RefreshData();
        }

        private void dictMediums(object sender, EventArgs e)
        {
            FormDict form = new FormDict(2, Data.data.mediums);
            form.ShowDialog();
            Data.Save();
        }

        private void dictGenres(object sender, EventArgs e)
        {
            FormDict form = new FormDict(3, Data.data.genres);
            form.ShowDialog();
            Data.Save();
            RefreshData();
        }

        private void Statistic(object sender, EventArgs e)
        {
            using (FormStatistic form = new FormStatistic()) form.ShowDialog();
        }

        private void Purchases(object sender, EventArgs e)
        {
            using (FormPurchases form = new FormPurchases()) form.ShowDialog();
        }

        private void History(object sender, EventArgs e)
        {
            using (FormHistory form = new FormHistory()) form.ShowDialog();
        }

        private void About(object sender, EventArgs e)
        {
            using (FormAbout form = new FormAbout()) form.ShowDialog();
        }

        private void SearchTextChange(object sender, EventArgs e)
        {
            toolReset.Enabled = toolSearch.Text != ""; RefreshData();
        }

        private void SearchReset(object sender, EventArgs e)
        {
            toolSearch.Text = ""; 
        }

        #endregion

        #region Контекстное меню

        void Open(object sender, EventArgs e)
        {
            if (listGames.SelectedItems.Count == 1)
            {
                Game game = (Game)listGames.SelectedItems[0].Tag;
                FormGame form = new FormGame(game);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Data.Save();
                    RefreshData();
                }
            }
        }

        void GoToSite(object sender, EventArgs e)
        {
            Game game = (Game)listGames.SelectedItems[0].Tag;
            System.Diagnostics.Process.Start("http:" + game.website);
        }

        private void Delete(object sender, EventArgs e)
        {
            int count = listGames.SelectedIndices.Count;
            if (count < 1) return; //Хотя до этого и не должно дойти, но мало ли
            Game game = (Game)listGames.SelectedItems[0].Tag;
            if (MessageBox.Show("Вы действительно хотите удалить " +
                    (count == 1 ? "игру " + game.name : "выделенные игры (" + count + ")?") + "?",
                    "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (ListViewItem item in listGames.SelectedItems)
                    Data.data.games.Remove((Game)item.Tag);
                Data.Save();
                RefreshData();
            }
        }

        #endregion

        #region Список игр

        private void listGames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Open(null, null);
        }

        private void listGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool selected = listGames.SelectedIndices.Count > 0;
            bool enableSite = false;
            cmOpen.Enabled = selected;
            cmDelete.Enabled = selected;

            Game game = selected ? (Game)listGames.SelectedItems[0].Tag : new Game();

            //Инфопанель
            if (game.cover != null)
                try
                {
                    using (var File = new FileStream("Covers\\" + game.cover, FileMode.Open, FileAccess.Read, FileShare.Inheritable))
                        pictureCover.Image = Image.FromStream(File);
                }
                catch { }
            else
                pictureCover.Image = null;

            /*labelName.Text = selected ? game.name : "";
            labelDevelopers.Text = selected ? game.developer : "";
            labelPublishers.Text = selected ? game.publisher : "";
            labelYear.Text = selected ? game.year : "";
            labelVersions.Text = selected ? Data.StringVersions(game.versions) : "";
            labelDLCs.Text = selected ? Data.StringDLCs(game.DLCs) : "";
            labelHistory.Text = selected ? Data.StringHistory(game.history) : "";*/

            int selectC = listGames.SelectedIndices.Count;
            if (selectC == 1)
                enableSite = game.website != null & game.website != "";
            cmGoToSite.Enabled = enableSite;
            if (selectC == 0)
                statusSelected.Text = "";
            else
                statusSelected.Text = "Выделено: " + selectC.ToString();
        }

        #endregion
        
        void RefreshData()
        {
            GameDateComparer dc = new GameDateComparer();
            Data.data.games.Sort(dc);
            listGames.BeginUpdate();
            listGames.Items.Clear();
            int showed = 0;
            foreach (Game g in Data.data.games)
            {
                bool draw = true;
                bool match;
                Filter fl = Data.data.filter;
                if (!g.name.ToLower().Contains(toolSearch.Text.ToLower())) draw = false;
                if (fl.enable)
                {
                    if (fl.startEnable | fl.endEnable)
                    {
                        match = false;
                        foreach (Version ver in g.versions)
                        {
                            bool min = fl.startEnable ? ver.date >= fl.start : true;
                            bool max = fl.endEnable ? ver.date <= fl.end : true;
                            match = min & max;
                        }

                        if (!match) draw = false;
                    }
                    if (fl.platformEnable)
                    {
                        match = false;
                        foreach (Version ver in g.versions)
                            if (ver.platform == fl.platform) match = true;
                        if (!match) draw = false;
                    }
                    if (fl.mediumEnable)
                    {
                        match = false;
                        foreach (Version ver in g.versions)
                            if (ver.medium == fl.medium) match = true;
                        if (!match) draw = false;
                    }
                    if (fl.genreEnable && g.genre != fl.genre) draw = false;
                }
                if (draw)
                {
                    listGames.Items.Add(g.listItem());
                    showed++;
                }
            }
            listGames.EndUpdate();

            //Подумать как после обновления списка оставить выделенным элемент который уже был выделен до обновления

            //Обновление сатусбара
            statusAll.Text = "Всего игр: " + Data.data.games.Count;
            if (showed == Data.data.games.Count)
                statusShowed.Text = "";
            else
                statusShowed.Text = "Показано: " + showed.ToString();
            statusSelected.Text = "";
        }

        /// <summary>
        /// Показ или скрытие панели информации
        /// </summary>
        /// <param name="resize"></param>
        void ShowHidepanelInfo(bool resize)
        {
            //Порядок не нарушаем - иначе моргает из-за перерисовок.
            if (toolInfo.Checked)
            {
                if (resize) Width += panelInfo.Width;
                listGames.Width = toolStrip.Width - panelInfo.Width;
                panelInfo.Left = toolStrip.Width - panelInfo.Width;
            }
            else
            {
                listGames.Width = toolStrip.Width;
                panelInfo.Left = toolStrip.Width;
                if (resize) Width -= panelInfo.Width;
            }
        }

        //Сортировка колонок
        private void listGames_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            itemComparer.ColumnIndex = e.Column;
            ((ListView)sender).Sort();
            //Просто ужасный костыль, может потом сделаю хорошо если научусь
            //Таким образом мы рисуем треугольник на имени столбца, показывающий направление сортировки
            listGames.Columns[lastColumn].Text =
                listGames.Columns[lastColumn].Text.Substring(0, listGames.Columns[lastColumn].Text.Length - 2);
            if (lastColumn != e.Column)
                lastSort = true;
            lastSort = !lastSort;
            listGames.Columns[e.Column].Text += lastSort ? " ▼" : " ▲";
            lastColumn = e.Column;
        }

    }

    class ItemComparer : IComparer
    {
        int columnIndex = 0;
        public bool sortAscending = true;
        public int ColumnIndex
        {
            set
            {
                //предыдущий клик был на этой же колонке?
                if (columnIndex == value)
                    //да - меняем направление сортировки
                    sortAscending = !sortAscending;
                else
                {
                    columnIndex = value;
                    sortAscending = true;
                }
            }
        }

        public int Compare(object g1, object g2)
        {
            Game game1 = (Game)((ListViewItem)g1).Tag;
            Game game2 = (Game)((ListViewItem)g2).Tag;
            int res = 0;
            if (columnIndex == 0)
                res = game1.date > game2.date ? 1 : -1;
            if (columnIndex == 1)
                res = String.Compare(game1.name, game2.name);
            if (columnIndex == 2) //и это будет невероятно тормозить с большой базой, пока оставлю это так, оптимизирую потом!
                res = string.Compare(Data.GenreIDToName(game1.genre), Data.GenreIDToName(game2.genre));
            if (columnIndex == 3)
                res = game1.rate > game2.rate ? 1 : -1;
            if (columnIndex == 4)
                res = game1.win > game2.win ? 1 : -1;
            if (columnIndex == 5)
                res = game1.hours > game2.hours ? 1 : -1;
            if (columnIndex == 6)
                res = game1.versions.Count > game2.versions.Count ? 1 : -1;
            if (columnIndex == 7)
                res = game1.price > game2.price ? 1 : -1;
            return res * (sortAscending ? 1 : -1);
        }
    }
}
