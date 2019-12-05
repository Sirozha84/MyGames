using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace My_Games
{
    public class Note
    {
        public DateTime date;
        public string name = "";
        public string note = "";

        public Note()
        {
            date = DateTime.Now;
        }

        public Note(Note n)
        {
            date = n.date;
            name = n.name;
            note = n.note;
        }

        public ListViewItem listItem()
        {
            string[] labels = { date.ToString("dd.MM.yyyy"), name };
            return new ListViewItem(labels) { Tag = this };
        }
    }
}
