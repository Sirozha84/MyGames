using System;
using System.Windows.Forms;

namespace My_Game_Collection
{
    public partial class FormEvent : Form
    {
        Event ev;

        public FormEvent(Event ev)
        {
            InitializeComponent();
            comboBoxEvent.DataSource = Event.events;
            this.ev = ev;
            date.Value = ev.date;
            comboBoxPlatform.Text = Data.PlatformIDtoName(ev.platform);
            comboBoxEvent.SelectedIndex = ev.even;
            textBoxHours.Text = ev.hours.ToString();
            textBoxComment.Text = ev.comment;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ev.date = date.Value;
            ev.platform = Data.PlatformNametoID(comboBoxPlatform.Text);
            ev.even = comboBoxEvent.SelectedIndex;
            ev.hours= Convert.ToInt32(textBoxHours.Text);
            ev.comment = textBoxComment.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
