using System;
using System.Windows.Forms;

namespace My_Game_Collection
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
            comboBoxPlatform.Items.Clear();
            comboBoxPlatform.Items.Add("");
            foreach (Platform p in Data.data.platforms)
                comboBoxPlatform.Items.Add(p.name);
            date.Value = version.date;
            comboBoxPlatform.Text = Data.PlatformIDtoName(version.platform);
            comboBoxMedium.Text = version.medium;
            textBoxPrice.Text = version.price.ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            version.date = date.Value;
            version.platform = Data.PlatformNametoID(comboBoxPlatform.Text);
            version.medium = comboBoxMedium.Text;
            version.price = Convert.ToInt32(textBoxPrice.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void linkLabelPlatform_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCats form = new FormCats(1, Data.data.platforms);
            form.ShowDialog();
            RefreshData();
        }
    }
}
