using System;
using System.Windows.Forms;

namespace My_Games
{
    public partial class FormEvent : Form
    {
        Event ev;

        public FormEvent(Event ev)
        {
            InitializeComponent();
            comboBoxEvent.DataSource = Event.events;
            this.ev = ev;
            RefreshData();
        }

        void RefreshData()
        {
            date.Value = ev.date;
            Platform.FillCombobox(comboBoxPlatform, ev.platform);
            comboBoxEvent.SelectedIndex = ev.even;
            textBoxHours.Text = ev.hours.ToString();
            textBoxComment.Text = ev.comment;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ev.date = date.Value;
            ev.platform = Data.PlatformNameToID(comboBoxPlatform.Text);
            ev.even = comboBoxEvent.SelectedIndex;
            ev.hours= Convert.ToInt32(textBoxHours.Text);
            ev.comment = textBoxComment.Text;
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
