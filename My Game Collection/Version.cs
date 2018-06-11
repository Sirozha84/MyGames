using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace My_Game_Collection
{
    public class Version
    {
        public DateTime date;
        public string platform;
        public string medium;
        public int price;
        
        public Version()
        {
            date = DateTime.Now;
        }

        public Version(Version v)
        {
            date = v.date;
            platform = v.platform;
            medium = v.medium;
            price = v.price;
        }

        public ListViewItem listItem()
        {
            string[] labels = {date.ToString("dd.MM.yyyy"),
                platform, medium, price.ToString()};
            ListViewItem item = new ListViewItem(labels);
            item.Tag = this;
            return item;
        }
    }
    
    class VersionDateComparer : IComparer<Version>
    {
        public int Compare(Version o1, Version o2)
        {
            return o1.date > o2.date ? 1 : -1;
        }
    }
}
