using System;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Collections;

namespace My_Game_Collection
{
    public partial class FormMain : Form
    {
        Data data;
        ItemComparer itemComparer = new ItemComparer();

        public FormMain()
        {
            InitializeComponent();
            LoadData();
            listViewGames.ListViewItemSorter = itemComparer;
            DrawList();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Game Collection\nВерсия 0.1");
        }

        private void toolStripButton1_Click(object sender, EventArgs e) { новаяToolStripMenuItem_Click(null, null); }

        private void новаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            FormGame form = new FormGame(game);
            if (form.ShowDialog() == DialogResult.OK)
            {
                data.games.Add(game);
                SaveData();
                DrawList();
            }
        }

        void DrawList()
        {
            GameDateComparer dc = new GameDateComparer();
            data.games.Sort(dc);
            listViewGames.BeginUpdate();
            listViewGames.Items.Clear();
            foreach (Game g in data.games)
                listViewGames.Items.Add(g.listItem());
            listViewGames.EndUpdate();
        }

        private void listViewGames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) listViewGames_MouseDoubleClick(null, null);
        }

        private void listViewGames_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewGames.SelectedItems.Count == 1)
            {
                Game game = (Game)listViewGames.SelectedItems[0].Tag;
                FormGame form = new FormGame(game);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveData();
                    DrawList();
                }
            }
        }

        public void LoadData()
        {
            try
            {
                var serializer = new XmlSerializer(typeof(Data));
                using (var reader = new StreamReader("Data.xml"))
                    data = (Data)serializer.Deserialize(reader);
            }
            catch
            {
                data = new Data();
            }
        }

        public void SaveData()
        {
            try
            {
                var serializer = new XmlSerializer(typeof(Data));
                using (var writer = new StreamWriter("Data.xml"))
                    serializer.Serialize(writer, data);
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении данных");
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
            FormCats form = new FormCats(1, data.platforms);
            form.ShowDialog();
            SaveData();
        }

        private void носителиЭлектронныеМагазиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCats form = new FormCats(2, data.platforms);
            form.ShowDialog();
            SaveData();
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
            if (columnIndex == 2)
                res = String.Compare(game1.genre, game2.genre);
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
