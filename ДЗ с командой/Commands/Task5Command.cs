using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace ДЗ_с_командой.Commands
{
    class Task5Command : CommandInterface
    {
        bool CommandInterface.CanRun(string userCommand)
        {
            return userCommand == "5";
        }

        string CommandInterface.GetHelp()
        {
            return "Задание 5\nДано целое число N (> 0), найти число, полученное при прочтении числа N справа налево.";
        }

        string CommandInterface.GetMenuRow()
        {
            return "5. Демонстрация задания 5";
        }

        void CommandInterface.Run(string userCommand, ref bool isExit)
        {
            WriteLine("Введите  положительных число ");
            int number;
            int a;
            bool isPositive = false;
            do
            {
                number = Int32.Parse(ReadLine());
                if (number > 0)
                {
                    isPositive = true;
                }
            } while (!isPositive);

            while (number != 0)
            {
                a = number % 10;
                number /= 10;
                Write(a);
            }
            Write("\n");
        }
    }
}

