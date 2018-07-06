using System;
using System.Windows.Forms;

namespace My_Game_Collection
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
            string[] strings = { name, phisic ? "Физический" : "" };
            return new ListViewItem(strings);
        }

        public override int CompareTo(object obj)
        {
            return String.Compare(name, ((Medium)obj).name);
        }

        public static void FillCombobox(ref ComboBox box, int id)
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
