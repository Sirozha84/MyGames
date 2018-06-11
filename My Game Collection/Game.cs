using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Game_Collection
{
    public class Game
    {
        DateTime date = DateTime.Now;
        public string name;
        public string publisher;
        public int year;
        public string genre;
        public byte rate = 3;
        public string win = "Нет";
        public int hours;
        public int price;
        public List<Version> versions = new List<Version>();
        public List<DLC> DLCs = new List<DLC>();
        public List<Event> History = new List<Event>();
        public string comment;

        string[] stars = { "*", "* *", "* * *", "* * * *", "* * * * *" };


        public ListViewItem listItem()
        {
            string[] labels = {date.ToString("dd.MM.yyyy"), name, genre, stars[rate - 1],
                win, hours.ToString(), versions.Count().ToString(), price.ToString()};
            ListViewItem item = new ListViewItem(labels);
            item.Tag = this;
            return item;
        }
    }
}
