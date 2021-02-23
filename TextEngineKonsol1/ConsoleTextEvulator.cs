using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEngine.Evulator;
using TextEngine.Text;

namespace TextEngineKonsol1
{
    public class ConsoleTextEvulator : BaseEvulator
    {
        public override TextEvulateResult Render(TextElement tag, object vars)
        {
            Console.Write(tag.Value);
            return null;
        }
    }
}
