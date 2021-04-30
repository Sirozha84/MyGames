using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace My_Games
{
    public class Platform : CatItem
    {
        public string company;
        public List<int> mediums = new List<int>();

        public Platform() { }
        
        public Platform(int lastID)
        {
            ID = lastID;
        }

        public ListViewItem GetListViewItem()
        {
            string[] strings = { name, company };
            return new ListViewItem(strings) { Tag = this, BackColor = color };
        }

        public override int CompareTo(object obj)
        {
            return String.Compare(name, ((Platform)obj).name);
        }

        /// <summary>
        /// Заполнение выпадающего списка платформ
        /// </summary>
        /// <param name="box">Ссылка на "комбобокс"</param>
        /// <param name="id">Идентификатор платформы (для автоматического выбора), 0 - если не надо выбирать</param>
        /// <param name="all">Показывать все платформы?</param>
        /// <param name="versions">Список версии, по которому делать фильтр</param>
        public static void FillCombobox(ComboBox box, int id, CheckBox all, List<Version> versions)
        {
            box.BeginUpdate();
            box.Items.Clear();
            if (all.Checked) box.Items.Add("");
            foreach (Platform p in Data.data.platforms)
                if (all.Checked)
                    box.Items.Add(p.name);
                else
                    foreach (Version ver in versions)
                        if (p.ID == ver.platform)
                        {
                            box.Items.Add(p.name);
                            break;
                        }
            box.Text = Data.PlatformIDToName(id);
            if (box.Text != Data.PlatformIDToName(id)) all.Checked = true;
            if (box.Items.Count == 1) box.SelectedIndex = 0;
            box.EndUpdate();
        }
    }
}
