using System;
using System.Collections.Generic;

namespace kripto
{
    class Program
    {
        static void Main(string[] args)
        {
            //acıkkey();

            Kripto kapalı = new Kripto();
            Kripto1 acik= new Kripto1();
            while (true)
            {
                Console.WriteLine("şifrelemek için '1' çevirmek için '0'" );
                string bust = Console.ReadLine();
                if (bust == "1")
                {
                    acik.acıkkey();
                }
                else if (bust=="0")
                {
                    kapalı.kapalıkey();
                }
                else
                {
                    Console.WriteLine("geçersizz giriş!");
                }

            }


        }

        class Kripto
        {
            public void kapalıkey()
            {
                while (true)
                {
                    Console.WriteLine("sifreli metni girin;");
                    string metin = Console.ReadLine();
                    dongu2(metin);
                }
            }

            static void dongu2(string _metin)
            {
                Dictionary<short, string> sozluk1 = new Dictionary<short, string>
            {
                {12,"a" },
                {82,"b" },
                {90,"c" },
                {52,"ç" },
                {33,"d" },
                {13,"e" },
                {83,"f" },
                {32,"g" },
                {43,"ğ" },
                {61,"h" },
                {45,"ı" },
                {53,"i" },
                {25,"j" },
                {18,"k" },
                {11,"l" },
                {27,"m" },
                {29,"n" },
                {98,"o" },
                {65,"ö" },
                {55,"p" },
                {34,"r" },
                {70,"s" },
                {49,"ş" },
                {31,"t" },
                {78,"u" },
                {40,"ü" },
                {99,"v" },
                {56,"y" },
                {10,"z" },
                {37," " },

            };
                int uzunluk = _metin.Length;
                string cevrilmis = "";
                for (int i = 0; i < uzunluk; i = i + 2)
                {
                    string c = char.ToString(_metin[i]);
                    string c1 = char.ToString(_metin[i + 1]);
                    short c3 = Convert.ToInt16(c + c1);
                    cevrilmis += sozluk1[c3];

                }
                Console.WriteLine("girmis olduğunuz sfreli metnin cozumlenmis hali; {0}", cevrilmis);
            }
           
        }

        class Kripto1
        {
            public void acıkkey()
            {

                while (true)
                {
                    Console.WriteLine("sifrelenecek metni girin:");
                    string sifrelenecek = Console.ReadLine();
                    dongu(sifrelenecek);
                }
            }

            static void dongu(string _sifrelenecek)
            {


                Dictionary<string, short> sozluk = new Dictionary<string, short>
                {
                    {"a",12 },
                    {"b",82 },
                    {"c",90 },
                    {"ç",52 },
                    {"d",33 },
                    {"e",13 },
                    {"f",83 },
                    {"g",32 },
                    {"ğ",43 },
                    {"h",61 },
                    {"ı",45 },
                    {"i",53 },
                    {"j",25 },
                    {"k",18 },
                    {"l",11 },
                    {"m",27 },
                    {"n",29 },
                    {"o",98 },
                    {"ö",65 },
                    {"p",55 },
                    {"r",34 },
                    {"s",70 },
                    {"ş",49 },
                    {"t",31 },
                    {"u",78 },
                    {"ü",40 },
                    {"v",99 },
                    {"y",56 },
                    {"z",10 },
                    {" ",37 },

                };
                string sifreli = "";

                for (int i = 0; i < _sifrelenecek.Length; i++)
                {
                    string anlık = char.ToString(_sifrelenecek[i]);
                    string b = Convert.ToString(sozluk[anlık]);
                    sifreli += b;

                }
                Console.WriteLine("girmis oldugunuz metnin sifreli hali: {0}", sifreli);

            }
        }

        
    }
}
