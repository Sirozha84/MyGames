using System;
using System.Windows.Forms;

namespace My_Game_Collection
{
    public class Platform : CatItem
    {

        public string company;

        public Platform() { }

        public Platform(int lastID)
        {
            ID = lastID;
        }

        public ListViewItem GetListViewItem()
        {
            string[] strings = { name, company };
            return new ListViewItem(strings) { Tag = this };
        }

        public override int CompareTo(object obj)
        {
            return String.Compare(name, ((Platform)obj).name);
        }
    }
}
