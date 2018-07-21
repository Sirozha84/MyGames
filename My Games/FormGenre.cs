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
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            g.name = textBoxName.Text;
        }
    }
}
