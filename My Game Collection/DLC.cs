using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Game_Collection
{
    public class DLC
    {
        DateTime date;
        string platform;
        string name;
        int price;
        string comment;

        public ListViewItem listItem()
        {
            string[] labels = {date.ToString("dd.MM.yyyy"),
                platform, name, price.ToString(), comment};
            return new ListViewItem(labels);
        }
    }
}
