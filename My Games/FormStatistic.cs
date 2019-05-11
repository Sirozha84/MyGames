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
        Graphics graph, graphl;
        Bitmap bmp, bmpl;
        int fullWidth, fullHeight, lWidth, lHeight;
        Brush[] plBrushes;

        DateTime last;
        int plCount, yearCount, scrollVal, yearsInColumn;
        int[,] mounts, years, all;
        int heightMounts, heightYears, heightAll;

        string[] mount = { "Янв.", "Фев.", "Март", "Апр.", "Май", "Июнь", "Июль", "Авг.", "Сен.", "Окт.", "Ноя.", "Дек." };

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
            int[,] platforms = new int[plCount, 2];
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
            //Сортируем её
            for (int i = 0; i < plCount - 1; i++)
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
            int[,] platforms = new int[plCount, 2];
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
            //Сортируем её
            for (int i = 0; i < plCount - 1; i++)
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
            int[,] platforms = new int[plCount, 2];
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
            //Сортируем её
            for (int i = 0; i < plCount - 1; i++)
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
            //Text = scrollVal.ToString();
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
            plBrushes = new Brush[]{ Brushes.Red, Brushes.Green, Brushes.Blue,
                                     Brushes.Pink, Brushes.LightBlue, Brushes.LightGreen,
                                     Brushes.IndianRed, Brushes.RoyalBlue, Brushes.YellowGreen };
        }

        void DrawGraph()
        {
            fullWidth = pictureBox.Width;
            fullHeight = pictureBox.Height;
            bmp = new Bitmap(fullWidth, fullHeight);
            graph = Graphics.FromImage(bmp);

            int left = 100;
            int bottom = 36;
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
                    int k = height / heightMounts;
                    for (int i = 0; i < heightMounts; i += heightMounts / 4)
                    {
                        graph.DrawLine(Pens.Gray, left, height - i * k, fullWidth - 5, height - i * k);
                        graph.DrawString(i.ToString(), title, Brushes.Black, new Rectangle(0, height - i * k - 10, left - 10, 20), formatR);
                    }
                    for (int i = 0; i < 12; i++)
                    {
                        int c = scrollVal + 11 - i;
                        int s = 0;
                        for (int j = 0; j < plCount; j++)
                        {
                            graph.FillRectangle(plBrushes[j % plBrushes.Count()], left + space + width12 * i, height - (s + mounts[c, j]) * k, width12s, mounts[c, j] * k);
                            s += mounts[c, j];
                        }
                        if (i == 0 | c % 12 == 11)
                        graph.DrawString((last.Year - c / 12).ToString(),title, Brushes.Black, new Rectangle(left + width12 * i, height, width12, bottom / 2), formatC);
                        graph.DrawString(mount[11 - c % 12], title, Brushes.Black, new Rectangle(left + width12 * i, height + bottom / 2, width12, bottom / 2), formatC);
                    }
                }
                if (radioButtonYears.Checked)
                {
                    int k = height / heightYears;
                    for (int i = 0; i < heightYears; i += heightYears / 4)
                    {
                        graph.DrawLine(Pens.Gray, left, (int)(height - i * k), fullWidth, height - i * k);
                        graph.DrawString(i.ToString(), title, Brushes.Black, new Rectangle(0, height - i * k - 10, left - 10, 20), formatR);
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        int c = scrollVal + 9 - i;
                        int s = 0;
                        for (int j = 0; j < plCount; j++)
                        {
                            graph.FillRectangle(plBrushes[j % plBrushes.Count()], left + space + width10 * i, height - (s + years[c, j]) * k, width10s, years[c, j] * k);
                            s += years[c, j];
                        }
                        graph.DrawString((last.Year - c).ToString(), title, Brushes.Black, new Rectangle(left + width10 * i, height, width10, bottom), formatC);
                    }
                }
                if (radioButtonEverytime.Checked)
                {
                    int k = height / heightAll;
                    for (int i = 0; i < heightAll; i += heightAll / 4)
                    {
                        graph.DrawLine(Pens.Gray, left, height - i * k, fullWidth, height - i * k);
                        graph.DrawString(i.ToString(), title, Brushes.Black, new Rectangle(0, height - i * k - 10, left - 10, 20), formatR);
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        int c = 9 - i;
                        int s = 0;
                        for (int j = 0; j < plCount; j++)
                        {
                            graph.FillRectangle(plBrushes[j % plBrushes.Count()], left + space + width10 * i, height - (s + all[c, j]) * k, width10s, all[c, j] * k);
                            s += all[c, j];
                        }
                        graph.DrawString((last.Year - c * yearsInColumn - yearsInColumn + 1).ToString(), title, Brushes.Black, new Rectangle(left + width10 * i, height, width10, bottom / 2), formatC);
                        graph.DrawString((last.Year - c * yearsInColumn).ToString(), title, Brushes.Black, new Rectangle(left + width10 * i, height + bottom / 2, width10, bottom / 2), formatC);
                    }
                }
            }
            catch { }

            pictureBox.Image = bmp;
        }


        private void FormStatistic_Paint(object sender, PaintEventArgs e) { DrawGraph(); }
    }
}
