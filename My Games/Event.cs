﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace My_Games
{
    public class Event
    {
        public static string[] events = { "Не запускалась", "Начата", "Половина",
                                          "Большая часть", "Пройдена", "На \"100%\"", "Бесконечная" };

        public DateTime date;
        public int platform;
        public int even;
        public int hours;
        public int hoursAll;
        public string comment;

        public Event()
        {
            date = DateTime.Now;
            even = 4;               //Действие по умолчанию сделаем "Пройдена"
        }

        public Event(Event ev)
        {
            date = ev.date;
            platform = ev.platform;
            even = ev.even;
            hours = ev.hours;
            hoursAll = ev.hoursAll;
            comment = ev.comment;
        }

        public ListViewItem listItem()
        {
            string[] labels = {date.ToString("dd.MM.yyyy"),
                Data.PlatformIDToName(platform), events[even], hoursAll.ToString(Program.num), hours.ToString(Program.num), comment};
            return new ListViewItem(labels) { Tag = this };
        }
    }

    class EventDateComparer : IComparer<Event>
    {
        public int Compare(Event o1, Event o2)
        {
            return o1.date > o2.date ? 1 : -1;
        }
    }
}
