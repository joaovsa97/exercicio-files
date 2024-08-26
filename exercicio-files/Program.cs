using System.Globalization;

namespace exercicio_files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string SourcePath = @"D:\Programção\c-sharp\exercicio-files\sales\sales.csv";
            string TargetPath = @"D:\Programção\c-sharp\exercicio-files\sales\out\summary.csv";

            try
            {
                string[] itens = File.ReadAllLines(SourcePath);

                using (StreamWriter sw = File.AppendText(TargetPath))
                {
                    foreach (string line in itens)
                    {
                        string name = line.Split(',')[0];
                        float value = float.Parse(line.Split(',')[1]);
                        int qnt = int.Parse(line.Split(',')[2]);
                        double total = (value * qnt)/100;
                        string output = $"{name}, {total.ToString("N2")}";
                        sw.WriteLine(output);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
