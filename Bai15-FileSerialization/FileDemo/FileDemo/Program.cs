using System;
using System.Collections.Generic;
using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Long\Desktop\LongBlue\Rim";
            //Directory.CreateDirectory(path);
            var fileName = "input.txt";

            using (StreamWriter sw = File.CreateText($@"{path}\{fileName}")) 
            {
                sw.WriteLine("Long Blue");
                sw.WriteLine("Long");
                sw.WriteLine("rIm");
            }

            List<string> data = new List<string>();
            using (StreamReader sr = File.OpenText($@"{path}\{fileName}"))
            {
                Console.WriteLine(sr.ReadToEnd());
                var line = string.Empty;
                int number = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    number += 1;
                    Console.WriteLine($"Line {number} : {line.ToUpper()}");
                    data.Add($"Line {number} : {line.ToUpper()}");
                }
            }
            data = FileHelper.ReadFile($@"{path}\{fileName}");

            var outputFileName = "output.txt";
            using (StreamWriter sw = File.CreateText($@"{path}\{outputFileName}"))
            {
                foreach (var item in data)
                {
                    sw.WriteLine(item);
                }
            }

            FileHelper.WriteFile($@"{path}\{outputFileName}", data);

        }
    }
}
