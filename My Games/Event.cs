using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace My_Games
{
    public class Event
    {
        public static string[] events = { "Не запускалась", "Начата", "Половина",
                                          "Большая часть", "Пройдена", "На \"100%\"", "Бесконечная" };
        public static string[] methods = { "Честно", "С читами", "Просмотр" };

        public DateTime date;
        public int platform;
        public int even;
        public int method;
        public int hours;
        public int hoursAll;
        public string comment;

        public Event() { }    
        public Event(List<Event> history)
        {
            date = DateTime.Now;
            even = 4;               //Действие по умолчанию сделаем "Пройдена"
            foreach (Event ev in history)
                if (even < ev.even) even = ev.even; //Но, если в истории было действие старше - выбираем его
        }

        public Event(Event ev)
        {
            date = ev.date;
            platform = ev.platform;
            even = ev.even;
            method = ev.method;
            hours = ev.hours;
            hoursAll = ev.hoursAll;
            comment = ev.comment;
        }

        public ListViewItem listItem()
        {
            string[] labels = {date.ToString("dd.MM.yyyy"), Data.PlatformIDToName(platform), events[even],
                methods[method], hoursAll.ToString(Program.num), hours.ToString(Program.num), comment};
            return new ListViewItem(labels) { Tag = this };
        }
    }
}
