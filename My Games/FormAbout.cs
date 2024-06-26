﻿using System.Drawing;
using System.Windows.Forms;

namespace My_Games
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            Font fontR = new Font(history.Font.FontFamily, history.Font.Size, FontStyle.Regular);
            Font fontB = new Font(history.Font.FontFamily, history.Font.Size, FontStyle.Bold);
            labelVersion.Text = "Версия: " + Program.Version;

            history.SelectionFont = fontB;
            history.AppendText("Версия 2.6 (12.05.2024)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Возможность скрывать игры из списка и статистики не удаляя их\n" +
                "• Добавлена возможность указывать метод прохождения (честно, с читами, или просмотр)\n" +
                "• Масштаб в статистике теперь меняется кнопками \"-\" и \"+\"\n" +
                "• При создании нового события будет учитываться история\n" +
                "• Изменён порядок сортировки дат, теперь последние события отображаются сверху\n" +
                "• Убрана возможность менять тип даты для сортировки, вместо этого последней датой считается любая покупка, событие или заметка\n" +
                "• Добавлен фильтр по году выпуска\n" +
                "• Проверка на присутствие важных данных при сохранении игры, покупок или событий\n" +
                "• В событии теперь нельзя выбрать \"Не запускалась\"\n" +
                "• Несколько новых иконок для меню\n\n");

            history.SelectionFont = fontB;
            history.AppendText("Версия 2.5 (30.04.2022)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Добавлено автоматическое вычисления часов события по данным счётчика\n" +
                "• Переключение между тремя режимами представления даты игры\n" +
                "• Привязка папки со скриншотами и быстрый к ней переход\n" +
                "• Настройки программы теперь не будут сбрасываться при обновлении\n" +
                "• Исправлена пропавшая возможность удалить обложку у игры\n" +
                "• Исправлено автоматическое скрытие платформ в выпадающем списке события, "+
                "а также, эта функция добавлена в окно дополнительных материалов\n\n");

            history.SelectionFont = fontB;
            history.AppendText("Версия 2.4 (30.04.2021)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Оптимизация рисования диаграмм статистики\n" +
                "• Правка инкремента ID игры при отмене записи\n" +
                "• Событие по умолчанию теперь \"Пройдена\"\n" +
                "• При редактировании события если указана платформа, версии игры для которой нет - теперь не сбрасывается\n\n");

            history.SelectionFont = fontB;
            history.AppendText("Версия 2.3 (29.12.2020)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Приведены в порядок отображения чисел\n"+
                "• Колонка комментариев в истории прохождений\n"+
                "• Запрет на создание игр и элементов справочников без имени\n"+
                "• Небольшие правки в окне статистики\n\n");

            history.SelectionFont = fontB;
            history.AppendText("Версия 2.2 (05.05.2020)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Возможность удалить обложку(через контекстное меню)\n" +
                "• Исправлена ошибка не дающая изменить обложку\n" +
                "• Исправлена неактивная надпись в рамке с обложкой когда нет изображения\n" +
                "• Исправлено неправильное выделение столбиков в статистике\n" +
                "• Исправлены вылеты при вводе неправильных значений\n" +
                "• Исправлен вылет при попытке посмотреть статистику без данных\n" +
                "• Исправлено обновление вкладки \"Прочее\" при изменении данных\n\n");

            history.SelectionFont = fontB;
            history.AppendText("Версия 2.1 (29.03.2020)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Новый график в статистике \"размер коллекции\"\n" +
                "• Улучшение рисовки графиков (исправоено скачкообразное масштабирование)\n" +
                "• Новая иконка\n\n");

            history.SelectionFont = fontB;
            history.AppendText("Версия 2.0 (27.02.2020)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Фильтрация списка игр по разным параметрам\n" +
                "• Фильтрация платформ в выпадающих списках при добавлении DLC или события\n" +
                "• Выделение указанной платформы на диаграмме\n" +
                "• Отображение количества элементов на вкладках формы \"Игры\"\n" +
                "• Более информативная панель информации\n" +
                "• Разделение разрядов чисел в статистике и таблицах\n" +
                "• Отключение раскраски в списке игр\n" +
                "• Переработаны меню и панель инструментов, новые иконки\n" +
                "• Больше информации в строке статуса\n" +
                "• Больше информации на вкладке \"Прочее\"\n" +
                "• Исправлена ошибка неработающих кнопок при работе с DLC\n" +
                "• Поправлен порядок перехода между полями в форме \"Игра\"\n" +
                "• Исправлена продублированная горячая клавиша F7\n" +
                "• Исправлена ошибка при удалении заметок\n" +
                "• Прочие небольшие исправления и оптимизация\n\n");

            history.SelectionFont = fontB;
            history.AppendText("Версия 1.3 (06.12.2019)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Новый дизайн формы \"Игра\", информация разделена вкладками\n" +
                "• Возможность прикреплять обложку игры\n" +
                "• Заметки\n\n");

            history.SelectionFont = fontB;
            history.AppendText("Версия 1.2 (21.10.2019)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Отчёт \"История прохождений\"\n" +
                "• Исправлена ошибка открытия формы игры, форма не открывалась если не было комментария\n" +
                "• Исправлена фильтрация носителей (не везде и не всегда срабатывала)\n" +
                "• Исправлена ошибка перехода на сайт (не всегда переходил)\n" +
                "• Окно \"О программе\" с историей версий\n\n");

            history.SelectionFont = fontB;
            history.AppendText("Версия 1.1 (19.10.2019)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Отчёт \"История покупок\"\n" +
                "• В платформах можно указать индивидуальный цвет и привязать к ней список носителей, это упрощает выбор носителя при добавлении игры\n" +
                "• Комментарии к версиям и дополнительным материалам\n" +
                "• Унификация форм для всех список в игре\n" +
                "• Небольшие улучшения формы \"Игра\", добавлены разрывы строк в комментариях\n" +
                "• Новое поле \"Сайт\" для хранения ссылки на страницу игры, переход возможен прямо из списка игр\n\n");

            history.SelectionFont = fontB;
            history.AppendText("Версия 1.0 (12.05.2019)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Статистика по коллекции по пунктам \"Игр куплено\", \"Денег потрачено\" и \"Часов наиграно\", с возможностью выбора масштаба\n" +
                "• Скрываемая информационная панель\n" +
                "• Новые поля в данных: дата создания и дата изменения документа\n" +
                "• Исправлена ошибка даты при быстром создании задним числом\n" +
                "• Исправлена ошибка суммы при быстром создании\n" +
                "• Стрелки направления сортировки в столбцах\n" +
                "• Небольшие общие доработки и изменения в дизайне\n\n");

            history.SelectionFont = fontB;
            history.AppendText("Версия 0.9 (28.10.2018)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Ведение базы игр со списком покупок, дополнительных материалов и истории прохождения\n" +
                "• Быстрое добавление игры с основными полями");
        }

        private void GotoSite(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sg-software.ru");
        }
    }
}
