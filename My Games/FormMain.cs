using System;
using System.Windows.Forms;

using System.Collections;

namespace My_Games
{
    public partial class FormMain : Form
    {
        ItemComparer itemComparer = new ItemComparer(); //Эту залупу тоже убрать...

        public FormMain()
        {
            InitializeComponent();
            Data.Load();
            listViewGames.ListViewItemSorter = itemComparer;
            RefreshData();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Games\nВерсия: " + Program.Version, "О программе");
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

        private void listViewGames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) listViewGames_MouseDoubleClick(null, null);
        }

        private void listViewGames_MouseDoubleClick(object sender, MouseEventArgs e) { Open(); }

        private void listViewGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool selected = listViewGames.SelectedIndices.Count > 0;
            удалитьToolStripMenuItem.Enabled = selected;
            открытьToolStripMenuItem.Enabled = selected;
            удалитьToolStripMenuItem1.Enabled = selected;
        }

        #region Вид приложения, обновление
        void RefreshData()
        {
            GameDateComparer dc = new GameDateComparer();
            Data.data.games.Sort(dc);
            listViewGames.BeginUpdate();
            listViewGames.Items.Clear();
            foreach (Game g in Data.data.games)
                if (g.name.ToLower().Contains(toolStripTextBoxFind.Text.ToLower())) listViewGames.Items.Add(g.listItem());
            listViewGames.EndUpdate();
            //listViewGames.Items[30].Selected = true;
            //listViewGames.Items[30].Focused = true;
            //Подумать как после обновления списка оставить выделенным элемент который уже был выделен до обновления
        }

        /// <summary>
        /// Показ или скрытие панели информации
        /// </summary>
        /// <param name="resize"></param>
        void ShowHideInfoView(bool resize)
        {
            //Порядок не нарушаем - иначе моргает из-за перерисовок.
            if (infoViewMenu.Checked)
            {
                if (resize) Width += infoView.Width;
                listViewGames.Width = menuStrip1.Width - infoView.Width;
                infoView.Left = menuStrip1.Width - infoView.Width;
            }
            else
            {
                listViewGames.Width = menuStrip1.Width;
                infoView.Left = menuStrip1.Width;
                if (resize) Width -= infoView.Width;
            }
        }

        //Сортировка колонок
        private void listViewGames_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            itemComparer.ColumnIndex = e.Column;
            ((ListView)sender).Sort();
        }

        private void платформыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCats form = new FormCats(1, Data.data.platforms);
            form.ShowDialog();
            Data.Save();
        }

        private void носителиЭлектронныеМагазиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCats form = new FormCats(2, Data.data.mediums);
            form.ShowDialog();
            Data.Save();
        }

        private void жанрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCats form = new FormCats(3, Data.data.genres);
            form.ShowDialog();
            Data.Save();
            RefreshData();
        }
        #endregion

        #region Главное меню
        private void выходToolStripMenuItem_Click(object sender, EventArgs e) { Close(); }

        private void новаяToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void быстроеДобавлениеToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
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

        //Панель с кнопками

        private void toolStripButton1_Click(object sender, EventArgs e) { новаяToolStripMenuItem_Click(null, null); }
        private void toolStripTextBoxFind_TextChanged(object sender, EventArgs e) { RefreshData(); }

        private void toolStripButtonReset_Click(object sender, EventArgs e)
        {
            toolStripTextBoxFind.Text = "";
            RefreshData();
        }

        private void infoViewMenu_Click(object sender, EventArgs e)
        {
            infoViewMenu.Checked = !infoViewMenu.Checked;
            ShowHideInfoView(true);
        }
        #endregion

        #region Контекстное меню
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            удалитьToolStripMenuItem_Click(null, null);
        }
        #endregion

        #region Параметры программы
        private void FormMain_Load(object sender, EventArgs e)
        {
            Left = Properties.Settings.Default.Left;
            Top = Properties.Settings.Default.Top;
            Width = Properties.Settings.Default.Width;
            Height = Properties.Settings.Default.Height;
            infoViewMenu.Checked = Properties.Settings.Default.InfoView;
            ShowHideInfoView(false);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Left = Left;
            Properties.Settings.Default.Top = Top;
            Properties.Settings.Default.Width = Width;
            Properties.Settings.Default.Height = Height;
            Properties.Settings.Default.InfoView = infoViewMenu.Checked;
            Properties.Settings.Default.Save();
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
