using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace My_Games
{
    public class Game
    {
        public static string[] stars = { "*", "* *", "* * *", "* * * *", "* * * * *" };

        //Данные игры
        public int ID;
        public string name;
        public string developer;
        public string publisher;
        public string year;
        public int genre;
        public int rate = 3;
        public string website;
        public string cover;
        public string comment;
        public List<Version> versions = new List<Version>();
        public List<DLC> DLCs = new List<DLC>();
        public List<Event> history = new List<Event>();
        public List<Note> notes = new List<Note>();

        //Итоговые данные для быстрого доступа
        public DateTime date = DateTime.Now;
        public int win;
        public int hours;
        public int price;
        
        //Данные документа, не относящиеся к игре
        public DateTime create = DateTime.Now;
        public DateTime change = DateTime.Now;

        /// <summary>
        /// Получает элемент списка раскрашенный в заданном режиме
        /// </summary>
        public ListViewItem listItem()
        {
            string[] labels = {date.ToString("dd.MM.yyyy"), name, Data.GenreIDToName(genre), stars[rate - 1],
                Event.events[win], hours.ToString(Program.num), versions.Count().ToString(Program.num), price.ToString(Program.num)};
            ListViewItem item = new ListViewItem(labels);
            item.Tag = this;
            if (Properties.Settings.Default.colorMode == 1)
                item.BackColor = Color.FromArgb(Data.data.winColR[win], Data.data.winColG[win], Data.data.winColB[win]);
            return item;
        }
    }

    class GameDateComparer : IComparer<Game>
    {
        public int Compare(Game o1, Game o2)
        {
            return o1.date > o2.date ? 1 : -1;
        }
    }
}
