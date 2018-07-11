using System;
using System.Windows.Forms;

namespace My_Games
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

        public static void FillCombobox(ref ComboBox box, int id)
        {
            box.BeginUpdate();
            box.Items.Clear();
            box.Items.Add("");
            foreach (Platform p in Data.data.platforms)
                box.Items.Add(p.name);
            box.Text = Data.PlatformIDToName(id);
            box.EndUpdate();
        }
    }
}
