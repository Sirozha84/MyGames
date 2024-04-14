using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace My_Games
{
    public partial class FormDLC : Form
    {
        DLC dlc;
        List<Version> versions;
        public FormDLC(DLC dlc, List<Version> versions)
        {
            InitializeComponent();
            this.dlc = dlc;
            this.versions = versions;
            RefreshData();
        }

        void RefreshData()
        {
            date.Value = dlc.date;
            Platform.FillCombobox(comboBoxPlatform, dlc.platform, checkBoxAll.Checked, versions);
            textBoxName.Text = dlc.name;
            textBoxPrice.Text = dlc.price.ToString();
            textBoxComment.Text = dlc.comment;
            //Если название не совпадает с сохранённым - открываем весь список платформ
            string pl = Data.PlatformIDToName(dlc.platform);
            if (comboBoxPlatform.Text != pl & pl != "") checkBoxAll.Checked = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (comboBoxPlatform.Text == "")
            {
                MessageBox.Show("Не выбрана платформа");
                return;
            }
            dlc.date = date.Value;
            dlc.platform = Data.PlatformNameToID(comboBoxPlatform.Text);
            dlc.name = textBoxName.Text;
            dlc.price = Data.TextToInt(textBoxPrice.Text);
            dlc.comment = textBoxComment.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void linkLabelPlatform_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCats form = new FormCats(1, Data.data.platforms);
            form.ShowDialog();
            Platform.FillCombobox(comboBoxPlatform, dlc.platform, checkBoxAll.Checked, versions);
        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            Platform.FillCombobox(comboBoxPlatform, dlc.platform, checkBoxAll.Checked, versions);
        }
    }
}
