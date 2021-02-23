using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEngine.Text;

namespace TextEngineKonsol1
{
    class Program
    {
        static void Main(string[] args)
        {

            TextEvulator textEvulator = new TextEvulator("[BGCOLOR=WHITE][COLOR=RED]Kırmızı[/COLOR] [COLOR=BLUE]Mavi[/COLOR][/BGCOLOR]   " + 
                "[BGCOLOR=green][COLOR=white]arka plan yeşil, yazı beyaz[/COLOR][/BGCOLOR]");
            textEvulator.LeftTag = '[';
            textEvulator.RightTag = ']';

            //Diğer varsayılan evulatörlerin işlevlerini ve ayarlamalarını temizliyoruz.
            textEvulator.TagInfos.Clear();
            textEvulator.EvulatorTypes.Clear();
            //color tagının evulatörünü atadık.
            //COLOR taglarını yakalar.
            textEvulator.EvulatorTypes["color"] = typeof(ColorEvulator);
            //BGCOLOR taglarını yakalar.
            textEvulator.EvulatorTypes["bgcolor"] = typeof(BGColorEvulator);
            //Tag içerisindeki metinleri yakalar.
            textEvulator.EvulatorTypes.Text = typeof(ConsoleTextEvulator);
            //Girilen metni ayrıştırdık.
            textEvulator.Parse();
            //Evulate işlemini başlattık.
            textEvulator.Elements.EvulateValue();
           

            //Alt satır ekledik.
            Console.WriteLine();
            //Tüm elemanları temizledik.
            textEvulator.Elements.SubElements.Clear();
            //Metni değiştirdik.
            textEvulator.Text = "[COLOR=RED]Cyber[/COLOR]-[COLOR=GREEN]Warrior[/COLOR]";
            //Tekrar parse işlemini başlattık.
            textEvulator.Parse();
            //Evulate işlemini başlattık.
            textEvulator.Elements.EvulateValue();


            //Konsolun kapanmasını engelledik.
            Console.Read();

        }
    }
}
