using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        public static async Task<List<int>> ReadDataAsync(string path)
        {
            List<int> numbers = new List<int>();
            string line;

            try
            {

                StreamReader sr = new StreamReader(path);
                line = sr.ReadLine();
                while (line != null)
                {
                    numbers.Add(int.Parse(line));
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception " + e.Message);
            }
            return numbers;
        }

        public static async Task<int> SumOfNumbersAync(List<int> numbers)
        {
            string appPath = @"..\..\..\";
            string folderPath = appPath + "TextFile";
            string filePath = folderPath + @"\DummyNumbers.txt";

            numbers = await Task.Run((string filePath)
                =>
            {
                ReadDataAsync(filePath);

            });
            int sum = 0;
            foreach(int n in numbers)
            {
                sum += n;
            }
            return sum;

        }
        static void Main(string[] args)
        {
            string appPath = @"..\..\..\";
            string folderPath = appPath + "TextFile";
            string filePath = folderPath + @"\DummyNumbers.txt";
            
            ReadDataAsync(filePath);

            SumOfNumbersAync(ReadDataAsync(filePath));




            Console.ReadLine();
        }
    }
}
