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

        public DateTime date = DateTime.Now;
        public DateTime create = DateTime.Now;
        public DateTime change = DateTime.Now;
        public string name;
        public string developer;
        public string publisher;
        public string year;
        public int genre;
        public int rate = 3;
        public int win;
        public int hours;
        public int price;
        public List<Version> versions = new List<Version>();
        public List<DLC> DLCs = new List<DLC>();
        public List<Event> history = new List<Event>();
        public string comment;

        public ListViewItem listItem()
        {
            string[] labels = {date.ToString("dd.MM.yyyy"), name, Data.GenreIDToName(genre), stars[rate - 1],
                Event.events[win], hours.ToString(), versions.Count().ToString(), price.ToString()};
            ListViewItem item = new ListViewItem(labels);
            item.Tag = this;
            if (win == 0) item.BackColor = Color.FromArgb(255, 192, 192);
            if (win == 1) item.BackColor = Color.FromArgb(255, 224, 192);
            if (win == 2) item.BackColor = Color.FromArgb(255, 255, 192);
            if (win == 3) item.BackColor = Color.FromArgb(224, 255, 192);
            if (win == 4) item.BackColor = Color.FromArgb(192, 255, 192);
            if (win == 5) item.BackColor = Color.FromArgb(160, 255, 160);
            if (win == 6) item.BackColor = Color.FromArgb(192, 255, 255);
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
