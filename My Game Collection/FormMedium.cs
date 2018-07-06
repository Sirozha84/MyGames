using System;
using System.Windows.Forms;

namespace My_Game_Collection
{
    public partial class FormMedium : Form
    {
        Medium m;

        public FormMedium(Medium m)
        {
            InitializeComponent();
            this.m = m;
            textBoxName.Text = m.name;
            checkBoxPhis.Checked = m.phisic;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            m.name = textBoxName.Text;
            m.phisic = checkBoxPhis.Checked;
        }
    }
}
