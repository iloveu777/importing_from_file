using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
using System.Net.NetworkInformation;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Title = "получение значений для массива из файла";
            string filePath = @"C:\mass.txt"; // Указываем путь к файлу
            string[] lines = File.ReadAllLines(filePath); // Читаем все строки из файла в массив строк
            int[] values = Array.ConvertAll(lines, int.Parse); // Преобразуем массив строк в массив целых чисел
            foreach(int value in values)
            {
                Console.WriteLine(value);
            } */
            string a = "abcdабцд";
            int ab = 12;
            byte[] mas = {1, 11, 13, 5, };
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "example.txt");

            using (StreamWriter writer = File.CreateText(filePath))
            {
                for(int i = 0; i < mas.Length; i++)
                {
                    writer.WriteLine(mas[i]);
                }
            }
            WriteLine("записано.");
         /*    for (int i = 0; i < mas.Length; i++)
             {
                 file.Write($"{mas[i]}\n");
             }
            


             /*   string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "example.txt");
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    writer.Write("123");
                }
                Console.WriteLine("Файл успешно записан.");
            */
      

        ReadKey();
        }
    }
}
