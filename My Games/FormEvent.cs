using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace My_Games
{
    public partial class FormEvent : Form
    {
        Event ev;
        List<Version> versions;

        public FormEvent(Event ev, List<Version> versions)
        {
            InitializeComponent();
            comboBoxEvent.DataSource = Event.events;
            this.versions = versions;
            this.ev = ev;
            RefreshData();
        }

        void RefreshData()
        {
            date.Value = ev.date;
            Platform.FillCombobox(comboBoxPlatform, ev.platform, checkBoxAll.Checked, versions);
            comboBoxEvent.SelectedIndex = ev.even;
            textBoxHours.Text = ev.hours.ToString();
            textBoxMinutes.Text = ev.minutes.ToString();
            textBoxComment.Text = ev.comment;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ev.date = date.Value;
            ev.platform = Data.PlatformNameToID(comboBoxPlatform.Text);
            ev.even = comboBoxEvent.SelectedIndex;
            ev.hours = Data.TextToInt(textBoxHours.Text);
            ev.minutes = Data.TextToInt(textBoxMinutes.Text);
            ev.comment = textBoxComment.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void linkLabelPlatform_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCats form = new FormCats(1, Data.data.platforms);
            form.ShowDialog();
            Platform.FillCombobox(comboBoxPlatform, ev.platform, checkBoxAll.Checked, versions);
        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            Platform.FillCombobox(comboBoxPlatform, ev.platform, checkBoxAll.Checked, versions);
        }
    }
}
