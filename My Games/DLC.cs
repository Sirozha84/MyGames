using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace My_Games
{
    public class DLC
    {
        public DateTime date;
        public int platform;
        public string name;
        public int price;
        public string comment;
        public DLC()
        {
            date = DateTime.Now;
        }

        public DLC(DLC dlc)
        {
            date = dlc.date;
            platform = dlc.platform;
            name = dlc.name;
            price = dlc.price;
            comment = dlc.comment;
        }

        public ListViewItem listItem()
        {
            string[] labels = {date.ToString("dd.MM.yyyy"),
                Data.PlatformIDToName(platform),
                name,
                price.ToString(Program.num),
                comment};
            return new ListViewItem(labels) { Tag = this };
        }
    }
}
