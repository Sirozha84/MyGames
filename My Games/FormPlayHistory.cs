using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace My_Games
{
    public partial class FormPlayHistory : Form
    {
        List<PlayHistoryString> list = new List<PlayHistoryString>();
        bool isUser = false;

        public FormPlayHistory()
        {
            InitializeComponent();

            //Заполняем выпадающме списки и выбираем первый пункт

            comboBoxPlatform.Items.Add("Все");
            foreach (Platform pl in Data.data.platforms)
                comboBoxPlatform.Items.Add(pl.name);
            comboBoxPlatform.SelectedIndex = 0;

            comboBoxGenre.Items.Add("Все");
            foreach (Genre gr in Data.data.genres)
                comboBoxGenre.Items.Add(gr.name);
            comboBoxGenre.SelectedIndex = 0;

            foreach (Game game in Data.data.games)
            {
                foreach (Event ev in game.history)
                    list.Add(new PlayHistoryString(ev.date, game.name, ev.platform, game.genre,
                        ev.even, ev.hours, ev.minutes, ev.comment));
            }
            list.Sort((o1, o2) => o1.time.CompareTo(o2.time));

            Refresh();

        }

        void Refresh()
        {
            int count = 0;
            int hours = 0;
            int minutes = 0;
            listViewHistory.BeginUpdate();
            listViewHistory.Items.Clear();
            foreach (PlayHistoryString str in list)
            {
                bool ok = true;
                if (comboBoxPlatform.SelectedIndex > 0 && comboBoxPlatform.SelectedItem.ToString() != str.platform) ok = false;
                if (comboBoxGenre.SelectedIndex > 0 && comboBoxGenre.SelectedItem.ToString() != str.genre) ok = false;
                if (ok)
                {
                    listViewHistory.Items.Add(str.GetListViewItem());
                    count++;
                    hours += str.hours;
                    minutes += str.minutes;
                }
            }
            listViewHistory.EndUpdate();
            toolStripStatusLabel1.Text = "Количество: " + count.ToString();
            toolStripStatusLabel2.Text = "Время: " + Data.TimeToString(hours, minutes);
            isUser = true;
        }

        private void ComboBoxPlatform_SelectedIndexChanged(object sender, EventArgs e) { if (isUser) Refresh(); }
        private void ComboBoxGenre_SelectedIndexChanged(object sender, EventArgs e) { if (isUser) Refresh(); }
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            isUser = false;
            comboBoxPlatform.SelectedIndex = 0;
            comboBoxGenre.SelectedIndex = 0;
            Refresh();
        }
    }

    class PlayHistoryString
    {
        public DateTime time;
        string name;
        public string platform;
        public string genre;
        public string even;
        public int hours;
        public int minutes;
        string comment;

        public PlayHistoryString(DateTime time, string name, int platform, int genre,
            int even, int hours, int minutes, string comment)
        {
            this.time = time;
            this.name = name;
            this.platform = Data.PlatformIDToName(platform);
            this.genre = Data.GenreIDToName(genre);
            this.even = Event.events[even];
            this.hours = hours;
            this.minutes = minutes;
            this.comment = comment;
        }

        public ListViewItem GetListViewItem()
        {
            string[] item = { time.ToString("dd.MM.yyyy"), name, platform, genre, even,
                Data.TimeToString(hours, minutes), comment };
            return new ListViewItem(item);
        }
    }
}
