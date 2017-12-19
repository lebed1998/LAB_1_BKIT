using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Koef = new double[3];
            bool Cor_Answer;
            for (int i = 0; i < 3; i++) //Проверка на то, что введенные коэффициенты являются цифрами
                do
                {
                    Console.Write("Введите коэффиценты: ");
                    string str = Console.ReadLine();
                    Cor_Answer = double.TryParse(str, out Koef[i]);
                    if (!Cor_Answer)
                        Console.WriteLine("Вы не ввели число!");

                } while (!Cor_Answer);


            if (Koef[0] == 0 && Koef[1] == 0 && Koef[2] == 0) //Проверка на бесконечное количество корней уравнения
            {
                Console.WriteLine("Бесконечное количество корней!");
Console.ReadLine();
            }

            else
            {
                if (Koef[0] == 0)
                {
                    if (Koef[1] != 0 && Koef[2] != 0)
                    {
                        Console.WriteLine("Один корень: ");
                        Console.WriteLine(-Koef[2] / Koef[1]);
                    }
                    else
                        if (Koef[1] == 0 && Koef[2] != 0) Console.WriteLine("Уравнение не имеет корней!");
                    else Console.WriteLine("Один корень: 0");
                    Console.ReadLine();
                }
                else if (Koef[1] == 0)
                {
                    if (Koef[0] != 0 && Koef[2] != 0)
                    {
                        if ((Koef[0] > 0 && Koef[2] < 0) || (Koef[0] < 0 && Koef[2] > 0))
                        {
                            Console.WriteLine("Уравнение имеет 2 корня: ");
                            Console.Write("Первый корень: ");
                            Console.WriteLine(Math.Sqrt(-Koef[2] / Koef[0]));
                            Console.Write("Второй корень: ");
                            Console.WriteLine(-Math.Sqrt(-Koef[2] / Koef[0]));
                        }
                    }
                    

                    if (Koef[0] != 0 && Koef[2] == 0) Console.WriteLine("Один корень: 0");
                    Console.ReadLine();
                }
                else
                {
                    double disc = Koef[1] * Koef[1] - 4 * Koef[0] * Koef[2];//Подсчет дискриминанта, если все коэффициенты не оказались равны 0
                    Console.WriteLine("Дискриминант: " + disc);

                    if (disc < 0) Console.WriteLine("Корней нет!");//Проверка на отстуствие корней в уравнении
                    else if (disc == 0) //Проверка на существование одного корня в уравнении
                    {
                        Console.Write("Один корень: ");
                        Console.WriteLine(-Koef[1] / (2 * Koef[0]));
                    }
                    else //Подсчет двух корней квадратного уравнения
                    {
                        Console.Write("Первый корень: ");
                        Console.WriteLine((-Koef[1] + Math.Sqrt(disc)) / (2 * Koef[0]));
                        Console.Write("Второй корень: ");
                        Console.WriteLine((-Koef[1] - Math.Sqrt(disc)) / (2 * Koef[0]));
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
