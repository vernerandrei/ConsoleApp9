using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            /// 1.Составить программу, которая запрашивает название футбольной команды
            //и повторяет его на экране со словами "— это чемпион!".

            //Console.Write("Введите название футбольной команды");
            //string str = Console.ReadLine();
            //Console.WriteLine($"{str}- это чемпион!");

            // Составить программу, которая запрашивает отдельно имя и отдельно фамилию,
            // а затем выводит их как одну символьную строку.

            //Console.Write("Введите Фамилию: ");
            //string str = Console.ReadLine();
            //Console.Write("Введите Имя: ");
            //string str1 = Console.ReadLine();
            ////string str2 = str + str1;
            //Console.WriteLine($"{str} {str1}");

            //3.       Составить программу, которая запрашивает название государства и его столицы,
            //а затем выводит сообщение: "Столица государства ... — город ..."
            //(на месте многоточий должны быть выведены соответствующие значения).

            //Console.Write("Введите Государство: ");
            //string str = Console.ReadLine();
            //Console.Write("Введите Столицу: ");
            //string str1 = Console.ReadLine();
            //Console.WriteLine($"Столица государства {str} — город {str1}");

            //4. Составить программу, которая запрашивает название романа и фамилию его автора,
            //а затем выводит сообщение: "Писатель ... — автор романа ..."
            //(на месте многоточий должны быть выведены соответствующие значения).

            //Console.Write("Название романа: ");
            //string str = Console.ReadLine();
            //Console.Write("Фамилия писателя: ");
            //string str1 = Console.ReadLine();
            //Console.WriteLine($"Писатель {str} — автор романа {str1}");

            // 5.Напишите программу, в которую вводится целое число,
            // после чего на экран выводится следующее и предыдущее целое число.
            // Например, при вводе числа 15 на экран должно быть выведено:

            //Console.Write("Число: ");
            //int str = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Следующие за число {str} число = {str+1}\nдля числа {str}" +
            //    $" предыдущие число= {str-1}");


            //6. Дано название футбольного клуба. Определить количество символов в нем.
            //Console.Write("Название футбольного клуба: ");
            //string str = Console.ReadLine();
            //Console.WriteLine(str.Length);

            //7. Написать программу, которая спрашивает имя пользователя и сколько ему лет
            //и выводит на экран сообщение «Здравствуй, Петя. Тебе 100 лет!))».
            //Вместо Петя и 100 соответствующие введенные данные.
            //Console.Write("Имя:");
            //string name = Console.ReadLine();
            //Console.Write("Сколько лет:");
            //string years = Console.ReadLine();
            //Console.WriteLine($"Здравствуй, {name}. Тебе {years} лет !");

            //8. Написать программу, которая по введеному значению, выводит само значение,
            //значение увеличенное на 1, значение увеличенное на 2, и сумму всех трех значений.
            //Console.Write("Число:");
            //int number = int.Parse(Console.ReadLine());
            //int s = number + 1;
            //int s1 = number + 2;
            //Console.WriteLine($"{number}, {s},{s1},{number + s +s1} ");

            //9.Даны два ненулевых вещественных числа. Найти сумму, разность, произведение и частное их квадратов.

            //Console.Write("Число1:");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Число2:");
            //double b = double.Parse(Console.ReadLine());
            //double a2 = Math.Pow(a,2) ;
            //double b2 = Math.Pow(b, 2);
            //double sum = a2 + b2;
            //double difference = a2 - b2;
            //double op = a2 * b2;
            //double quotient = a2 / b2;

            ////double sum = a + b;
            ////double difference = a - b;
            ////double op = a * b;
            ////double quotient = Math.Pow(a, 2) / Math.Pow(b, 2);
            //Console.WriteLine($"сумма = {sum}\nразность = {difference}\nпроизведение = {op}\nчастное = {quotient}");

            //10. Применить операцию конкатенации к переменным a, b, c, d, e так,
            //чтобы получилось необходимое значение переменной x. Задать заголовок окна «Конкатенация строк».
            //1)
            //string a = "фальш";
            //string b = "монеты";
            //string c = "в";
            //string d = "ивые";
            //string e = "мешках";
            //string x = a+d+" "+b+" "+c+" "+e;
            //2)
            //string a = "количе";
            //string b = "информа";
            //string c = "в байтах";
            //string d = "ство";
            //string e = "ции";
            //string x = a + d + " " + b+e + " " + c;
            //3)
            //string a = "мозг";
            //string b = "ребусы";
            //string c = "человече";
            //string d = "а";
            //string e = "ского";
            //string x = b+" "+c+e+" "+a+d;
            //4)
            //string a = "мульти";
            //string b = "технолог";
            //string c = "ийные";
            //string d = "ии";
            //string e = "мед";
            //string x = a+e+c+" "+b+d;
            //Console.WriteLine(x);
            //Console.ReadKey();
        }
    }
}
