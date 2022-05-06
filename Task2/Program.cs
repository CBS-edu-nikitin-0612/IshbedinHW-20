using System;

namespace Task2
{
    internal class Program
    {
        public delegate double CalcDelegate(double a, double b);

        static void Main()
        {
            CalcDelegate Add = (a, b) => a + b;
            CalcDelegate Sub = (a, b) => a - b;
            CalcDelegate Mul = (a, b) => a * b;
            CalcDelegate Div = (a, b) =>
            {
                if (b==0)
                {
                    Console.WriteLine("Деление на ноль!");
                }
                return  a / b;
            };

            double a, b, result;
            string act;

            while (true)
            {
            start:
                Console.WriteLine("Введите первое число");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второе число");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите действие (Add, Sub, Mul, Div)");
                act = Console.ReadLine().ToUpper();

                switch (act)
                {
                    case "ADD": result = Add(a, b); break;
                    case "SUB": result = Sub(a, b); break;
                    case "MUL": result = Mul(a, b); break;
                    case "DIV": result = Div(a, b); break;
                    default: Console.WriteLine("Действие не найдено"); goto start;
                }
                Console.WriteLine(result);
            }
        }
    }
}
