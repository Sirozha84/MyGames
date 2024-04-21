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
            radioGame.Checked = p.type == 0;
            radioVideo.Checked = p.type == 1;
            buttonCol.BackColor = p.color;
            foreach (int m in p.mediums)
                checkedListBox.SetItemChecked(checkedListBox.FindString(Data.MediumIDToName(m)), true);
            textBoxName_TextChanged(null, null);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            p.name = textBoxName.Text;
            p.company = textBoxCompany.Text;
            if (radioGame.Checked) p.type = 0;
            if (radioVideo.Checked) p.type = 1;
            p.color = buttonCol.BackColor;
            p.mediums.Clear();
            if (p.type == 0)
                foreach (object o in checkedListBox.CheckedItems)
                    p.mediums.Add(Data.MediumNameToID(o.ToString()));
        }

        private void ButtonCol_Click(object sender, EventArgs e)
        {
            using (ColorDialog col = new ColorDialog())
                if (col.ShowDialog() == DialogResult.OK)
                    buttonCol.BackColor = col.Color;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            buttonOK.Enabled = textBoxName.Text != "";
        }

        private void radioChanged(object sender, EventArgs e)
        {
            checkedListBox.Enabled = !radioVideo.Checked;
        }
    }
}
