using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace чихпыхх
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {

                int choice;
                bool FirstTime = true;
                do
                {
                    if (FirstTime)
                    {
                        Console.WriteLine("Выберите игру:\n1.Игра \"Угадай число\"\r\n2.Таблица умножения\r\n3.Вывод делителей числа\r\n4.Выход из программы");
                        FirstTime = false;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели неправильный номер.");
                    }
                    choice = Convert.ToInt32(Console.ReadLine());
                } while (choice != 1 && choice != 2 && choice != 3 && choice != 4);
                switch (choice)
                {
                    case 1:
                        Guess();
                        break;
                    case 2:
                        Table();
                        break;
                    case 3:
                        Deliteli();
                        break;
                    case 4:
                        Console.WriteLine("Вы вышли из программы.");
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (true);
        }
        static void Guess()
        {
            Random rnd = new Random();
            int RndmNum = rnd.Next(0, 101);
            int YourChoice;
            int NumbersOfTry = 0;
            Console.WriteLine("Угадайте число от 0 до 100 включительно!");
            do
            {
                NumbersOfTry++;
                YourChoice = Convert.ToInt32(Console.ReadLine());
                if (YourChoice > RndmNum)
                {
                    Console.WriteLine("Загаданное число меньше");
                }
                else if (YourChoice < RndmNum)
                {
                    Console.WriteLine("Загаданное число больше");
                }
                else
                {
                    Console.WriteLine($"Вы угадали за {NumbersOfTry} попыток!");
                }
            } while (YourChoice != RndmNum);
        }
        static void Table()
        {
            int[,] Matrix = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {

                for (int j = 1; j < 10; j++)
                {
                    Matrix[i, j] = (i + 1) * j;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Deliteli()
        {
            Console.WriteLine("Введите число");
            int NumDel = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= NumDel; i++)
            {
                if (NumDel % i == 0)
                {
                    Console.Write($"{i}   ");
                }
            }
            Console.WriteLine("");
        }
    }
}
