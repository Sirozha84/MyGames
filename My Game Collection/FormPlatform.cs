using System;
using System.Windows.Forms;

namespace My_Game_Collection
{
    public partial class FormPlatform : Form
    {
        Platform p;

        public FormPlatform(Platform p)
        {
            InitializeComponent();
            this.p = p;
            textBoxName.Text = p.name;
            textBoxCompany.Text = p.company;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            p.name = textBoxName.Text;
            p.company = textBoxCompany.Text;
        }
    }
}
