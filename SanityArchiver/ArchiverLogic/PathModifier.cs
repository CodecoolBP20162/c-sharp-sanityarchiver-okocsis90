using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanityArchiverLogic
{
    public class PathModifier
    {
        public static string CreateSearchBarText(string text)
        {
            string result = text;
            try
            {
                int index = RemoveLastBackSlash(text).LastIndexOf(@"\");
                if (index >= 0)
                {
                    result = text.Substring(0, index + 1);
                }
                return result;
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }

        public static string RemoveLastBackSlash(string text)
        {
            string actualPath = text;
            if (actualPath.LastIndexOf(@"\") == actualPath.Length - 1)
            {
                actualPath = actualPath.Substring(0, actualPath.Length - 1);
            }
            return actualPath;
        }
    }
}
