using System;
using System.Windows.Forms;

namespace My_Game_Collection
{
    public class Platform : IComparable
    {
        public string name;
        public string company;

        public ListViewItem GetListViewItem()
        {
            string[] strings = { name, company };
            return new ListViewItem(strings) { Tag = this };
        }

        public int CompareTo(object obj)
        {
            return String.Compare(name, ((Platform)obj).name);
        }
    }
}
