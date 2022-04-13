using System;
using System.IO;
using System.Threading.Tasks;

namespace Client
{
    public class Program
    {
        private static readonly string BaseUrl = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin"));
        private static readonly string InTxtFile = "in.txt";
        private static readonly string OutTxtFile = "out.txt";
        static async Task Main(string[] args)
        {
            try
            {
                string[] lines = File.ReadAllLines(BaseUrl + InTxtFile);
                string[] result = new string[lines.Length];

                if (lines.Length < 10)
                    throw new Exception("The file must contain at least 10 words");

                for (int i = 0; i < lines.Length; i++)
                {
                    var word = await ServiceProcess.MainTask(lines[i]);
                    result[i] = word.Trim('"');
                }

                await File.WriteAllLinesAsync(BaseUrl + OutTxtFile, result);
                Console.WriteLine("The words were successfully reversed!");
               
            }
            catch (Exception)
            {
                throw new Exception("Error has occured!");
            }
        }
    }
}
