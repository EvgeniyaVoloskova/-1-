using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace ДЗ_с_командой.Commands
{
    class Task4Command : CommandInterface
    {
        bool CommandInterface.CanRun(string userCommand)
        {
            return userCommand == "4";
        }

        string CommandInterface.GetHelp()
        {
            return "Задание 4\nДаны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; каждое число должно выводиться на новой строке " +
                "при этом каждое число должно выводиться количество раз, равное его значению"; 

        }

        string CommandInterface.GetMenuRow()
        {
            return "4. Демонстрация задания 4";
        }

        void CommandInterface.Run(string userCommand, ref bool isExit)
        {
            int a, b;
            WriteLine("Введите два положительных числа a и b такие, чтобы  a было меньше b ");
            a = Int32.Parse(ReadLine());
            b = Int32.Parse(ReadLine());
            if (a >= b || a < 0 || b < 0)
            {
                WriteLine("Ну просили же либо  a < b, либо a и b положительные! ");
            }
            else
            {
                while (a <= b)
                {
                    for (int i = 0; i < a; ++i)
                    {
                        Write(a);
                    }
                    Write("\n");
                    ++a;
                }
            }

        }
    }
}
