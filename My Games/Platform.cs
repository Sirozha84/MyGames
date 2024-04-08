using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace My_Games
{
    public class Platform : CatItem
    {
        public static string[] types = { "Игровая", "Видео" };

        public string company;
        public int type;
        public List<int> mediums = new List<int>();

        public Platform() { }
        
        public Platform(int lastID)
        {
            ID = lastID;
        }

        public ListViewItem GetListViewItem()
        {
            string[] strings = { name, company, types[type] };
            return new ListViewItem(strings) { Tag = this, BackColor = color };
        }

        public override int CompareTo(object obj)
        {
            return String.Compare(name, ((Platform)obj).name);
        }

        public static void FillCombobox(ComboBox box, int id, bool all, List<Version> versions)
        {
            FillCombobox(box, 0, id, all, versions);
        }
        /// <summary>
        /// Заполнение выпадающего списка платформ
        /// </summary>
        /// <param name="box">Ссылка на "комбобокс"</param>
        /// <param name="method">Метод прохождения</param>
        /// <param name="id">Идентификатор платформы (для автоматического выбора), 0 - если не надо выбирать</param>
        /// <param name="all">Показывать все платформы?</param>
        /// <param name="versions">Список версии, по которому делать фильтр</param>
        public static void FillCombobox(ComboBox box, int method, int id, bool all, List<Version> versions)
        {
            box.BeginUpdate();
            box.Items.Clear();
            if (method < 2)
            {
                if (all) box.Items.Add("");
                foreach (Platform p in Data.data.platforms)
                    if (all)
                    {
                        if (p.type == 0)
                            box.Items.Add(p.name);
                    }
                    else
                        foreach (Version ver in versions)
                            if (p.ID == ver.platform)
                            {
                                box.Items.Add(p.name);
                                break;
                            }
            }
            if (method == 2)
            {
                foreach (Platform p in Data.data.platforms)
                    if (p.type == 1)
                        box.Items.Add(p.name);
            }
            box.Text = Data.PlatformIDToName(id);
            if (box.Items.Count == 1) box.SelectedIndex = 0;
            box.EndUpdate();
        }
    }
}
