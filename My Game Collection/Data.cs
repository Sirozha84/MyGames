﻿using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace My_Game_Collection
{
    public class Data
    {
        public static Data data;
        public List<Game> games = new List<Game>();
        public List<string> publishers = new List<string>();
        public List<Platform> platforms = new List<Platform>();
        public int platformLastID;

        public List<string> genres = new List<string>();

        public List<Medium> mediums = new List<Medium>();


        public static void Load()
        {
            //try
            //{
                var serializer = new XmlSerializer(typeof(Data));
                using (var reader = new StreamReader("Data.xml"))
                    data = (Data)serializer.Deserialize(reader);
            /*}
            catch
            {
                data = new Data();
            }*/
        }

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

        public static string PlatformIDtoName(int id)
        {
            Platform p = data.platforms.Find(o => o.ID == id);
            return p != null ? p.name : "";
        }

        public static int PlatformNametoID(string name)
        {
            Platform p = data.platforms.Find(o => o.name == name);
            return p != null ? p.ID : 0;
        }
    }
}
