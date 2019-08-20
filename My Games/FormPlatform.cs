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
            buttonCol.BackColor = p.color;
            foreach (int m in p.mediums)
                checkedListBox.SetItemChecked(checkedListBox.FindString(Data.MediumIDToName(m)), true);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            p.name = textBoxName.Text;
            p.company = textBoxCompany.Text;
            p.color = buttonCol.BackColor;
            p.mediums.Clear();
            foreach (object o in checkedListBox.CheckedItems)
                p.mediums.Add(Data.MediumNameToID(o.ToString()));
        }

        private void ButtonCol_Click(object sender, EventArgs e)
        {
            using (ColorDialog col = new ColorDialog())
                if (col.ShowDialog() == DialogResult.OK)
                    buttonCol.BackColor = col.Color;
        }
    }
}
