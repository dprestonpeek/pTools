using System;
using System.Collections.Generic;
using System.Text;

namespace pWorkTimer
{
    public class Help
    {
        public static string GetHelp()
        {
            string help = "\npWorkTimer v3.4.24\n\n";
            help += "+/-\t Add or Subtract time you've already worked today (Enter a number 1-8 hours or a number > 8 minutes).\n";
            help += "1-5\t View Hours worked on a given day (Enter a number 1-5).\n";
            help += " s\t View daily start times for the week.\n";
            help += " t\t View the projected end time for your shift today.\n";
            help += " w\t View elapsed and remaining work time for the week.\n";
            help += " b\t View the amount of break time taken today.\n";
            help += " h\t Print this help page.\n";
            help += " m\t View time history for past weeks.\n";
            help += " o\t Log PTO for the week (to ensure time elapsed and projected end time are correct).\n";
            help += " i\t Open the plain text data file used to store info for this program.\n";
            help += " l\t Open the error log file (do this after an error to get more info or to submit a report).\n";
            help += " c\t Clear the message currently displayed beneath your Time Elapsed and Time Left\n";

            return help;
        }
    }
}
