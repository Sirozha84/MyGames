using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Games
{
    public partial class FormStatistic : Form
    {
        Bitmap bmp;
        Graphics graph;
        DateTime last;
        int[,] platforms;
        int plCount, yearCount, scrollVal, yearsInColumn; //Количество платыорм, лет, скролл, лет в колонке
        int[,] mounts, years, all; //Таблицы с данными
        //int mK, yK, aK; //Коэффициенты уменьшения таблиц (для правильной отрисовки)
        int heightMounts, heightYears, heightAll; //Максимальные высоты
        string[] mount = { "Янв.", "Фев.", "Март", "Апр.", "Май", "Июнь", "Июль", "Авг.", "Сен.", "Окт.", "Ноя.", "Дек." };

        SolidBrush[] plBrushes;

        /// <summary>
        /// Игр куплено
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonGames_Click(object sender, EventArgs e)
        {
            //Сканируем базу и узнаём крайние даты (минимум и максимум)
            DateTime old = DateTime.Now;
            foreach (Game g in Data.data.games)
                foreach (Version v in g.versions)
                    if (old > v.date) old = v.date;
            last = old;
            foreach (Game g in Data.data.games)
                foreach (Version v in g.versions)
                    if (last < v.date) last = v.date;
            //Считаем количество лет
            yearCount = last.Year - old.Year + 1;
            if (yearCount < 10) yearCount = 10;
            yearsInColumn = yearCount / 10 + ((yearCount % 10) > 0 ? 1 : 0); //Типа сколько лет показывает колонка когда показываем всё сразу
            
            //Создадим табличку с рейтингом по платформам
            plCount = Data.data.platforms.Count;
            platforms = new int[plCount, 2];
            foreach (Game g in Data.data.games)
                foreach (Version v in g.versions)
                {
                    for (int i = 0; i < plCount; i++)
                    {
                        if (platforms[i, 0] == 0) platforms[i, 0] = v.platform;
                        if (platforms[i, 0] == v.platform)
                        {
                            platforms[i, 1]++;
                            i = plCount;
                        }
                    }
                }
            DrawPlatformList();

            //Создаём массивы данных
            mounts = new int[yearCount * 12, plCount];
            years = new int[yearCount, plCount];
            all = new int[10, plCount];
            //И заполняем их
            foreach (Game g in Data.data.games)
                foreach (Version v in g.versions)
                {
                    int p = 0;
                    for (int i = 0; i < plCount; i++)
                        if (platforms[i, 0] == v.platform)
                        {
                            p = i;
                            break;
                        }                   
                    years[last.Year - v.date.Year, p]++;
                    mounts[last.Year * 12 - v.date.Year * 12 + 12 - v.date.Month, p]++;
                    all[(last.Year - v.date.Year) / yearsInColumn, p]++;
                }

            FindMaximumHeight();
            ScrollCalc();
            DrawGraph();
        }

        /// <summary>
        /// Денег потрачено
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonMoney_CheckedChanged(object sender, EventArgs e)
        {
            //Сканируем базу и узнаём крайние даты (минимум и максимум)
            DateTime old = DateTime.Now;
            foreach (Game g in Data.data.games)
            {
                foreach (Version v in g.versions) if (old > v.date) old = v.date;
                foreach (DLC d in g.DLCs) if (old > d.date) old = d.date;
            }
            last = old;
            foreach (Game g in Data.data.games)
            {
                foreach (Version v in g.versions) if (last < v.date) last = v.date;
                foreach (DLC d in g.DLCs) if (last < d.date) last = d.date;
            }
            //Считаем количество лет
            yearCount = last.Year - old.Year + 1;
            if (yearCount < 10) yearCount = 10;
            yearsInColumn = yearCount / 10 + ((yearCount % 10) > 0 ? 1 : 0); //Типа сколько лет показывает колонка когда показываем всё сразу

            //Создадим табличку с рейтингом по платформам
            plCount = Data.data.platforms.Count;
            platforms = new int[plCount, 2];
            foreach (Game g in Data.data.games)
            {
                foreach (Version v in g.versions)
                {
                    for (int i = 0; i < plCount; i++)
                    {
                        if (platforms[i, 0] == 0) platforms[i, 0] = v.platform;
                        if (platforms[i, 0] == v.platform)
                        {
                            platforms[i, 1] += v.price;
                            i = plCount;
                        }
                    }
                }
                foreach (DLC d in g.DLCs)
                {
                    for (int i = 0; i < plCount; i++)
                    {
                        if (platforms[i, 0] == 0) platforms[i, 0] = d.platform;
                        if (platforms[i, 0] == d.platform)
                        {
                            platforms[i, 1] += d.price;
                            i = plCount;
                        }
                    }
                }
            }
            DrawPlatformList();

            //Создаём массивы данных
            mounts = new int[yearCount * 12, plCount];
            years = new int[yearCount, plCount];
            all = new int[10, plCount];
            //И заполняем их
            foreach (Game g in Data.data.games)
            {
                foreach (Version v in g.versions)
                {
                    int p = 0;
                    for (int i = 0; i < plCount; i++)
                        if (platforms[i, 0] == v.platform)
                        {
                            p = i;
                            break;
                        }
                    years[last.Year - v.date.Year, p] += v.price;
                    mounts[last.Year * 12 - v.date.Year * 12 + 12 - v.date.Month, p] += v.price;
                    all[(last.Year - v.date.Year) / yearsInColumn, p] += v.price;
                }
                foreach (DLC d in g.DLCs)
                {
                    int p = 0;
                    for (int i = 0; i < plCount; i++)
                        if (platforms[i, 0] == d.platform)
                        {
                            p = i;
                            break;
                        }
                    years[last.Year - d.date.Year, p] += d.price;
                    mounts[last.Year * 12 - d.date.Year * 12 + 12 - d.date.Month, p] += d.price;
                    all[(last.Year - d.date.Year) / yearsInColumn, p] += d.price;
                }
            }
            FindMaximumHeight();
            ScrollCalc();
            DrawGraph();
        }

        /// <summary>
        /// Время наиграно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonTime_CheckedChanged(object sender, EventArgs e)
        {
            //Сканируем базу и узнаём крайние даты (минимум и максимум)
            DateTime old = DateTime.Now;
            foreach (Game g in Data.data.games)
                foreach (Event ev in g.history)
                    if (old > ev.date) old = ev.date;
            last = old;
            foreach (Game g in Data.data.games)
                foreach (Event ev in g.history)
                    if (last < ev.date) last = ev.date;
            //Считаем количество лет
            yearCount = last.Year - old.Year + 1;
            if (yearCount < 10) yearCount = 10;
            yearsInColumn = yearCount / 10 + ((yearCount % 10) > 0 ? 1 : 0); //Типа сколько лет показывает колонка когда показываем всё сразу

            //Создадим табличку с рейтингом по платформам
            plCount = Data.data.platforms.Count;
            platforms = new int[plCount, 2];
            foreach (Game g in Data.data.games)
                foreach (Event ev in g.history)
                {
                    for (int i = 0; i < plCount; i++)
                    {
                        if (platforms[i, 0] == 0) platforms[i, 0] = ev.platform;
                        if (platforms[i, 0] == ev.platform)
                        {
                            platforms[i, 1] += ev.hours;
                            i = plCount;
                        }
                    }
                }
            DrawPlatformList();

            //Создаём массивы данных
            mounts = new int[yearCount * 12, plCount];
            years = new int[yearCount, plCount];
            all = new int[10, plCount];
            //И заполняем их
            foreach (Game g in Data.data.games)
                foreach (Event ev in g.history)
                {
                    int p = 0;
                    for (int i = 0; i < plCount; i++)
                        if (platforms[i, 0] == ev.platform)
                        {
                            p = i;
                            break;
                        }
                    years[last.Year - ev.date.Year, p] += ev.hours;
                    mounts[last.Year * 12 - ev.date.Year * 12 + 12 - ev.date.Month, p] += ev.hours;
                    all[(last.Year - ev.date.Year) / yearsInColumn, p] += ev.hours;
                }

            FindMaximumHeight();
            ScrollCalc();
            DrawGraph();
        }

        private void RadioButtonMounts_CheckedChanged(object sender, EventArgs e) { ScrollCalc(); DrawGraph(); }
        private void RadioButtonYears_CheckedChanged(object sender, EventArgs e) { ScrollCalc(); DrawGraph(); }
        private void RadioButtonEverytime_CheckedChanged(object sender, EventArgs e) { ScrollCalc(); DrawGraph(); }

        private void ScrollBar_ValueChanged(object sender, EventArgs e)
        {
            scrollVal = 0;
            if (radioButtonMounts.Checked) scrollVal = scrollBar.Maximum - scrollBar.Value - 11;
            if (radioButtonYears.Checked) scrollVal = scrollBar.Maximum - scrollBar.Value - 9;
            DrawGraph();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e) { DrawGraph(); }

        /// <summary>
        /// Сортировка списка платформ и вывод его на форму
        /// </summary>
        void DrawPlatformList()
        {
            for (int i = 0; i < plCount - 1; i++)
            {
                for (int j = i + 1; j < plCount; j++)
                    if (platforms[i, 1] < platforms[j, 1])
                    {
                        int t0 = platforms[i, 0];
                        int t1 = platforms[i, 1];
                        platforms[i, 0] = platforms[j, 0];
                        platforms[i, 1] = platforms[j, 1];
                        platforms[j, 0] = t0;
                        platforms[j, 1] = t1;
                    }
            }
            listView.BeginUpdate();
            listView.Items.Clear();
            plBrushes = new SolidBrush[plCount];
            for (int i = 0; i < plCount; i++)
            {
                string s = Data.PlatformIDToName(platforms[i, 0]);
                if (s != "" && platforms[i, 1] != 0)
                {
                    ListViewItem item = new ListViewItem(s);
                    item.SubItems.Add(platforms[i, 1].ToString("### ### ### ### ###"));
                    item.BackColor = Data.data.platforms.Find(o => o.name == s).color;
                    plBrushes[i] = new SolidBrush(item.BackColor);
                    listView.Items.Add(item);
                }
                else
                    plBrushes[i] = new SolidBrush(Color.Black);
            }
            listView.EndUpdate();
        }

        /// <summary>
        /// Поиск максимальных высот столбиков
        /// </summary>
        void FindMaximumHeight()
        {
            heightMounts = 0;
            for (int i = 0; i < yearCount * 12; i++)
            {
                int height = 0;
                for (int j = 0; j < plCount; j++)
                    height += mounts[i, j];
                if (heightMounts < height) heightMounts = height;
            }
            heightYears = 0;
            for (int i = 0; i < yearCount; i++)
            {
                int height = 0;
                for (int j = 0; j < plCount; j++)
                    height += years[i, j];
                if (heightYears < height) heightYears = height;
            }
            heightAll = 0;
            for (int i = 0; i < 10; i++)
            {
                int height = 0;
                for (int j = 0; j < plCount; j++)
                    height += all[i, j];
                if (heightAll < height) heightAll = height;
            }
        }

        /// <summary>
        /// Инициализация скролл-бара
        /// </summary>
        void ScrollCalc()
        {
            if (radioButtonMounts.Checked)
            {
                scrollBar.Maximum = yearCount * 12 - 1;
                scrollBar.Value = scrollBar.Maximum - 11;
                scrollBar.LargeChange = 12;
                scrollBar.Enabled = true;
            }
            if (radioButtonYears.Checked)
            {
                scrollBar.Maximum = yearCount - 1;
                scrollBar.Value = scrollBar.Maximum - 9;
                scrollBar.LargeChange = 10;
                scrollBar.Enabled = true;
            }
            if (radioButtonEverytime.Checked)
            {
                scrollBar.Maximum = 0;
                scrollBar.Enabled = false;
            }
            ScrollBar_ValueChanged(null, null);
        }

        public FormStatistic()
        {
            InitializeComponent();
            graph = pictureBox.CreateGraphics();
            //Временно раставлю цвета так, потом хочу сделать настройку цвета каждой платформы
            RadioButtonGames_Click(null, null);
        }

        void DrawGraph()
        {
            int fullWidth, fullHeight;
            fullWidth = pictureBox.Width;
            fullHeight = pictureBox.Height;
            bmp = new Bitmap(fullWidth, fullHeight);
            graph = Graphics.FromImage(bmp);

            int left = 60;
            int bottom = 40;
            int width = fullWidth - left;
            int width10 = width / 10;
            int width12 = width / 12;
            int space = width / 50;
            int width10s = width / 10 - space * 2;
            int width12s = width / 12 - space * 2;
            int height = fullHeight - bottom;

            Font title = new Font(new FontFamily("Arial"), 12, FontStyle.Regular, GraphicsUnit.Pixel);
            //SolidBrush titleB = new SolidBrush(Color.Black);
            StringFormat formatR = new StringFormat();
            formatR.Alignment = StringAlignment.Far;
            formatR.LineAlignment = StringAlignment.Center;
            StringFormat formatC = new StringFormat();
            formatC.Alignment = StringAlignment.Center;
            formatC.LineAlignment = StringAlignment.Center;

            graph.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            try
            {
                if (radioButtonMounts.Checked)
                {
                    int g = calcG(heightMounts);
                    int k = height / (heightMounts / g);
                    for (int i = 0; i <= heightMounts; i += heightMounts / 4 / g)
                    {
                        graph.DrawLine(Pens.Gray, left, height - i * k, fullWidth - 5, height - i * k);
                        graph.DrawString((i * g).ToString(), title, Brushes.Black, new Rectangle(0, height - i * k - 10, left - 10, 20), formatR);
                    }
                    for (int i = 0; i < 12; i++)
                    {
                        int c = scrollVal + 11 - i;
                        int s = 0;
                        for (int j = 0; j < plCount; j++)
                        {
                            graph.FillRectangle(plBrushes[j], left + space + width12 * i, height - (s + mounts[c, j]) / g * k, width12s, mounts[c, j] / g * k);
                            s += mounts[c, j] / g;
                        }
                        s = 0;
                        if (listView.SelectedItems.Count > 0)
                            for (int j = 0; j < plCount; j++)
                            {
                                if (j == listView.SelectedItems[0].Index && mounts[c, j] != 0)
                                    graph.DrawRectangle(Pens.Black, left + space + width12 * i - 3, height - (s + mounts[c, j] / g) * k - 3, width12s + 5, mounts[c, j] / g * k + 5);
                                s += mounts[c, j] / g;
                            }
                            
                        if (i == 0 | c % 12 == 11)
                        graph.DrawString((last.Year - c / 12).ToString(),title, Brushes.Black, new Rectangle(left + width12 * i, height, width12, bottom / 2), formatC);
                        graph.DrawString(mount[11 - c % 12], title, Brushes.Black, new Rectangle(left + width12 * i, height + bottom / 2, width12, bottom / 2), formatC);
                    }
                }
                if (radioButtonYears.Checked)
                {
                    int g = calcG(heightYears);
                    int k = height / (heightYears / g);
                    for (int i = 0; i <= heightYears; i += heightYears / 4 / g)
                    {
                        graph.DrawLine(Pens.Gray, left, height - i * k, fullWidth, height - i * k);
                        graph.DrawString((i * g).ToString(), title, Brushes.Black, new Rectangle(0, height - i * k - 10, left - 10, 20), formatR);
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        int c = scrollVal + 9 - i;
                        int s = 0;
                        for (int j = 0; j < plCount; j++)
                        {
                            graph.FillRectangle(plBrushes[j], left + space + width10 * i, height - (s + years[c, j] / g) * k, width10s, years[c, j] / g * k);
                            s += years[c, j] / g;
                        }
                        s = 0;
                        if (listView.SelectedItems.Count > 0)
                            for (int j = 0; j < plCount; j++)
                            {
                                if (j == listView.SelectedItems[0].Index && years[c, j] != 0)
                                    graph.DrawRectangle(Pens.Black, left + space + width10 * i - 3, height - (s + years[c, j] / g) * k - 3, width10s + 5, years[c, j] / g * k + 5);
                                s += years[c, j] / g;
                            }
                        graph.DrawString((last.Year - c).ToString(), title, Brushes.Black, new Rectangle(left + width10 * i, height, width10, bottom), formatC);
                    }
                }
                if (radioButtonEverytime.Checked)
                {
                    int g = calcG(heightAll);
                    int k = height / (heightAll / g);
                    for (int i = 0; i <= heightAll; i += heightAll / 4 / g)
                    {
                        graph.DrawLine(Pens.Gray, left, height - i * k, fullWidth, height - i * k);
                        graph.DrawString((i * g).ToString(), title, Brushes.Black, new Rectangle(0, height - i * k - 10, left - 10, 20), formatR);
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        int c = 9 - i;
                        int s = 0;
                        for (int j = 0; j < plCount; j++)
                        {
                            graph.FillRectangle(plBrushes[j], left + space + width10 * i, height - (s + all[c, j] / g) * k, width10s, all[c, j] / g * k);
                            s += all[c, j] / g;
                        }
                        s = 0;
                        if (listView.SelectedItems.Count > 0)
                            for (int j = 0; j < plCount; j++)
                            {
                                if (j == listView.SelectedItems[0].Index && all[c, j] != 0)
                                    graph.DrawRectangle(Pens.Black, left + space + width10 * i - 3, height - (s + all[c, j] / g) * k - 3, width10s + 5, all[c, j] / g * k + 5);
                                s += all[c, j] / g;
                            }

                        graph.DrawString((last.Year - c * yearsInColumn - yearsInColumn + 1).ToString(), title, Brushes.Black, new Rectangle(left + width10 * i, height, width10, bottom / 2), formatC);
                        graph.DrawString((last.Year - c * yearsInColumn).ToString(), title, Brushes.Black, new Rectangle(left + width10 * i, height + bottom / 2, width10, bottom / 2), formatC);
                    }
                }
            }
            catch { }

            pictureBox.Image = bmp;
        }

        /// <summary>
        /// Значение размера градации
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        int calcG(int height)
        {
            if (height < 100) return 1;
            if (height < 1000) return 5;
            if (height < 10000) return 50;
            if (height < 100000) return 500;
            return 5000;
        }

        private void FormStatistic_Paint(object sender, PaintEventArgs e) { DrawGraph(); }
    }
}
