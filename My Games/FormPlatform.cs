using System;
using System.Windows.Forms;

namespace My_Games
{
    public partial class FormPlatform : Form
    {
        Platform p;

        public FormPlatform(Platform p)
        {
            InitializeComponent();
            foreach (Medium m in Data.data.mediums)
                checkedListBox.Items.Add(m.name);
            this.p = p;
            textBoxName.Text = p.name;
            textBoxCompany.Text = p.company;
            buttonCol.BackColor = p.color();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            p.name = textBoxName.Text;
            p.company = textBoxCompany.Text;
        }
    }
}
