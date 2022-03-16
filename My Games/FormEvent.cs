using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace My_Games
{
    public partial class FormEvent : Form
    {
        Event ev;
        List<Version> versions;
        List<Event> history;
        bool isUser;

        public FormEvent(Event ev, List<Version> versions, List<Event> history)
        {
            InitializeComponent();
            comboBoxEvent.DataSource = Event.events;
            this.ev = ev;
            this.versions = versions;
            this.history = history;
            RefreshData();
        }

        void RefreshData()
        {
            isUser = false;
            date.Value = ev.date;
            Platform.FillCombobox(comboBoxPlatform, ev.platform, checkBoxAll.Checked, versions);
            comboBoxEvent.SelectedIndex = ev.even;
            textBoxHours.Text = ev.hours.ToString();
            textBoxHoursAll.Text = ev.hoursAll.ToString();
            textBoxComment.Text = ev.comment;
            //Если название не совпадает с сохранённым - открываем весь список платформ
            string pl = Data.PlatformIDToName(ev.platform);
            if (comboBoxPlatform.Text != pl & pl != "") checkBoxAll.Checked = true;
            isUser = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ev.date = date.Value;
            ev.platform = Data.PlatformNameToID(comboBoxPlatform.Text);
            ev.even = comboBoxEvent.SelectedIndex;
            ev.hours = Data.TextToInt(textBoxHours.Text);
            ev.hoursAll = Data.TextToInt(textBoxHoursAll.Text);
            ev.comment = textBoxComment.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void linkLabelPlatform_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDict form = new FormDict(1, Data.data.platforms);
            form.ShowDialog();
            Platform.FillCombobox(comboBoxPlatform, ev.platform, checkBoxAll.Checked, versions);
        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            Platform.FillCombobox(comboBoxPlatform, ev.platform, checkBoxAll.Checked, versions);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!isUser) return;
            int all = Data.TextToInt(textBoxHoursAll.Text);
            int pl = Data.PlatformNameToID(comboBoxPlatform.Text);
            foreach (Event ev in history)
                if (ev.platform == pl & ev.date < date.Value)
                    all -= ev.hours;
            if (all >= 0) textBoxHours.Text = all.ToString();
        }
    }
}
