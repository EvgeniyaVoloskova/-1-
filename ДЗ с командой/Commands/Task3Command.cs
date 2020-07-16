using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace ДЗ_с_командой.Commands
{
    class Task3Command : CommandInterface
    {
        public bool CanRun(string userCommand)
        {
            return userCommand == "3";
        }

        public string GetHelp()
        {
            return "Задание 3\nЧисловые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32." +
                "Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот.";
        }

        public string GetMenuRow()
        {
            return "3. Демонстрация задания 3";
        }

        public void Run(string userCommand, ref bool isExit)
        {
            WriteLine("Введите символы для конвертации, введите '!' для остановки считывания символов ");
            char symbol;
            do
            {
                symbol = (char)Read();
                int IntASCII = (int)symbol;
                if (65 <= IntASCII && IntASCII <= 90)
                {
                    IntASCII += 32;
                    symbol = (char)IntASCII;
                    Write(symbol);
                }
                else if (97 <= IntASCII && IntASCII <= 122)
                {
                    IntASCII -= 32;
                    symbol = (char)IntASCII;
                    Write(symbol);
                }

            } while (symbol != '!');
            Write("\n");
        }

    }
}

