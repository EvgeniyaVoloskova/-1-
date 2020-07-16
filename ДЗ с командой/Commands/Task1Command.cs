using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ДЗ_с_командой.Commands
{
    class Task1Command : CommandInterface
    {
        public bool CanRun(string userCommand)
        {
            return userCommand == "1";
        }

        public string GetHelp()
        {
           return "Задание 1\nНаписать программу, которая считывает символы с клавиатуры, пока не будет введена" +
                " точка.Программа должна сосчитать количество введенных пользователем пробелов";

        }

        public string GetMenuRow()
        {
            return "1. Демонстрация задания 1";
        }

        public void Run(string userCommand,ref bool isExit)
        {
            WriteLine("Введите символы, введите '.' для остановки считывания символов ");
            char symbol;
            int count = 0;
            do
            {
                symbol = (char)Read();   
                if (symbol == ' ')
                {
                    ++count;
                }
            } while (symbol != '.');


            WriteLine("Всего было введено {0} пробелов", count);
            isExit = false;
        }
    }
}
