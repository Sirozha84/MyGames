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
    public partial class FormEvent : Form
    {
        Event ev;

        public FormEvent(Event ev)
        {
            InitializeComponent();
            comboBoxEvent.DataSource = Event.events;
            this.ev = ev;
            date.Value = ev.date;
            comboBoxPlatform.Text = ev.platform;
            comboBoxEvent.SelectedIndex = ev.even;
            textBoxHours.Text = ev.hours.ToString();
            textBoxComment.Text = ev.comment;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ev.date = date.Value;
            ev.platform = comboBoxPlatform.Text;
            ev.even = comboBoxEvent.SelectedIndex;
            ev.hours= Convert.ToInt32(textBoxHours.Text);
            ev.comment = textBoxComment.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
