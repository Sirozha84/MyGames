using System.Windows.Forms;

namespace My_Game_Collection
{
    public class Medium
    {
        public string name;
        public bool phisic;

        public ListViewItem GetListViewItem()
        {
            string[] strings = { name, phisic ? "Физический" : "" };
            return new ListViewItem(strings);
        }
    }
}
