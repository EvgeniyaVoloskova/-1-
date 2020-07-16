using System;
using System.Collections.Generic;
using System.Text;

namespace ДЗ_с_командой.Commands
{
    interface CommandInterface
    {
        string GetMenuRow();
        string GetHelp();
        bool CanRun(string userCommand);
        void Run(string userCommand,ref bool isExit);

    }
}
