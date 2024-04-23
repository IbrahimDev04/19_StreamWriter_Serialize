using Newtonsoft.Json;
using System.Xml.Linq;

namespace _19_StreamWriter_Serialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ibrah\OneDrive\Masaüstü\CodeAcademy\19_StreamWriter_Serialize\19_StreamWriter_Serialize\Files\Name.json";
            List<string> names = Deserialize(path);



            //Add("sdafsa");
            //Add("Ibrahim");
            //Add("Ali");
            //Remove(0);
            //Console.WriteLine(Search("Alii"));


        }

        public static void Serialize(List<string> names ,string path)
        {
            var json = JsonConvert.SerializeObject(names);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(json);
            }

            using (StreamReader sr = new StreamReader(@"C:\Users\ibrah\OneDrive\Masaüstü\CodeAcademy\19_StreamWriter_Serialize\19_StreamWriter_Serialize\Files\Name.json"))
            {
                sr.ReadToEnd();
            }

        }

        public static List<string> Deserialize(string path)
        {

            string result;
            using (StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadToEnd();
            }

            var names = JsonConvert.DeserializeObject<List<string>>(result);

            return names;
        }

        
        public static void Add(string name)
        {
            string path = @"C:\Users\ibrah\OneDrive\Masaüstü\CodeAcademy\19_StreamWriter_Serialize\19_StreamWriter_Serialize\Files\Name.json";

            List<string> names = Deserialize(path);

            names.Add(name);

            Serialize(names, path);
        }

        public static void Remove(int index)
        {
            string path = @"C:\Users\ibrah\OneDrive\Masaüstü\CodeAcademy\19_StreamWriter_Serialize\19_StreamWriter_Serialize\Files\Name.json";

            List<string> names = Deserialize(path);

            names.RemoveRange(index, 1);

            Serialize(names, path);
        }

        public static bool Search(string name)
        {

            string path = @"C:\Users\ibrah\OneDrive\Masaüstü\CodeAcademy\19_StreamWriter_Serialize\19_StreamWriter_Serialize\Files\Name.json";

            List<string> names = Deserialize(path);

            foreach (var item in names)
            {
                if (item == name) return true;
            }
            return false;
        }
    }
}
