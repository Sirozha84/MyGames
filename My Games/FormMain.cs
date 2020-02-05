﻿using System;
using System.Windows.Forms;

using System.Collections;

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
            listViewGames.ListViewItemSorter = itemComparer;
            RefreshData();
            listViewGames.Columns[lastColumn].Text += " ▲";
        }

        void Open()
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

        void GoToSite()
        {
            Game game = (Game)listViewGames.SelectedItems[0].Tag;
            System.Diagnostics.Process.Start("http:" + game.website);
        }

        private void listViewGames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) listViewGames_MouseDoubleClick(null, null);
        }

        private void listViewGames_MouseDoubleClick(object sender, MouseEventArgs e) { Open(); }

        private void listViewGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool selected = listViewGames.SelectedIndices.Count > 0;
            bool enableSite = false;
            menuDel.Enabled = selected;
            открытьToolStripMenuItem.Enabled = selected;
            удалитьToolStripMenuItem1.Enabled = selected;
            //Инфопанель
            const string ns = "";
            Game game = selected? (Game)listViewGames.SelectedItems[0].Tag : new Game();
            label2.Text = selected ? game.name : ns;
            label4.Text = selected ? game.developer : ns;
            label6.Text = selected ? game.publisher : ns;
            label8.Text = selected ? game.year : ns;
            int selectC = listViewGames.SelectedIndices.Count;
            if (selectC == 1)
                enableSite = game.website != null & game.website != "";
            перейтиНаСайтToolStripMenuItem.Enabled = enableSite;
            if (selectC == 0)
                statusSelected.Text = "";
            else
                statusSelected.Text = "Выделено: " + selectC.ToString();
        }

        #region Вид приложения, обновление, сортировка

        void RefreshData()
        {
            GameDateComparer dc = new GameDateComparer();
            Data.data.games.Sort(dc);
            listViewGames.BeginUpdate();
            listViewGames.Items.Clear();
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
                            bool min = fl.startEnable? ver.date >= fl.start : true;
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
                    listViewGames.Items.Add(g.listItem());
                    showed++;
                }
            }
            listViewGames.EndUpdate();
            //listViewGames.Items[30].Selected = true;
            //listViewGames.Items[30].Focused = true;
            //Подумать как после обновления списка оставить выделенным элемент который уже был выделен до обновления
            StatusBas(showed);
        }

        void StatusBas(int showed)
        {
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

        //Сортировка колонок
        private void listViewGames_ColumnClick(object sender, ColumnClickEventArgs e)
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

        private void menuAdd_Click(object sender, EventArgs e)
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

        private void menuAddFast_Click(object sender, EventArgs e)
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

        private void menuDel_Click(object sender, EventArgs e)
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

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        #endregion

        #region Меню "Вид"
        
        private void menuFilter_Click(object sender, EventArgs e)
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

        private void menuInfoPanel_Click(object sender, EventArgs e)
        {
            menuInfoPanel.Checked = !menuInfoPanel.Checked;
            toolInfoPanel.Checked = menuInfoPanel.Checked;
            ShowHideInfoView(true);
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

        private void menuStat_Click(object sender, EventArgs e)
        {
            using (FormStatistic form = new FormStatistic()) form.ShowDialog();
        }

        private void menuPurchases_Click(object sender, EventArgs e)
        {
            using (FormHistory form = new FormHistory()) form.ShowDialog();
        }

        private void menuHistory_Click(object sender, EventArgs e)
        {
            using (FormPlayHistory form = new FormPlayHistory()) form.ShowDialog();
        }

        private void menuCol0_Click(object sender, EventArgs e)
        {
            menuCol0.Checked = true;
            menuCol1.Checked = false;
            Properties.Settings.Default.colorMode = 0;
            RefreshData();
        }

        private void menuCol1_Click(object sender, EventArgs e)
        {
            menuCol0.Checked = false;
            menuCol1.Checked = true;
            Properties.Settings.Default.colorMode = 1;
            RefreshData();
        }

        #endregion

        #region Меню "Справка"

        private void menuPage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sg-software.ru/windows/programs/mygames");
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            using (FormAbout form = new FormAbout()) form.ShowDialog();
        }

        #endregion

        #region панель инструментов

        private void toolAdd_ButtonClick(object sender, EventArgs e) { menuAdd_Click(null, null); }
        private void toolAddFast_Click(object sender, EventArgs e) { menuAddFast_Click(null, null); }

        private void toolFilter_Click(object sender, EventArgs e) { menuFilter_Click(null, null); }
        private void toolInfoPanel_Click(object sender, EventArgs e) { menuInfoPanel_Click(null, null); }

        private void toolStat_Click(object sender, EventArgs e) { menuStat_Click(null, null); }
        private void toolPurchases_Click(object sender, EventArgs e) { menuPurchases_Click(null, null); }
        private void toolHistory_Click(object sender, EventArgs e) { menuHistory_Click(null, null); }

        private void toolSearch_TextChanged(object sender, EventArgs e) { toolReset.Enabled = toolSearch.Text != ""; RefreshData(); }
        private void toolReset_Click(object sender, EventArgs e) { toolSearch.Text = ""; }

        #endregion

        #region Контекстное меню
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menuDel_Click(null, null);
        }

        private void ПерейтиНаСайтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToSite();
        }
        #endregion

        #region Параметры программы
        private void FormMain_Load(object sender, EventArgs e)
        {
            Left = Properties.Settings.Default.Left;
            Top = Properties.Settings.Default.Top;
            Width = Properties.Settings.Default.Width;
            Height = Properties.Settings.Default.Height;
            menuFilter.Checked = Data.data.filter.enable;
            toolFilter.Checked = Data.data.filter.enable;
            menuInfoPanel.Checked = Properties.Settings.Default.InfoView;
            toolInfoPanel.Checked = Properties.Settings.Default.InfoView;
            menuCol0.Checked = Properties.Settings.Default.colorMode == 0;
            menuCol1.Checked = Properties.Settings.Default.colorMode == 1;
            ShowHideInfoView(false);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Left = Left;
            Properties.Settings.Default.Top = Top;
            Properties.Settings.Default.Width = Width;
            Properties.Settings.Default.Height = Height;
            Properties.Settings.Default.InfoView = menuInfoPanel.Checked;
            Properties.Settings.Default.Save();
            Data.Save();
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
