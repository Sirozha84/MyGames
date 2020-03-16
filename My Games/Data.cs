using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace My_Games
{
    public class Data
    {
        public static Data data;
        public List<Game> games = new List<Game>();
        public int gameLastID;
        public List<string> publishers = new List<string>();
        public List<Platform> platforms = new List<Platform>();
        public int platformLastID;
        public List<Medium> mediums = new List<Medium>();
        public int mediumLastID;
        public List<Genre> genres = new List<Genre>();
        public int genreLastID;
        public Filter filter = new Filter();
        public byte[] winColR = { 255, 255, 255, 224, 192, 160, 192 };
        public byte[] winColG = { 192, 224, 255, 255, 255, 255, 255 };
        public byte[] winColB = { 192, 192, 192, 192, 192, 160, 255 };

        /// <summary>
        /// Загрузка базы данных
        /// </summary>
        public static void Load()
        {
            try
            {
                var serializer = new XmlSerializer(typeof(Data));
                using (var reader = new StreamReader("Data.xml"))
                    data = (Data)serializer.Deserialize(reader);
            }
            catch
            {
                data = new Data();
            }
        }

        /// <summary>
        /// Запись базы данных
        /// </summary>
        public static void Save()
        {
            try
            {
                var serializer = new XmlSerializer(typeof(Data));
                using (var writer = new StreamWriter("Data.xml"))
                    serializer.Serialize(writer, Data.data);
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении данных");
            }
        }

        /// <summary>
        /// Возвращает наименование платформы по индексу
        /// </summary>
        /// <param name="id">Индекс платформы</param>
        /// <returns></returns>
        public static string PlatformIDToName(int id)
        {
            Platform p = data.platforms.Find(o => o.ID == id);
            return p != null ? p.name : "";
        }

        /// <summary>
        /// Возвращает индекс платформы по наименованию
        /// </summary>
        /// <param name="name">Наименование платформы</param>
        /// <returns></returns>
        public static int PlatformNameToID(string name)
        {
            Platform p = data.platforms.Find(o => o.name == name);
            return p != null ? p.ID : 0;
        }

        /// <summary>
        /// Возвращает наименование носителя по индексу
        /// </summary>
        /// <param name="id">Индекс носителя</param>
        /// <returns></returns>
        public static string MediumIDToName(int id)
        {
            Medium p = data.mediums.Find(o => o.ID == id);
            return p != null ? p.name : "";
        }

        /// <summary>
        /// Возвращает индекс носителя по наименованию
        /// </summary>
        /// <param name="name">Наименование носителя</param>
        /// <returns></returns>
        public static int MediumNameToID(string name)
        {
            Medium p = data.mediums.Find(o => o.name == name);
            return p != null ? p.ID : 0;
        }

        /// <summary>
        /// Возвращает наименование жанра по индексу
        /// </summary>
        /// <param name="id">Индекс жанра</param>
        /// <returns></returns>
        public static string GenreIDToName(int id)
        {
            Genre p = data.genres.Find(o => o.ID == id);
            return p != null ? p.name : "";
        }

        /// <summary>
        /// Возвращает индекс жанра по наименованию
        /// </summary>
        /// <param name="name">Наименование жанра</param>
        /// <returns></returns>
        public static int GenreNameToID(string name)
        {
            Genre p = data.genres.Find(o => o.name == name);
            return p != null ? p.ID : 0;
        }

        /// <summary>
        /// Компановка строки с версиями для красивого вывода
        /// </summary>
        /// <param name="versions"></param>
        /// <returns></returns>
        public static string StringVersions(List<Version> versions)
        {
            string text = "";
            foreach (Version v in versions)
            {
                if (text != "") text += ", ";
                text += PlatformIDToName(v.platform);
            }
            if (text == "") text += "Нет";
            return text;
        }

        /// <summary>
        /// Компановка строки с дополнительными материалами для красивого вывода
        /// </summary>
        /// <param name="dlcs"></param>
        /// <returns></returns>
        public static string StringDLCs(List<DLC> dlcs)
        {
            string text = "";
            foreach (DLC d in dlcs)
            {
                if (text != "") text += ", ";
                text += d.name;
            }
            if (text == "") text += "Нет";
            return text;
        }

        /// <summary>
        /// Компановка строки с историей прохождения для красивого вывода
        /// </summary>
        /// <param name="history"></param>
        /// <returns></returns>
        public static string StringHistory(List<Event> history)
        {
            int max = 0;
            int hours = 0;
            foreach (Event e in history)
            {
                if (max < e.even) max = e.even;
                hours += e.hours;
            }
            string text = Event.events[max];
            if (max > 0) text += ", время в игре: " + hours.ToString() + " ч.";
            return text;
        }
    }
}
