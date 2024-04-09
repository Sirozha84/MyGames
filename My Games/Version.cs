using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace My_Games
{
    public class Version
    {
        public DateTime date;
        public int platform;
        public int medium;
        public int price;
        public string comment;
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
            comment = v.comment;
        }

        public ListViewItem listItem()
        {
            string[] labels = {date.ToString("dd.MM.yyyy"),
                Data.PlatformIDToName(platform),
                Data.MediumIDToName(medium),
                price.ToString(Program.num),
                comment};
            return new ListViewItem(labels) { Tag = this };
        }
    }
}
