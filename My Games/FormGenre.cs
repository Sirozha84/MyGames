using System;
using System.Windows.Forms;

namespace My_Games
{
    public partial class FormGenre : Form
    {
        Genre g;

        public FormGenre(Genre g)
        {
            InitializeComponent();
            this.g = g;
            textBoxName.Text = g.name;
            buttonCol.BackColor = g.color;
            textBoxName_TextChanged(null, null);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            g.name = textBoxName.Text;
            g.color = buttonCol.BackColor;
        }

        private void buttonCol_Click(object sender, EventArgs e)
        {
            using (ColorDialog col = new ColorDialog())
                if (col.ShowDialog() == DialogResult.OK)
                    buttonCol.BackColor = col.Color;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            buttonOK.Enabled = textBoxName.Text != "";
        }
    }
}
