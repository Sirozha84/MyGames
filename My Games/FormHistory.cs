using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace My_Games
{
    public partial class FormHistory : Form
    {
        List<HistoryString> list = new List<HistoryString>();
        bool isUser = false;

        public FormHistory()
        {
            InitializeComponent();

            //Заполняем выпадающме списки и выбираем первый пункт
            comboBoxType.Items.Add("Все");
            comboBoxType.Items.Add("Игра");
            comboBoxType.Items.Add("DLC");
            comboBoxType.SelectedIndex = 0;

            comboBoxPlatform.Items.Add("Все");
            foreach (Platform pl in Data.data.platforms)
                comboBoxPlatform.Items.Add(pl.name);
            comboBoxPlatform.SelectedIndex = 0;

            comboBoxMedium.Items.Add("Все");
            foreach (Medium md in Data.data.mediums)
                comboBoxMedium.Items.Add(md.name);
            comboBoxMedium.SelectedIndex = 0;

            comboBoxGenre.Items.Add("Все");
            foreach (Genre gr in Data.data.genres)
                comboBoxGenre.Items.Add(gr.name);
            comboBoxGenre.SelectedIndex = 0;

            foreach (Game game in Data.data.games)
            {
                foreach (Version ver in game.versions)
                    list.Add(new HistoryString(ver.date, game.name, "Игра", ver.platform, ver.medium, game.genre, ver.price));
                foreach (DLC dlc in game.DLCs)
                    list.Add(new HistoryString(dlc.date, game.name, "DLC", dlc.platform, 0, game.genre, dlc.price));
            }
            list.Sort((o1, o2) => o1.time.CompareTo(o2.time));

            Refresh();
        }

        void Refresh()
        {
            int count = 0;
            int price = 0;
            listViewHistory.BeginUpdate();
            listViewHistory.Items.Clear();
            foreach (HistoryString str in list)
            {
                bool ok = true;
                if (comboBoxType.SelectedIndex > 0 && comboBoxType.SelectedItem.ToString() != str.type) ok = false;
                if (comboBoxPlatform.SelectedIndex > 0 && comboBoxPlatform.SelectedItem.ToString() != str.platform) ok = false;
                if (comboBoxMedium.SelectedIndex > 0 && comboBoxMedium.SelectedItem.ToString() != str.medium) ok = false;
                if (comboBoxGenre.SelectedIndex > 0 && comboBoxGenre.SelectedItem.ToString() != str.genre) ok = false;
                if (ok)
                {
                    listViewHistory.Items.Add(str.GetListViewItem());
                    count++;
                    price += str.price;
                }
            }
            listViewHistory.EndUpdate();
            toolStripStatusLabelCount.Text = "Количество: " + count.ToString();
            toolStripStatusLabelSpent.Text = "Потрачено: " + price.ToString();
            isUser = true;
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e) { if (isUser) Refresh(); }
        private void ComboBoxPlatform_SelectedIndexChanged(object sender, EventArgs e) { if (isUser) Refresh(); }
        private void ComboBoxMedium_SelectedIndexChanged(object sender, EventArgs e) { if (isUser) Refresh(); }
        private void ComboBoxGenre_SelectedIndexChanged(object sender, EventArgs e) { if (isUser) Refresh(); }
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            isUser = false;
            comboBoxType.SelectedIndex = 0;
            comboBoxPlatform.SelectedIndex = 0;
            comboBoxMedium.SelectedIndex = 0;
            comboBoxGenre.SelectedIndex = 0;
            Refresh();
        }
    }

    class HistoryString
    {
        public DateTime time;
        string name;
        public string type;
        public string platform;
        public string medium;
        public string genre;
        public int price;

        public HistoryString(DateTime time, string name, string type, int platform, int medium, int genre, int price)
        {
            this.time = time;
            this.name = name;
            this.type = type;
            this.platform = Data.PlatformIDToName(platform);
            this.medium = Data.MediumIDToName(medium);
            this.genre = Data.GenreIDToName(genre);
            this.price = price;
        }

        public ListViewItem GetListViewItem()
        {
            string[] item = { time.ToString("dd.MM.yyyy"), name, type, platform, medium, genre, price.ToString() };
            return new ListViewItem(item);
        }
    }
}
