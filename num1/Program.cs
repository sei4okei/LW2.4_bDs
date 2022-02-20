using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;
using System.Threading.Tasks;


namespace num1
{
    internal class Program
    {
        static void Main()
        {
            WriteLine();
            WriteLine("Выберите задачу: \n" +
                "0. Выход \n" +
                "1. Реализовать метод вычисления периметра треугольника \n" +
                "2. Найти периметр фигуры ABCD \n" +
                "3. Определить в каком числе больше цифр.");
            Input();
            SelectTask();
        }
        static void Input()
        {
            Write("> ");
        }

        static double CheckInput()
        {
            double UserInput;

            while (true)
            {
                try
                {
                    return UserInput = Convert.ToDouble(ReadLine());
                }
                catch (Exception)
                {
                    WriteLine("Что-то пошло не так, попробуйте снова!");
                    Input();
                }
            }
        }

        static void SelectTask()
        {

            switch (CheckInput())
            {
                case 0:
                    Environment.Exit(0);
                    break;

                case 1:
                    Clear();
                    InputTask1();
                    break;

                case 2:
                    Clear();
                    InputTask2();
                    break;

                case 3:
                    Clear();
                    InputTask3();
                    break;

                default:
                    WriteLine("Возникла непредвиденная ошибка, попробуйте снова!");
                    Input();
                    break;
            }

        }
        #region Task1
        static void InputTask1()
        {
            double A;
            double B;
            double C;
            Write("Введите первую сторону треугольника: ");
            A = CheckInput();
            Write("Введите вторую сторону треугольника: ");
            B = CheckInput();
            Write("Введите третью сторону треугольника: ");
            C = CheckInput();
            CalculationTask1(A, B, C);
        }

        static void CalculationTask1(double A, double B, double C)
        {
            OutputTask1(A + B + C);
        }

        static void OutputTask1(double Result)
        {
            WriteLine($"Периметр треугольника получился: {Result}");
            Main();
        }
        #endregion
        #region Task2
        static void InputTask2()
        {
            double AB;
            double AC;
            double CD;
            Write("Введите длину стороны AB: ");
            AB = CheckInput();
            Write("Введите длину стороны AC: ");
            AC = CheckInput();
            Write("Введите длину стороны CD: ");
            CD = CheckInput();
            CalculationTask2(AB, AC, CD);
        }

        static void CalculationTask2(double AB, double AC, double CD)
        {
            double BC = Sqrt(Pow(AB, 2) + Pow(AC, 2));
            double BD = Sqrt(Pow(BC, 2) + Pow(CD, 2));
            OutputTask2(AB + BD + CD + AC);
        }

        static void OutputTask2(double Result)
        {
            WriteLine($"Периметр фигуры получился: {Result}");
            Main();
        }
        #endregion
        #region Task3
        static void InputTask3()
        {
            double Num1;
            double Num2;
            Write("Введите первое число: ");
            Num1 = CheckInput();
            Write("Введите второе число: ");
            Num2 = CheckInput();
            CalculationTask3(Num1, Num2);
        }

        static void CalculationTask3(double Num1, double Num2)
        {
            NumsInNumber(Num1);
            NumsInNumber(Num2);

            if (NumsInNumber(Num1) == NumsInNumber(Num2))
            {
                OutputTask3(0, NumsInNumber(Num1), 1);
            }
            else
            {
                if (NumsInNumber(Num1) > NumsInNumber(Num2))
                {
                    OutputTask3(Num1, NumsInNumber(Num1), 0);
                }
                else
                {
                    OutputTask3(Num2, NumsInNumber(Num2), 0);
                }
            }
        }

        static int NumsInNumber(double Num)
        {
            var StringNum = Num.ToString();

            if (StringNum.Contains("-"))
            {
                if (StringNum.Contains(","))
                {
                    return StringNum.Length - 2;
                }
                else
                {
                    return StringNum.Length - 1;
                }
            }
            else if (StringNum.Contains(","))
            {
                return StringNum.Length - 1;
            }
            return StringNum.Length;
        }

        static void OutputTask3(double Num, int Quantity, int TypeOfOutput)
        {
            switch (TypeOfOutput)
            {
                case 0:
                    WriteLine($"Число {Num} - больше, потому что в нем {Quantity} цифр!");
                    Main();
                    break;

                case 1:
                    WriteLine($"Числа равны! Их длинна составляет {Quantity}");
                    Main();
                    break;
            }
        }
        #endregion
    }
}
