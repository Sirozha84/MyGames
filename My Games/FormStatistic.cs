using System;
using System.Drawing;
using System.Windows.Forms;

namespace My_Games
{
    public partial class FormStatistic : Form
    {
        int zoomMode = 2;                           //Режим увеличения: 0 - всё, 1 - годы, 2 - месяцы
        const int zoomMax = 2;                      //Максимальный зум
        DateTime first;                             //Дата первого события
        DateTime last;                              //Дата последнего события
        int ctCount;                                //Количество строк ленегды
        int yearCount, monthCount, allCount;        //Количество лет, месяцев, общих колонок
        int yearsInColumn;                          //Лет в колонке
        int scrollVal;                              //Позиция скролла
        int[,] categories;                          //Категории столбиков (легенда)
        int[,] months, years, all;                  //Таблицы с данными
        int heightMounts, heightYears, heightAll;   //Максимальные высоты
        bool isUser;                                //Скроллбары двигает пользователь?
        Bitmap bmp;
        Graphics graph;
        string[] mount = { "Янв.", "Фев.", "Март", "Апр.", "Май", "Июнь", "Июль", "Авг.", "Сен.", "Окт.", "Ноя.", "Дек." };

        SolidBrush[] plBrushes;
        public FormStatistic()
        {
            InitializeComponent();
            graph = pictureBox.CreateGraphics();
            Calc(null, null);
        }

        #region Расчёты данных (выбор вида диаграммы)
        private void Calc(object sender, EventArgs e)
        {
            if (radioButtonCS.Checked) CalcColCount();
            if (radioButtonGames.Checked) CalcGames();
            if (radioButtonMoney.Checked) CalcMoney();
            if (radioButtonTime.Checked) CalcTime();
        }

        void CalcColCount()
        {
            ctCount = 7;

            //Сканируем базу и узнаём крайние даты (минимум и максимум)
            first = DateTime.Now;
            foreach (Game g in Data.data.games)
                foreach (Version v in g.versions)
                    if (first > v.date) first = v.date;
            last = DateTime.Now;
            ColumnsCalc();

            //И заполняем их
            for (int i = 0; i < monthCount; i++)
            {
                DateTime date = new DateTime(first.Year + i / 12, i % 12 + 1, 1);
                date = date.AddMonths(1);
                foreach (Game game in Data.data.games)
                {
                    int max = 0;
                    if (game.versions.Find(o => o.date <= date) != null)
                    {
                        foreach (Event ev in game.history)
                            if (ev.date <= date && ev.even > max) max = ev.even;
                        months[monthCount - i - 1, max]++;
                        //if (date <= last.AddMonths(1)) - это даёт не заполнятся будущим месяцам, но тогда и года не заполняются
                    }
                }
            }
            //Берём последние значения для срезов по годам
            for (int j = 0; j < ctCount; j++)
            {
                for (int i = 0; i < yearCount; i++)
                {
                    int m = i * 12;
                    if (m < monthCount) years[i, j] = months[m, j];
                }
                for (int i = 0; i < 10; i++)
                {
                    int m = i * 12 * yearsInColumn;
                    if (m < monthCount) all[i, j] = months[i * 12 * yearsInColumn, j];
                }
            }
            //Очищаем остальные месяца, оставляя текущий последним заполненным
            int empty = 12 - last.Month;
            for (int j = 0; j < ctCount; j++)
                for (int i = 0; i < empty; i++)
                    months[i, j] = 0;

            //Рисовка легенды
            columnHeader.Text = "Статус";
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

            FindMaximumHeight();
            Zoom();
        }

        void CalcGames()
        {
            //Сканируем базу и узнаём крайние даты (минимум и максимум)
            first = DateTime.Now;
            foreach (Game g in Data.data.games)
                foreach (Version v in g.versions)
                    if (first > v.date) first = v.date;
            last = first;
            foreach (Game g in Data.data.games)
                foreach (Version v in g.versions)
                    if (last < v.date) last = v.date;
            ctCount = Data.data.platforms.Count;
            if (ctCount < 1) return;
            ColumnsCalc();

            //Создадим табличку с рейтингом по платформам
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

            //Заполняем массивы
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
                    months[last.Year * 12 - v.date.Year * 12 + 12 - v.date.Month, p]++;
                    all[(last.Year - v.date.Year) / yearsInColumn, p]++;
                }

            FindMaximumHeight();
            Zoom();
        }

