using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEngineKonsol1
{
   public static class Utils
    {
        public static ConsoleColor StringToConsoleColor(string colorName, ConsoleColor defaultColor = ConsoleColor.Gray)
        {
            ConsoleColor color;
            //Girilen metni ConsoleColor enum dizisi ile karşılaştırıyoruz.
            if (!Enum.TryParse(colorName, true, out color))
            {
                //Renk ismi ile listedeki uyuşuyor ise bu kısma gelecek.
                return defaultColor;
            }
            return color;
        }
    }
}
