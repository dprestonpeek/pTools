using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pScript
{
    internal class Features
    {
        public static Features Instance;
        public static bool pToggle;

        public static bool ScriptHasFeatures(string commandText)
        {
            pToggle = CheckForpToggle(commandText);
            return pToggle;
        }

        public static bool CheckForpToggle(string commandText)
        {
            bool haspToggle = false;
            if (commandText.Contains("::pToggle"))
            {
                haspToggle = true;
            }
            return haspToggle;
        }
    }
}
