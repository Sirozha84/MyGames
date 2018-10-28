using System;
using System.Windows.Forms;

namespace My_Games
{
    public partial class FormDLC : Form
    {
        DLC dlc;

        public FormDLC(DLC dlc)
        {
            InitializeComponent();
            this.dlc = dlc;
            RefreshData();
        }

        void RefreshData()
        {
            date.Value = dlc.date;
            Platform.FillCombobox(comboBoxPlatform, dlc.platform);
            textBoxName.Text = dlc.name;
            textBoxPrice.Text = dlc.price.ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            dlc.date = date.Value;
            dlc.platform = Data.PlatformNameToID(comboBoxPlatform.Text);
            dlc.name = textBoxName.Text;
            dlc.price = Convert.ToInt32(textBoxPrice.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void linkLabelPlatform_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCats form = new FormCats(1, Data.data.platforms);
            form.ShowDialog();
            Platform.FillCombobox(comboBoxPlatform, dlc.platform);
        }
    }
}
