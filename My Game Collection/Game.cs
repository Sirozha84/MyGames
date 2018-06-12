using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace My_Game_Collection
{
    public class Game
    {
        public DateTime date = DateTime.Now;
        public string name;
        public string publisher;
        public int year;
        public string genre;
        public byte rate = 3;
        public int win;
        public int hours;
        public int price;
        public List<Version> versions = new List<Version>();
        public List<DLC> DLCs = new List<DLC>();
        public List<Event> history = new List<Event>();
        public string comment;

        static string[] stars = { "*", "* *", "* * *", "* * * *", "* * * * *" };

        public ListViewItem listItem()
        {
            string[] labels = {date.ToString("dd.MM.yyyy"), name, genre, stars[rate - 1],
                Event.events[win], hours.ToString(), versions.Count().ToString(), price.ToString()};
            ListViewItem item = new ListViewItem(labels);
            item.Tag = this;
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
