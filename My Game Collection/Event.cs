using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Game_Collection
{
    public class Event
    {
        DateTime date;
        string even;
        string comment;

        public ListViewItem listItem()
        {
            string[] labels = {date.ToString("dd.MM.yyyy"),
                even, comment};
            return new ListViewItem(labels);
        }
    }
}
