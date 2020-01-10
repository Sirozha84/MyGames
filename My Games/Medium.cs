using System;
using System.Windows.Forms;

namespace My_Games
{
    public class Medium : CatItem
    {
        
        /// <summary>
        /// Тип носителя: 0 - Физический, 1 - Электронный, 2 - Подписка
        /// </summary>
        public byte mediumType;

        public Medium() { }

        public Medium(int lastID)
        {
            ID = lastID;
        }

        public ListViewItem GetListViewItem()
        {
            string mt = "Физический носитель";
            if (mediumType == 2) mt = "Электронный магазин";
            if (mediumType == 3) mt = "Игра по подписке";
            string[] strings = { name, mt };
            return new ListViewItem(strings) { Tag = this };
        }

        public override int CompareTo(object obj)
        {
            return String.Compare(name, ((Medium)obj).name);
        }

        /// <summary>
        /// Заполнение выпадающего списка носителей
        /// </summary>
        /// <param name="box">"Комбобокс</param>
        /// <param name="id">Выбранный носитель</param>
        /// <param name="forPlatform">Платформа, для которой список будет подбираться индивидуально.
        /// Для вывода полного списка вводить ""</param>
        public static void FillCombobox(ComboBox box, int id, string forPlatform)
        {
            box.BeginUpdate();
            box.Items.Clear();
            box.Items.Add("");
            Platform pl = Data.data.platforms.Find(o => o.name == forPlatform);
            if (forPlatform == "" | pl == null | (pl != null && pl.mediums.Count == 0))
                foreach (Medium p in Data.data.mediums)
                    box.Items.Add(p.name);
            else
                foreach (int m in pl.mediums)
                    box.Items.Add(Data.MediumIDToName(m));
            box.Text = Data.MediumIDToName(id);
            if (box.Items.Count == 2)
            {
                box.Items.RemoveAt(0);
                box.SelectedIndex = 0;
            }
            box.EndUpdate();
        }
    }
}
