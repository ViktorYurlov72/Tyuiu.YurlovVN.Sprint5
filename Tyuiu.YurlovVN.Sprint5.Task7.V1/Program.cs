using System;
using System.IO;
using Tyuiu.YurlovVN.Sprint5.Task7.V1.Lib;

namespace Tyuiu.YurlovVN.Sprint5.Task7.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V1.txt";
            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.LoadDataAndSave(path);

            Console.WriteLine($"Файл: {res}");
            Console.WriteLine("Создан!");
            Console.WriteLine($"Содержимое файла: {File.ReadAllText(res)}");

            Console.ReadKey();
        }
    }
}