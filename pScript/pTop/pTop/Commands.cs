using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pScript
{
    public class Command
    {
        public string displayText;
        public string commandText;
        public bool togglable;
        public bool isOn;

        public Command(string displayText, string commandText, bool togglable)
        {
            this.displayText = displayText;
            this.commandText = commandText;
            this.togglable = togglable;
            this.isOn = false;
        }
    }

    public class Commands
    {
        public static List<Command> commandList = new List<Command>();

        static string scriptFile = "script.bat";

        public static Command GetCommand(string displayText)
        {
            foreach (Command cmd in commandList)
            {
                if (cmd.displayText.Equals(displayText))
                {
                    return cmd;
                }
            }
            return null;
        }
        
        
        public static void FireCommandByString(string commandStr)
        {
            foreach (Command command in commandList)
            {
                string displayName = command.displayText;
                if (displayName == commandStr)
                {
                    //Do command here
                    FireCommand(displayName);
                }
            }
        }


        private static void FireCommand(string commandName)
        {
            foreach (Command cmd in commandList)
            {
                if (cmd.displayText.Equals(commandName))
                {
                    //Run any features
                    if (Features.ScriptHasFeatures(cmd.commandText))
                    {
                        cmd.isOn = !cmd.isOn;
                    }
                    File.WriteAllText(scriptFile, cmd.commandText);
                    ProcessStartInfo p = new ProcessStartInfo();
                    p.FileName = "CMD.exe";
                    p.Arguments = "/c " + scriptFile;
                    Process.Start(p);
                }
            }
        }
    }
}
