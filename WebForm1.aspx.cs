using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bootson
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_OnClick(object sender, EventArgs e)
        {

            string metin1 = sifrele.Text.ToString();
            Kripto1 acık = new Kripto1();
            string sifrelenecek = metin1;
            string a = acık.dongu(metin1);
            hazır.Text = a;
        }

        protected void Button2_OnClick(object sender, EventArgs e)
        {
            string metin1 = sifrele.Text.ToString();
            Kripto kapalı = new Kripto();
            string sifrelenecek = metin1;
            string a = kapalı.dongu2(metin1);
            hazır.Text = a;
        }
    }
    class Kripto
    {
       

        public string dongu2(string _metin)
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

            return cevrilmis;
        }

    }

    class Kripto1
    {


        public string dongu(string _sifrelenecek)
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
            return sifreli;

        }
    }
}


//namespace benim
//{
//    public partial class benim : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {

//        }

//        public void sifrelee(object sender, EventArgs e)
//        {
//            string metin1 = sifrele.Text.ToString();
//            Kripto1 acık = new Kripto1();



//            string sifrelenecek = metin1;
//            string a = acık.dongu(metin1);
//            Label1.Text = a;

//        }

//    }





//}
//class Kripto
//{
//    public void kapalıkey()
//    {
//        while (true)
//        {
//            Console.WriteLine("sifreli metni girin;");
//            string metin = Console.ReadLine();
//            dongu2(metin);
//        }
//    }

//    static void dongu2(string _metin)
//    {
//        Dictionary<short, string> sozluk1 = new Dictionary<short, string>
//            {
//                {12,"a" },
//                {82,"b" },
//                {90,"c" },
//                {52,"ç" },
//                {33,"d" },
//                {13,"e" },
//                {83,"f" },
//                {32,"g" },
//                {43,"ğ" },
//                {61,"h" },
//                {45,"ı" },
//                {53,"i" },
//                {25,"j" },
//                {18,"k" },
//                {11,"l" },
//                {27,"m" },
//                {29,"n" },
//                {98,"o" },
//                {65,"ö" },
//                {55,"p" },
//                {34,"r" },
//                {70,"s" },
//                {49,"ş" },
//                {31,"t" },
//                {78,"u" },
//                {40,"ü" },
//                {99,"v" },
//                {56,"y" },
//                {10,"z" },
//                {37," " },

//            };
//        int uzunluk = _metin.Length;
//        string cevrilmis = "";
//        for (int i = 0; i < uzunluk; i = i + 2)
//        {
//            string c = char.ToString(_metin[i]);
//            string c1 = char.ToString(_metin[i + 1]);
//            short c3 = Convert.ToInt16(c + c1);
//            cevrilmis += sozluk1[c3];

//        }
//        Console.WriteLine("girmis olduğunuz sfreli metnin cozumlenmis hali; {0}", cevrilmis);
//    }

//}

//class Kripto1
//{


//    public string dongu(string _sifrelenecek)
//    {


//        Dictionary<string, short> sozluk = new Dictionary<string, short>
//                {
//                    {"a",12 },
//                    {"b",82 },
//                    {"c",90 },
//                    {"ç",52 },
//                    {"d",33 },
//                    {"e",13 },
//                    {"f",83 },
//                    {"g",32 },
//                    {"ğ",43 },
//                    {"h",61 },
//                    {"ı",45 },
//                    {"i",53 },
//                    {"j",25 },
//                    {"k",18 },
//                    {"l",11 },
//                    {"m",27 },
//                    {"n",29 },
//                    {"o",98 },
//                    {"ö",65 },
//                    {"p",55 },
//                    {"r",34 },
//                    {"s",70 },
//                    {"ş",49 },
//                    {"t",31 },
//                    {"u",78 },
//                    {"ü",40 },
//                    {"v",99 },
//                    {"y",56 },
//                    {"z",10 },
//                    {" ",37 },

//                };
//        string sifreli = "";

//        for (int i = 0; i < _sifrelenecek.Length; i++)
//        {
//            string anlık = char.ToString(_sifrelenecek[i]);
//            string b = Convert.ToString(sozluk[anlık]);
//            sifreli += b;

//        }
//        return sifreli;

//    }
//}
//}