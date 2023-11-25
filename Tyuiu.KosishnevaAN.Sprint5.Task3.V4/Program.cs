using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosishnevaAN.Sprint5.Task3.V4.Lib;

namespace Tyuiu.KosishnevaAN.Sprint5.Task3.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Косишнева А. Н. | ИСТНб-23-1";
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                     *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                           *");
            Console.WriteLine("* Задание #3                                                                    *");
            Console.WriteLine("* Вариант #4                                                                    *");
            Console.WriteLine("* Выполнила: Косишнева Анастасия Николаенвна | ИСТНб-23-1                       *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                      *");
            Console.WriteLine("* Дано выражение вычислить его значение при x=3, результат сохранить в бинарный *");
            Console.WriteLine("* файл OutPutFileTask3.bin и вывести на консоль. Округлить до 3 знаков после ,. *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                              *");
            Console.WriteLine("*********************************************************************************");
            int x = 3;
            Console.WriteLine("" + x);

            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                    *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
