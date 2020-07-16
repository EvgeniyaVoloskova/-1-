using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace ДЗ_с_командой.Commands
{
    class ExitCommand : CommandInterface
    {
        public bool CanRun(string userCommand)
        {
            return userCommand == "0";
        }

        public string GetHelp()
        {
            return "Выход из программы";
        }

        public string GetMenuRow()
        {
            return "0. Выход"; 
        }

        public void Run(string userCommand,ref bool isExit)
        {
            isExit = true;
            WriteLine("До новых встреч!");
            
        }
    }
}
