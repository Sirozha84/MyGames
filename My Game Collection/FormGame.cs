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
    public partial class FormGame : Form
    {
        Game game;
        bool change;
        List<Version> versions = new List<Version>();

        public FormGame(Game game)
        {
            this.game = game;
            InitializeComponent();
            change = false;
            textBoxName.Text = game.name;
            foreach (Version v in game.versions)
                versions.Add(new Version(v));
            DrawVersions();
            textBoxComment.Text = game.comment;
        }
        
        private void textBoxName_TextChanged(object sender, EventArgs e) { change = true; }
        private void textBox2_TextChanged(object sender, EventArgs e) { change = true; }

        #region Versions
        private void buttonAddVersion_Click(object sender, EventArgs e)
        {
            Version version = new Version();
            FormVersion form = new FormVersion(version);
            if (form.ShowDialog() == DialogResult.OK)
            {
                versions.Add(version);
                change = true;
                DrawVersions();
            }
        }

        private void buttonChangeVersion_Click(object sender, EventArgs e)
        {
            if (listViewVersions.SelectedIndices.Count == 1)
            {
                Version version = (Version)listViewVersions.SelectedItems[0].Tag;
                FormVersion form = new FormVersion(version);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    change = true;
                    DrawVersions();
                }
            }
        }

        private void buttonDelVersion_Click(object sender, EventArgs e)
        {
            if (listViewVersions.SelectedIndices.Count == 1)
            {
                Version version = (Version)listViewVersions.SelectedItems[0].Tag;
                versions.Remove(version);
                change = true;
                DrawVersions();
                listViewVersions_SelectedIndexChanged(null, null);
            }
        }

        void DrawVersions()
        {
            listViewVersions.BeginUpdate();
            listViewVersions.Items.Clear();
            foreach (Version v in versions)
                listViewVersions.Items.Add(v.listItem());
            listViewVersions.EndUpdate();
        }

        private void listViewVersions_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool sel = listViewVersions.SelectedIndices.Count > 0;
            buttonChangeVersion.Enabled = sel;
            buttonDelVersion.Enabled = sel;
        }

        private void listViewVersions_MouseDoubleClick(object sender, MouseEventArgs e) { buttonChangeVersion_Click(null, null); }
        #endregion

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (change)
            {
                game.name = textBoxName.Text;
                game.versions.Clear();
                foreach (Version v in versions)
                    game.versions.Add(new Version(v));
                game.comment = textBoxComment.Text;
                DialogResult = DialogResult.OK;
            }
            Close();
        }

    }
}
