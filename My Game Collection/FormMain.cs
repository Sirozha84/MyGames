using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace My_Game_Collection
{
    public partial class FormMain : Form
    {
        Data data;

        public FormMain()
        {
            InitializeComponent();
            Load();
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
                Save();
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

        private void listViewGames_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewGames.SelectedItems.Count == 1)
            {
                Game game = (Game)listViewGames.SelectedItems[0].Tag;
                FormGame form = new FormGame(game);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Save();
                    DrawList();
                }
            }
        }

        public void Load()
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

        public void Save()
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
    }
}
