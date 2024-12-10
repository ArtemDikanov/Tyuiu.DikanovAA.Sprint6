using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DikanovAA.Sprint6.Task6.V22.Lib
{
    public class DataService : ISprint6Task6V22
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ' ')
                        {
                            resStr = resStr + line[i] + " ";
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return resStr;
        }
    }
}
