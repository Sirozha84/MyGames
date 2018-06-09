using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace My_Game_Collection
{
    static class Data
    {
        public static List<Game> games = new List<Game>();

        public static void Load()
        {
            try
            {
                var serializer = new XmlSerializer(typeof(List<Game>));
                using (var reader = new StreamReader("Data.xml"))
                {
                    games = (List<Game>)serializer.Deserialize(reader);
                }
            }
            catch { }
        }

        public static void Save()
        {
            var serializer = new XmlSerializer(typeof(List<Game>));
            using (var writer = new StreamWriter("Data.xml"))
            {
                serializer.Serialize(writer, games);
            }
        }
    }
}
