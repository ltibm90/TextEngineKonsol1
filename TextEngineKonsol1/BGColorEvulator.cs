using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEngine.Evulator;
using TextEngine.Text;

namespace TextEngineKonsol1
{
    public class BGColorEvulator : BaseEvulator
    {
        //Bir önceki rengi hafıza alır.
        ConsoleColor upColor;
        public override TextEvulateResult Render(TextElement tag, object vars)
        {
            this.upColor = Console.BackgroundColor;
            Console.BackgroundColor = Utils.StringToConsoleColor(tag.TagAttrib);
            //DEPTHSCAN olarak dönüş yapılması, alt taglarında Evulate fonksiyonlarının çalıştırılmasını sağlar.
            return new TextEvulateResult() { Result = TextEvulateResultEnum.EVULATE_DEPTHSCAN };
        }
        public override void RenderFinish(TextElement tag, object vars)
        {

            //Tag işlemi bittiğinde eski renge geri çevirir.
            Console.BackgroundColor = this.upColor;
        }

    }
}
