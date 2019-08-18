using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace My_Games
{
    public class Platform : CatItem
    {
        public string company;
        public int colR = -1;
        public int colG;
        public int colB;
        public List<int> mediums = new List<int>();

        public Platform() { }
        
        public Platform(int lastID)
        {
            ID = lastID;
            Data.RandomColor(ref colR, ref colG, ref colB);
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

        public static void FillCombobox(ComboBox box, int id)
        {
            box.BeginUpdate();
            box.Items.Clear();
            box.Items.Add("");
            foreach (Platform p in Data.data.platforms)
                box.Items.Add(p.name);
            box.Text = Data.PlatformIDToName(id);
            box.EndUpdate();
        }

        public Color color()
        {
            return Color.FromArgb(colR, colG, colB);
        }
    }
}
