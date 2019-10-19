using System;
using System.Windows.Forms;

namespace My_Games
{
    public partial class FormVersion : Form
    {
        Version version;

        public FormVersion(Version version)
        {
            InitializeComponent();
            this.version = version;
            RefreshData();
        }

        void RefreshData()
        {
            date.Value = version.date;
            Platform.FillCombobox(comboBoxPlatform, version.platform);
            Medium.FillCombobox(comboBoxMedium, version.medium, "");
            textBoxPrice.Text = version.price.ToString();
            textBoxComment.Text = version.comment;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            version.date = date.Value;
            version.platform = Data.PlatformNameToID(comboBoxPlatform.Text);
            version.medium = Data.MediumNameToID(comboBoxMedium.Text);
            version.price = Convert.ToInt32(textBoxPrice.Text);
            version.comment = textBoxComment.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void linkLabelPlatform_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCats form = new FormCats(1, Data.data.platforms);
            form.ShowDialog();
            Platform.FillCombobox(comboBoxPlatform, version.platform);
        }

        private void linkLabelMedium_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCats form = new FormCats(2, Data.data.mediums);
            form.ShowDialog();
            Medium.FillCombobox(comboBoxMedium, version.medium, comboBoxPlatform.Text);
        }

        private void ComboBoxPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            Medium.FillCombobox(comboBoxMedium, version.medium, comboBoxPlatform.Text);
        }
    }
}
