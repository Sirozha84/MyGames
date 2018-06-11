using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            date.Value = version.date;
            comboBoxPlatform.Text = version.platform;
            comboBoxMedium.Text = version.medium;
            textBoxPrice.Text = version.price.ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            version.date = date.Value;
            version.platform = comboBoxPlatform.Text;
            version.medium = comboBoxMedium.Text;
            version.price = Convert.ToInt32(textBoxPrice.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
