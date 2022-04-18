using System;
using System.Windows.Forms;

namespace My_Games
{
    public class Genre : CatItem
    {
        public Genre() { }

        public Genre(int lastID)
        {
            ID = lastID;
        }
        
        public ListViewItem GetListViewItem()
        {
            string[] strings = { name };
            return new ListViewItem(strings) { Tag = this, BackColor = color };
        }

        public override int CompareTo(object obj)
        {
            return String.Compare(name, ((Genre)obj).name);
        }

        public static void FillCombobox(ComboBox box, int id)
        {
            box.BeginUpdate();
            box.Items.Clear();
            box.Items.Add("");
            foreach (Genre g in Data.data.genres)
                box.Items.Add(g.name);
            box.Text = Data.GenreIDToName(id);
            box.EndUpdate();
        }
    }
}