        void CalcMoney()
        {
            //Сканируем базу и узнаём крайние даты (минимум и максимум)
            first = DateTime.Now;
            foreach (Game g in Data.data.games)
            {
                foreach (Version v in g.versions) if (first > v.date) first = v.date;
                foreach (DLC d in g.DLCs) if (first > d.date) first = d.date;
            }
            last = first;
            foreach (Game g in Data.data.games)
            {
                foreach (Version v in g.versions) if (last < v.date) last = v.date;
                foreach (DLC d in g.DLCs) if (last < d.date) last = d.date;
            }
            ctCount = Data.data.platforms.Count;
            if (ctCount < 1) return;
            ColumnsCalc();

            //Создадим табличку с рейтингом по платформам
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
            
            //Заполняем массивы
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
                    months[last.Year * 12 - v.date.Year * 12 + 12 - v.date.Month, p] += v.price;
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
                    months[last.Year * 12 - d.date.Year * 12 + 12 - d.date.Month, p] += d.price;
                    all[(last.Year - d.date.Year) / yearsInColumn, p] += d.price;
                }
            }
            FindMaximumHeight();
            Zoom();
        }

        void CalcTime()
        {
            //Сканируем базу и узнаём крайние даты (минимум и максимум)
            first = DateTime.Now;
            foreach (Game g in Data.data.games)
                foreach (Event ev in g.history)
                    if (first > ev.date) first = ev.date;
            last = first;
            foreach (Game g in Data.data.games)
                foreach (Event ev in g.history)
                    if (last < ev.date) last = ev.date;
            ctCount = Data.data.platforms.Count;
            if (ctCount < 1) return;
            ColumnsCalc();

            //Создадим табличку с рейтингом по платформам
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

            //Заполняем массивы
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
                    months[last.Year * 12 - ev.date.Year * 12 + 12 - ev.date.Month, p] += ev.hours;
                    all[(last.Year - ev.date.Year) / yearsInColumn, p] += ev.hours;
                }

            FindMaximumHeight();
            Zoom();
        }
        #endregion

        #region Сопутствующие вычисления
        /// <summary>
        /// Вычисление количества колонок
        /// </summary>
        void ColumnsCalc()
        {
            //Считаем количество месяцев
            monthCount = (last.Year - first.Year + 1) * 12;
            if (monthCount < 12) monthCount = 12;
            months = new int[monthCount, ctCount];
            
            //Считаем количество лет
            yearCount = last.Year - first.Year + 1;
            if (yearCount < 10) yearCount = 10;
            years = new int[yearCount, ctCount];
            
            //Общее количество
            allCount = 10;
            yearsInColumn = yearCount / 10 + ((yearCount % 10) > 0 ? 1 : 0);
            all = new int[allCount, ctCount];
        }
        
        /// <summary>
        /// Поиск максимальных высот столбиков
        /// </summary>
        void FindMaximumHeight()
        {
            heightMounts = 0;
            for (int i = 0; i < monthCount; i++)
            {
                int height = 0;
                for (int j = 0; j < ctCount; j++)
                    height += months[i, j];
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
            for (int i = 0; i < allCount; i++)
            {
                int height = 0;
                for (int j = 0; j < ctCount; j++)
                    height += all[i, j];
                if (heightAll < height) heightAll = height;
            }
        }
        #endregion

        #region Выбор масштаба
        private void ZoomIn(object sender, EventArgs e)
        {
            if (zoomMode < zoomMax)
            {
                zoomMode++;
                Zoom();
            }
        }
        private void ZoomOut(object sender, EventArgs e)
        {
            if (zoomMode > 0)
            {
                zoomMode--;
                Zoom();
            }
        }
        /// <summary>
        /// Изменение масштаба, настройка скролл-баров и последующая перерисовка диаграмм
        /// </summary>
        void Zoom()
        {
            isUser = false;
            if (zoomMode == 0)
            {
                labelZoom.Text = "Все";
                scrollBar.Maximum = 0;
                scrollBar.Enabled = false;
            }
            if (zoomMode == 1)
            {
                labelZoom.Text = "Годы";
                scrollBar.Maximum = yearCount - 1;
                scrollBar.Value = scrollBar.Maximum - 9;
                scrollBar.LargeChange = 10;
                scrollBar.Enabled = true;
            }
            if (zoomMode == 2)
            {
                labelZoom.Text = "Месяцы";
                scrollBar.Maximum = monthCount - 1;
                scrollBar.Value = scrollBar.Maximum - 11;
                scrollBar.LargeChange = 12;
                scrollBar.Enabled = true;
            }
            isUser = true;
            buttonZoomOut.Enabled = zoomMode > 0;
            buttonZoomIn.Enabled = zoomMode < zoomMax;
            Scrolling(null, null);
        }
        #endregion

        #region Скроллинг или выбор легенды
        private void Scrolling(object sender, EventArgs e)
        {
            if (!isUser) return;
            scrollVal = 0;
            if (zoomMode == 1) scrollVal = scrollBar.Maximum - scrollBar.Value - 9;
            if (zoomMode == 2) scrollVal = scrollBar.Maximum - scrollBar.Value - 11;
            DrawGraph();
        }

        private void LegendChange(object sender, EventArgs e) { DrawGraph(); }
        #endregion

        #region Рисование
        private void FormStatistic_Paint(object sender, PaintEventArgs e) { DrawGraph(); }

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
            columnHeader.Text = "Платоформа";
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
            int[,] m = months;
            int scroll = 0;
            int columns = 0;
            int heightColumns = 0;
            if (zoomMode == 0) { m = all; scroll = 9; columns = 10; heightColumns = heightAll; }
            if (zoomMode == 1) { m = years; scroll = scrollVal + 9; columns = 10; heightColumns = heightYears; }
            if (zoomMode == 2) { m = months; scroll = scrollVal + 11; columns = 12; heightColumns = heightMounts; }
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

                //Подписи столбиков
                if (zoomMode == 0)
                {
                    graph.DrawString((last.Year - c * yearsInColumn - yearsInColumn + 1).ToString(), title, Brushes.Black, new Rectangle(left + cWidth * i, height, cWidth, bottom / 2), formatC);
                    graph.DrawString((last.Year - c * yearsInColumn).ToString(), title, Brushes.Black, new Rectangle(left + cWidth * i, height + bottom / 2, cWidth, bottom / 2), formatC);
                }
                if (zoomMode == 1)
                    graph.DrawString((last.Year - c).ToString(), title, Brushes.Black, new Rectangle(left + cWidth * i, height, cWidth, bottom), formatC);
                if (zoomMode == 2)
                {
                    if (i == 0 | c % 12 == 11)
                        graph.DrawString((last.Year - c / 12).ToString(), title, Brushes.Black, new Rectangle(left + cWidth * i, height, cWidth, bottom / 2), formatC);
                    graph.DrawString(mount[11 - c % 12], title, Brushes.Black, new Rectangle(left + cWidth * i, height + bottom / 2, cWidth, bottom / 2), formatC);
                }
            }
            pictureBox.Image = bmp;
        }
        #endregion
    }
}