using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ДЗ_с_командой.Commands
{
    class Task2Command : CommandInterface
    {
        bool CommandInterface.CanRun(string userCommand)
        {
            return userCommand == "2";
        }

        public string GetHelp()
        {
           return "Задание 2\nВвести с клавиатуры номер трамвайного билета (6-значное число) и проверить является ли данный билет счастливым";
        }

        string CommandInterface.GetMenuRow()
        {
            return "2. Демонстрация задания 2";
        }

        void CommandInterface.Run(string userCommand, ref bool isExit)
        {
            string sTicketNumber;
            int nTicketNumber;
            bool isTicketNumberValid = false;
            do
            {
                sTicketNumber = ReadLine();
                if (sTicketNumber.Length == 6 && int.TryParse(sTicketNumber, out nTicketNumber))
                {
                    isTicketNumberValid = true;
                }
            } while (!isTicketNumberValid);
            int leftPart = 0, rightPart = 0;
            for (int i = 0; i < sTicketNumber.Length; ++i)
            {
                if (i < 3)
                {
                    leftPart += int.Parse(sTicketNumber[i].ToString());
                }
                else
                {
                    rightPart += int.Parse(sTicketNumber[i].ToString());
                }
            }
            bool isLucky = leftPart == rightPart;
            WriteLine(isLucky ? "Счастливый" : "Несчастливый");
            isExit = false;
        }
    }
}
