namespace My_Games
{
    public partial class FormHistory : Form
    {
        List<PlayHistoryString> list = new List<PlayHistoryString>();
        bool isUser = false;

        public FormHistory()
        {
            InitializeComponent();

            Size = MinimumSize = new Size((int)(1000 * Program.scale), (int)(700 * Program.scale));
            listViewHistory.Columns[0].Width = (int)(100 * Program.scale);
            listViewHistory.Columns[1].Width = (int)(200 * Program.scale);
            listViewHistory.Columns[2].Width = (int)(150 * Program.scale);
            listViewHistory.Columns[3].Width = (int)(150 * Program.scale);
            listViewHistory.Columns[4].Width = (int)(125 * Program.scale);
            listViewHistory.Columns[5].Width = (int)(50 * Program.scale);
            listViewHistory.Columns[6].Width = (int)(175 * Program.scale);

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
                    list.Add(new PlayHistoryString(ev.date, game.name, ev.platform, game.genre, ev.even, ev.hours, ev.comment));
            }
            list.Sort((o1, o2) => o1.time.CompareTo(o2.time));

            Refresh();

        }

        void Refresh()
        {
            int count = 0;
            int hours = 0;
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
                }
            }
            listViewHistory.EndUpdate();
            toolStripStatusLabel1.Text = "Количество: " + count.ToString(Program.num);
            toolStripStatusLabel2.Text = "Часы: " + hours.ToString(Program.num);
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
        public string comment;
        public PlayHistoryString(DateTime time, string name, int platform, int genre, int even, int hours, string comment)
        {
            this.time = time;
            this.name = name;
            this.platform = Data.PlatformIDToName(platform);
            this.genre = Data.GenreIDToName(genre);
            this.even = Event.events[even];
            this.hours = hours;
            this.comment = comment;
        }

        public ListViewItem GetListViewItem()
        {
            string[] item = { time.ToString("dd.MM.yyyy"), name, platform, genre, even, hours.ToString(Program.num), comment };
            return new ListViewItem(item);
        }
    }
}
