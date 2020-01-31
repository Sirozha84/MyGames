using System;
using System.Windows.Forms;

namespace My_Games
{
    public partial class FormMedium : Form
    {
        Medium m;

        public FormMedium(Medium m)
        {
            InitializeComponent();
            this.m = m;
            textBoxName.Text = m.name;
            buttonCol.BackColor = m.color;
            radioButtonPh.Checked = m.mediumType == 0;
            radioButtonEl.Checked = m.mediumType == 1;
            radioButtonSb.Checked = m.mediumType == 2;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            m.name = textBoxName.Text;
            m.color = buttonCol.BackColor;
            if (radioButtonPh.Checked) m.mediumType = 0;
            if (radioButtonEl.Checked) m.mediumType = 1;
            if (radioButtonSb.Checked) m.mediumType = 2;
        }

        private void buttonCol_Click(object sender, EventArgs e)
        {
            using (ColorDialog col = new ColorDialog())
                if (col.ShowDialog() == DialogResult.OK)
                    buttonCol.BackColor = col.Color;
        }
    }
}
