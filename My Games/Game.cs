using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace My_Games
{
    public class Game
    {
        public static string[] stars = { "*", "* *", "* * *", "* * * *", "* * * * *" };

        //Данные игры
        public int ID;
        public string name;
        public string developer;
        public string publisher;
        public string year;
        public int genre;
        public int rate = 3;
        public string cover;
        public string website;
        public string scrFolder;
        public string comment;
        public List<Version> versions = new List<Version>();
        public List<DLC> DLCs = new List<DLC>();
        public List<Event> history = new List<Event>();
        public List<Note> notes = new List<Note>();
        public bool hidden;

        //Итоговые данные для быстрого доступа
        public DateTime date = DateTime.Now;
        public int win;
        public int hours;
        public int price;

        //Данные документа, не относящиеся к игре
        public DateTime create = DateTime.Now;
        public DateTime change = DateTime.Now;

        /// <summary>
        /// Получает элемент списка раскрашенный в заданном режиме
        /// </summary>
        public ListViewItem listItem()
        {
            string[] labels = {date.ToString("dd.MM.yyyy"), name, Data.GenreIDToName(genre), stars[rate - 1],
                Event.events[win], hours.ToString(Program.num), versions.Count().ToString(Program.num), price.ToString(Program.num)};
            ListViewItem item = new ListViewItem(labels);
            item.Tag = this;
            if (Settings.colorMode == 1)
                item.BackColor = Color.FromArgb(Data.data.winColR[win], Data.data.winColG[win], Data.data.winColB[win]);
            if (hidden) item.ForeColor = Color.Gray;
            return item;
        }

        /// <summary>
        /// Фиксация данных для быстрого доступа. Что-то типа проведения документа.
        /// </summary>
        public void Hold()
        {
            //Дата
            date = DateTime.MinValue;
            foreach (Version v in versions) if (date < v.date) date = v.date;
            foreach (DLC d in DLCs) if (date < d.date) date = d.date;
            foreach (Event e in history) if (date < e.date) date = e.date;
            foreach (Note n in notes) if (date < n.date) date = n.date;

            //Цена
            price = 0;
            foreach (Version v in versions)
                price += v.price;
            foreach (DLC d in DLCs)
                price += d.price;
            
            //Прохождение
            hours = 0;
            win = 0;
            foreach (Event ev in history)
            {
                hours += ev.hours;
                if (win < ev.even) win = ev.even;
            }

        }

        public void OpenScrFolder()
        {
            try
            {
                System.Diagnostics.Process.Start(scrFolder);
            }
            catch
            {
                MessageBox.Show("Указанный путь не существует:\n"+scrFolder);
            }
        }

    }
}
