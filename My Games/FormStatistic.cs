using System;
using System.Drawing;
using System.Windows.Forms;

namespace My_Games
{
    public partial class FormStatistic : Form
    {
        Bitmap bmp;
        Graphics graph;
        DateTime last;
        int[,] categories;
        int ctCount, yearCount, scrollVal, yearsInColumn; //Количество платформ, лет, скролл, лет в колонке
        int[,] mounts, years, all; //Таблицы с данными
        //int mK, yK, aK; //Коэффициенты уменьшения таблиц (для правильной отрисовки)
        int heightMounts, heightYears, heightAll; //Максимальные высоты
        string[] mount = { "Янв.", "Фев.", "Март", "Апр.", "Май", "Июнь", "Июль", "Авг.", "Сен.", "Окт.", "Ноя.", "Дек." };

        SolidBrush[] plBrushes;

        #region Выбор типа графика и подготовка данных
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
            ctCount = Data.data.platforms.Count;
            categories = new int[ctCount, 2];
            foreach (Game g in Data.data.games)
                foreach (Version v in g.versions)
                {
                    for (int i = 0; i < ctCount; i++)
                    {
                        if (categories[i, 0] == 0) categories[i, 0] = v.platform;
                        if (categories[i, 0] == v.platform)
                        {
                            categories[i, 1]++;
                            i = ctCount;
                        }
                    }
                }
            DrawCatList();

