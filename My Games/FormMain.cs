using System;
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
            Settings.Init();
            Data.Load();
            listViewGames.ListViewItemSorter = itemComparer;
            listViewGames.Columns[lastColumn].Text += " ▲";
            RefreshData();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Left = Settings.left;
            Top = Settings.top;
            Width = Settings.width;
            Height = Settings.height;
            Checks();
            ShowHideInfoView(false);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.left = Left;
            Settings.top = Top;
            Settings.width = Width;
            Settings.height = Height;
            Settings.infoPanel = menuInfoPanel.Checked;
            Settings.Save();
            Data.Save();
        }

        #region Действия на форме (обновление, выбор, открытие, сортировка)
        void RefreshData()
        {
            listViewGames.BeginUpdate();
            listViewGames.Items.Clear();
            int count = 0;
            int showed = 0;
            foreach (Game g in Data.data.games)
            {
                bool draw = true;
                bool hide = false;
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
                if (g.hidden && !Settings.showHidden) { draw = false; hide = true; }
                if (draw)
                {
                    listViewGames.Items.Add(g.listItem());
                    showed++;
                }
                if (!hide) count++;
            }
            listViewGames.EndUpdate();
            statusAll.Text = "Всего игр: " + count.ToString();
            if (showed == count)
                statusShowed.Text = "";
            else
                statusShowed.Text = "Показано: " + showed.ToString();
            statusSelected.Text = "";
        }

        private void SelectChange(object sender, EventArgs e)
        {
            bool selected = listViewGames.SelectedIndices.Count > 0;
            menuDel.Enabled = cmOpen.Enabled = cmDelC.Enabled = selected;

            Game game = selected ? (Game)listViewGames.SelectedItems[0].Tag : new Game();

            //Инфопанель
            if (game.cover != null)
                try
                {
                    using (var File = new FileStream("Covers\\" + game.cover, FileMode.Open, FileAccess.Read, FileShare.Inheritable))
                        pictureBoxCover.Image = Image.FromStream(File);
                }
                catch { }
            else
                pictureBoxCover.Image = null;

            labelName.Text = selected ? game.name : "";
            labelDevelopers.Text = selected ? game.developer : "";
            labelPublishers.Text = selected ? game.publisher : "";
            labelYear.Text = selected ? game.year : "";
            labelVersions.Text = selected ? Data.StringVersions(game.versions) : "";
            labelDLCs.Text = selected ? Data.StringDLCs(game.DLCs) : "";
            labelHistory.Text = selected ? Data.StringHistory(game.history) : "";

            int selectC = listViewGames.SelectedIndices.Count;
            menuGotoSite.Enabled = cmGoToSite.Enabled = selectC == 1 && game.website != null && game.website != "";
            menuOpenSF.Enabled = cmOpenSF.Enabled = selectC == 1 && game.scrFolder != null && game.scrFolder != "";
            if (selectC == 0)
                statusSelected.Text = "";
            else
                statusSelected.Text = "Выделено: " + selectC.ToString();
        }

        void Open(object sender, EventArgs e)
        {
            if (listViewGames.SelectedItems.Count == 1)
            {
                Game game = (Game)listViewGames.SelectedItems[0].Tag;
                FormGame form = new FormGame(game);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Data.Save();
                    RefreshData();
                }
            }
        }

        private void listViewGames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Open(null, null);
        }

        void GoToSite(object sender, EventArgs e)
        {
            Game game = (Game)listViewGames.SelectedItems[0].Tag;
            System.Diagnostics.Process.Start("http:" + game.website);
        }

        void OpenScrFolder(object sender, EventArgs e)
        {
            Game game = (Game)listViewGames.SelectedItems[0].Tag;
            game.OpenScrFolder();
        }

        /// <summary>
        /// Сортировка по выбранной колонке
        /// </summary>
        private void Sort(object sender, ColumnClickEventArgs e)
        {
            itemComparer.ColumnIndex = e.Column;
            ((ListView)sender).Sort();
            //Просто ужасный костыль, может потом сделаю хорошо если научусь
            //Таким образом мы рисуем треугольник на имени столбца, показывающий направление сортировки
            listViewGames.Columns[lastColumn].Text =
                listViewGames.Columns[lastColumn].Text.Substring(0, listViewGames.Columns[lastColumn].Text.Length - 2);
            if (lastColumn != e.Column)
                lastSort = true;
            lastSort = !lastSort;
            listViewGames.Columns[e.Column].Text += lastSort ? " ▼" : " ▲";
            lastColumn = e.Column;
        }
        #endregion

        #region Меню "Файл"
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

        private void addGameFast(object sender, EventArgs e)
        {
            Game game = new Game();
            FormFastAdd form = new FormFastAdd(game);
            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                Data.data.games.Add(game);
                Data.Save();
                RefreshData();
            }
            if (res == DialogResult.Retry)
            {
                FormGame form2 = new FormGame(game);
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    Data.data.games.Add(game);
                    Data.Save();
                    RefreshData();
                }
            }
        }

        private void Delete(object sender, EventArgs e)
        {
            int count = listViewGames.SelectedIndices.Count;
            if (count < 1) return; //Хотя до этого и не должно дойти, но мало ли
            Game game = (Game)listViewGames.SelectedItems[0].Tag;
            if (MessageBox.Show("Вы действительно хотите удалить " +
                    (count == 1 ? "игру " + game.name : "выделенные игры (" + count + ")?") + "?",
                    "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (ListViewItem item in listViewGames.SelectedItems)
                    Data.data.games.Remove((Game)item.Tag);
                Data.Save();
                RefreshData();
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Меню "Вид"
        private void filterChange(object sender, EventArgs e)
        {
            Filter fl = Data.data.filter;
            if (fl.enable)
                fl.enable = false;
            else
                using (FormFilter form = new FormFilter())
                    form.ShowDialog();
            menuFilter.Checked = fl.enable;
            toolFilter.Checked = fl.enable;
            RefreshData();
        }

        private void menuSearch_Click(object sender, EventArgs e) { toolSearch.Focus(); }

        private void infoPanelOnOff(object sender, EventArgs e)
        {
            menuInfoPanel.Checked = !menuInfoPanel.Checked;
            toolInfoPanel.Checked = menuInfoPanel.Checked;
            ShowHideInfoView(true);
        }
        private void SelectColorMode(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Name == "menuCol0") Settings.colorMode = 0;
            if (((ToolStripMenuItem)sender).Name == "menuCol1") Settings.colorMode = 1;
            Checks();
            RefreshData();
        }
        private void ShowHidden(object sender, EventArgs e)
        {
            Settings.showHidden ^= true;
            Checks();
            RefreshData();
        }
        #endregion

        #region Меню "Справочники"

        private void menuPlatforms_Click(object sender, EventArgs e)
        {
            FormCats form = new FormCats(1, Data.data.platforms);
            form.ShowDialog();
            Data.Save();
        }

        private void menuMediums_Click(object sender, EventArgs e)
        {
            FormCats form = new FormCats(2, Data.data.mediums);
            form.ShowDialog();
            Data.Save();
        }

        private void menuGenres_Click(object sender, EventArgs e)
        {
            FormCats form = new FormCats(3, Data.data.genres);
            form.ShowDialog();
            Data.Save();
            RefreshData();
        }

        #endregion

        #region Меню "Сервис"

        private void showStat(object sender, EventArgs e)
        {
            using (FormStatistic form = new FormStatistic()) form.ShowDialog();
        }

        private void showBuyHistory(object sender, EventArgs e)
        {
            using (FormHistory form = new FormHistory()) form.ShowDialog();
        }

        private void showPlayHistory(object sender, EventArgs e)
        {
            using (FormPlayHistory form = new FormPlayHistory()) form.ShowDialog();
        }
        #endregion

        #region Меню "Справка"

        private void menuPage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://sg-software.ru/mygames");
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            using (FormAbout form = new FormAbout()) form.ShowDialog();
        }

        #endregion

        #region "Поиск"
        private void toolSearch_TextChanged(object sender, EventArgs e) { toolReset.Enabled = toolSearch.Text != ""; RefreshData(); }
        private void toolReset_Click(object sender, EventArgs e) { toolSearch.Text = ""; }
        #endregion

        #region Параметры программы

        /// <summary>
        /// Обновление чекбоксов в меню
        /// </summary>
        void Checks()
        {
            menuFilter.Checked = toolFilter.Checked = Data.data.filter.enable;
            menuInfoPanel.Checked = toolInfoPanel.Checked = Settings.infoPanel;
            menuCol0.Checked = Settings.colorMode == 0;
            menuCol1.Checked = Settings.colorMode == 1;
            menuShowHidden.Checked = Settings.showHidden;
        }

        /// <summary>
        /// Показ или скрытие панели информации
        /// </summary>
        void ShowHideInfoView(bool resize)
        {
            //Порядок не нарушаем - иначе моргает из-за перерисовок.
            if (menuInfoPanel.Checked)
            {
                if (resize) Width += infoView.Width;
                listViewGames.Width = menuStrip.Width - infoView.Width;
                infoView.Left = menuStrip.Width - infoView.Width;
            }
            else
            {
                listViewGames.Width = menuStrip.Width;
                infoView.Left = menuStrip.Width;
                if (resize) Width -= infoView.Width;
            }
        }
        #endregion

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
                res = game1.date < game2.date ? 1 : -1;
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
