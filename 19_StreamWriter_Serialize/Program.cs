using Newtonsoft.Json;

namespace _19_StreamWriter_Serialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { };

            Add("Ibrahim");
            Add("Qarib");
            Add("Eli");

            Delete(1);

            Console.WriteLine(Search("Eli"));

            string json = JsonConvert.SerializeObject(names);

            using (StreamWriter sw = new StreamWriter(@"C:\Users\ibrah\OneDrive\Masaüstü\CodeAcademy\19_StreamWriter_Serialize\19_StreamWriter_Serialize\Files\Name.json"))
            {
                sw.Write(json);
            }

            using (StreamReader sr = new StreamReader(@"C:\Users\ibrah\OneDrive\Masaüstü\CodeAcademy\19_StreamWriter_Serialize\19_StreamWriter_Serialize\Files\Name.json"))
            {
                sr.ReadToEnd();
            }
            
            void Add(string name)
            {
                names.Add(name);
            }

            void Delete(int index)
            {
                names.RemoveRange(index,1);
            }

            bool Search(string query)
            {
                foreach (var  item in names)
                {
                    if(item == query) return true;
                }
                return false;
            }


        }
    }
}
