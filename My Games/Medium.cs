using System;
using System.Windows.Forms;

namespace My_Games
{
    public class Medium : CatItem
    {
        public bool phisic;

        public Medium() { }

        public Medium(int lastID)
        {
            ID = lastID;
        }

        public ListViewItem GetListViewItem()
        {
            string[] strings = { name, phisic ? "Да" : "" };
            return new ListViewItem(strings) { Tag = this };
        }

        public override int CompareTo(object obj)
        {
            return String.Compare(name, ((Medium)obj).name);
        }

        public static void FillCombobox(ComboBox box, int id)
        {
            box.BeginUpdate();
            box.Items.Clear();
            box.Items.Add("");
            foreach (Medium p in Data.data.mediums)
                box.Items.Add(p.name);
            box.Text = Data.MediumIDToName(id);
            box.EndUpdate();
        }
    }
}
