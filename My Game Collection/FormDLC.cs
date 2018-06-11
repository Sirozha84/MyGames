using System;
using System.Windows.Forms;

namespace My_Game_Collection
{
    public partial class FormDLC : Form
    {
        DLC dlc;

        public FormDLC(DLC dlc)
        {
            InitializeComponent();
            this.dlc = dlc;
            date.Value = dlc.date;
            comboBoxPlatform.Text = dlc.platform;
            textBoxName.Text = dlc.name;
            textBoxPrice.Text = dlc.price.ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            dlc.date = date.Value;
            dlc.platform = comboBoxPlatform.Text;
            dlc.name = textBoxName.Text;
            dlc.price = Convert.ToInt32(textBoxPrice.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
