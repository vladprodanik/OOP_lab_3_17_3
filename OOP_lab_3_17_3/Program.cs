using System;
using System.IO;

namespace OOP_lab_3_17_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fileFromD = new StreamReader("D:/222.txt");

            string str = fileFromD.ReadLine();

            fileFromD.Close();

            string[] decimals = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int index = 0;
            int counter = 0;

            int leftLimit = int.Parse(Console.ReadLine());
            int rightLimit = int.Parse(Console.ReadLine());


            int[] a = new int[decimals.Length];

            foreach (string _decimal in decimals)
            {
                if (Int32.TryParse(_decimal, out a[index]))
                {
                    if ((a[index] >= leftLimit) && (a[index] <= rightLimit))
                    {
                        ++counter;
                    }
                }
                ++index;
            }

            StreamWriter outputFile = File.CreateText("output.txt");

            outputFile.WriteLine(counter);

            outputFile.Close();
        }
    }
}
