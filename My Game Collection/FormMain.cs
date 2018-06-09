using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Game_Collection
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Data.Load();
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
                Data.games.Add(game);
                Data.Save();
                DrawList();
            }
        }

        void DrawList()
        {
            listViewGames.BeginUpdate();
            listViewGames.Items.Clear();
            foreach (Game g in Data.games)
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
                    if (form.change)
                    {
                        Data.Save();
                        DrawList();
                    }
                }
            }
        }
    }
}