            //Создаём массивы данных
            mounts = new int[yearCount * 12, ctCount];
            years = new int[yearCount, ctCount];
            all = new int[10, ctCount];
            //И заполняем их
            foreach (Game g in Data.data.games)
                foreach (Version v in g.versions)
                {
                    int p = 0;
                    for (int i = 0; i < ctCount; i++)
                        if (categories[i, 0] == v.platform)
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
            ctCount = Data.data.platforms.Count;
            categories = new int[ctCount, 2];
            foreach (Game g in Data.data.games)
            {
                foreach (Version v in g.versions)
                {
                    for (int i = 0; i < ctCount; i++)
                    {
                        if (categories[i, 0] == 0) categories[i, 0] = v.platform;
                        if (categories[i, 0] == v.platform)
                        {
                            categories[i, 1] += v.price;
                            i = ctCount;
                        }
                    }
                }
                foreach (DLC d in g.DLCs)
                {
                    for (int i = 0; i < ctCount; i++)
                    {
                        if (categories[i, 0] == 0) categories[i, 0] = d.platform;
                        if (categories[i, 0] == d.platform)
                        {
                            categories[i, 1] += d.price;
                            i = ctCount;
                        }
                    }
                }
            }
            DrawCatList();

            //Создаём массивы данных
            mounts = new int[yearCount * 12, ctCount];
            years = new int[yearCount, ctCount];
            all = new int[10, ctCount];
            
            //И заполняем их
            foreach (Game g in Data.data.games)
            {
                foreach (Version v in g.versions)
                {
                    int p = 0;
                    for (int i = 0; i < ctCount; i++)
                        if (categories[i, 0] == v.platform)
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
                    for (int i = 0; i < ctCount; i++)
                        if (categories[i, 0] == d.platform)
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
            ctCount = Data.data.platforms.Count;
            categories = new int[ctCount, 2];
            foreach (Game g in Data.data.games)
                foreach (Event ev in g.history)
                {
                    for (int i = 0; i < ctCount; i++)
                    {
                        if (categories[i, 0] == 0) categories[i, 0] = ev.platform;
                        if (categories[i, 0] == ev.platform)
                        {
                            categories[i, 1] += ev.hours;
                            i = ctCount;
                        }
                    }
                }
            DrawCatList();

            //Создаём массивы данных
            mounts = new int[yearCount * 12, ctCount];
            years = new int[yearCount, ctCount];
            all = new int[10, ctCount];
            
            //И заполняем их
            foreach (Game g in Data.data.games)
                foreach (Event ev in g.history)
                {
                    int p = 0;
                    for (int i = 0; i < ctCount; i++)
                        if (categories[i, 0] == ev.platform)
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

        /// <summary>
        /// Динамика прохождения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonCS_CheckedChanged(object sender, EventArgs e)
        {
            ctCount = 7;

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

            //Создаём массивы данных
            mounts = new int[yearCount * 12, ctCount];
            years = new int[yearCount, ctCount];
            all = new int[10, ctCount];
            //И заполняем их
            for (int i = 0; i < yearCount * 12; i++)
            {
                DateTime date = new DateTime(old.Year + i / 12, i % 12 + 1, 1);
                date = date.AddMonths(1);
                Console.WriteLine(date.ToString());
                foreach (Game game in Data.data.games)
                {
                    int max = 0;
                    if (game.versions.Find(o => o.date <= date) != null)
                    {
                        foreach (Event ev in game.history)
                            if (ev.date <= date && ev.even > max) max = ev.even;
                        mounts[yearCount * 12 - i - 1, max]++;
                    }
                }
            }
            for (int j = 0; j < ctCount; j++)
            {
                for (int i = 0; i < yearCount; i++)
                    years[i, j] = mounts[i * 12, j];
                for (int i = 0; i < 10; i++)
                    if (i * yearsInColumn < yearCount)
                        all[i, j] = mounts[i * 12 * yearsInColumn, j];
            }

            //Рисовка легенды
            listView.BeginUpdate();
            listView.Items.Clear();
            plBrushes = new SolidBrush[ctCount];
            for (int i = 0; i < ctCount; i++)
            {
                ListViewItem item = new ListViewItem(Event.events[i]);
                item.SubItems.Add(all[0, i].ToString(Program.num));
                item.BackColor = Color.FromArgb(Data.data.winColR[i], Data.data.winColG[i], Data.data.winColB[i]);
                plBrushes[i] = new SolidBrush(item.BackColor);
                listView.Items.Add(item);
            }
            listView.EndUpdate();


            //heightMounts = 500;
            //heightYears = 500;
            //heightAll = 500;

            FindMaximumHeight();
            ScrollCalc();
            DrawGraph();

        }

        #endregion

        #region Выбор масштаба
        private void RadioButtonMounts_CheckedChanged(object sender, EventArgs e) { ScrollCalc(); DrawGraph(); }
        private void RadioButtonYears_CheckedChanged(object sender, EventArgs e) { ScrollCalc(); DrawGraph(); }
        private void RadioButtonEverytime_CheckedChanged(object sender, EventArgs e) { ScrollCalc(); DrawGraph(); }

        #endregion

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
        void DrawCatList()
        {
            for (int i = 0; i < ctCount - 1; i++)
            {
                for (int j = i + 1; j < ctCount; j++)
                    if (categories[i, 1] < categories[j, 1])
                    {
                        int t0 = categories[i, 0];
                        int t1 = categories[i, 1];
                        categories[i, 0] = categories[j, 0];
                        categories[i, 1] = categories[j, 1];
                        categories[j, 0] = t0;
                        categories[j, 1] = t1;
                    }
            }
            listView.BeginUpdate();
            listView.Items.Clear();
            plBrushes = new SolidBrush[ctCount];
            for (int i = 0; i < ctCount; i++)
            {
                string s = Data.PlatformIDToName(categories[i, 0]);
                if (s != "" && categories[i, 1] != 0)
                {
                    ListViewItem item = new ListViewItem(s);
                    item.SubItems.Add(categories[i, 1].ToString(Program.num));
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
                for (int j = 0; j < ctCount; j++)
                    height += mounts[i, j];
                if (heightMounts < height) heightMounts = height;
            }
            heightYears = 0;
            for (int i = 0; i < yearCount; i++)
            {
                int height = 0;
                for (int j = 0; j < ctCount; j++)
                    height += years[i, j];
                if (heightYears < height) heightYears = height;
            }
            heightAll = 0;
            for (int i = 0; i < 10; i++)
            {
                int height = 0;
                for (int j = 0; j < ctCount; j++)
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
            int space = width / 50;
            int height = fullHeight - bottom;
            Font title = new Font(new FontFamily("Arial"), 12, FontStyle.Regular, GraphicsUnit.Pixel);
            StringFormat formatR = new StringFormat();
            formatR.Alignment = StringAlignment.Far;
            formatR.LineAlignment = StringAlignment.Center;
            StringFormat formatC = new StringFormat();
            formatC.Alignment = StringAlignment.Center;
            formatC.LineAlignment = StringAlignment.Center;
            graph.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            int[,] m = mounts;
            int scroll = 0;
            int columns = 0;
            int heightColumns = 0;
            if (radioButtonMounts.Checked) { m = mounts; scroll = scrollVal + 11; columns = 12; heightColumns = heightMounts; }
            if (radioButtonYears.Checked) { m = years; scroll = scrollVal + 9; columns = 10; heightColumns = heightYears; }
            if (radioButtonEverytime.Checked) { m = all; scroll = 9; columns = 10; heightColumns = heightAll; }
            int cWidth = width / columns;
            int cWidthS = width / columns - space * 2;

            //Горизонтальные полоски
            if (heightColumns == 0) { pictureBox.Image = bmp; return; }
            float k = (float)(height - 20) / heightColumns;
            int inc = heightColumns / 4;
            if (inc == 0) inc = 1;
            for (int i = 0; i <= heightColumns; i += inc)
            {
                graph.DrawLine(Pens.Gray, left, height - i * k, fullWidth - 5, height - i * k);
                graph.DrawString(i.ToString(Program.num), title, Brushes.Black, new Rectangle(0, (int)(height - i * k - 10), left - 10, 20), formatR);
            }

            //Рисование столбиков
            for (int i = 0; i < columns; i++)
            {
                int c = scroll - i;
                int s = 0;
                //Когданибудь я разбирусь почему индекс вылазит за пределы массива... но не сегодня
                //c - становится большим, когда пользователь переключает с месяцев на годы, :-\
                //То ли скролл не сбрасывается на более мелкий, то ли чё...
                //Text = c.ToString();
                try
                {
                    for (int j = 0; j < ctCount; j++)
                    {
                        graph.FillRectangle(plBrushes[j], left + space + cWidth * i, height - (s + m[c, j]) * k, cWidthS, m[c, j] * k);
                        s += m[c, j];
                    }
                    s = 0;
                    //Обводим столбик, если что-нибдуь в легенде выбрано
                    if (listView.SelectedItems.Count > 0)
                        for (int j = 0; j < ctCount; j++)
                        {
                            if (j == listView.SelectedItems[0].Index && m[c, j] != 0)
                            {
                                graph.DrawRectangle(Pens.Black, left + space + cWidth * i - 3, height - (s + m[c, j]) * k - 3, cWidthS + 5, m[c, j] * k + 5);
                                graph.DrawString(m[c, j].ToString(Program.num), title, Brushes.Black, new Rectangle(left + cWidth * i - 4, (int)(height - (s + m[c, j]) * k - 20), cWidth, 15), formatC);
                            }
                            s += m[c, j];
                        }
                    else
                    {
                        int sum = 0;
                        for (int j = 0; j < ctCount; j++)
                            sum += m[c, j];
                        graph.DrawString(sum.ToString(Program.num), title, Brushes.Black, new Rectangle(left + cWidth * i - 4, (int)(height - (s + sum) * k - 20), cWidth, 15), formatC);
                    }
                } catch { }
                
                //Подписи столбиков
                if (radioButtonMounts.Checked)
                {
                    if (i == 0 | c % 12 == 11)
                        graph.DrawString((last.Year - c / 12).ToString(), title, Brushes.Black, new Rectangle(left + cWidth * i, height, cWidth, bottom / 2), formatC);
                    graph.DrawString(mount[11 - c % 12], title, Brushes.Black, new Rectangle(left + cWidth * i, height + bottom / 2, cWidth, bottom / 2), formatC);
                }
                if (radioButtonYears.Checked)
                    graph.DrawString((last.Year - c).ToString(), title, Brushes.Black, new Rectangle(left + cWidth * i, height, cWidth, bottom), formatC);
                if (radioButtonEverytime.Checked)
                {
                    graph.DrawString((last.Year - c * yearsInColumn - yearsInColumn + 1).ToString(), title, Brushes.Black, new Rectangle(left + cWidth * i, height, cWidth, bottom / 2), formatC);
                    graph.DrawString((last.Year - c * yearsInColumn).ToString(), title, Brushes.Black, new Rectangle(left + cWidth * i, height + bottom / 2, cWidth, bottom / 2), formatC);
                }
            }
            pictureBox.Image = bmp;
        }

        private void FormStatistic_Paint(object sender, PaintEventArgs e) { DrawGraph(); }
    }
}
