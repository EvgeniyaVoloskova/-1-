using System;
using static System.Console;
using System.Collections;
using ДЗ_с_командой.Commands;

namespace ДЗ_с_командой
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList commands = new ArrayList();
            commands.Add(new ExitCommand());
            commands.Add(new Task1Command());
            commands.Add(new Task2Command());
            commands.Add(new Task3Command());
            commands.Add(new Task4Command());
            commands.Add(new Task5Command());
            bool isExit = false;
            string userCommand;
            do
            {
                WriteLine("Меню:");

                foreach (CommandInterface command in commands)
                {
                    WriteLine(command.GetMenuRow());
                }

                userCommand = ReadLine();

                foreach (CommandInterface command in commands)
                {
                    if (command.CanRun(userCommand))
                    {
                        WriteLine(command.GetHelp());
                        command.Run(userCommand,ref isExit);
                    }
                }
            } while (!isExit);

        }
    }
}
