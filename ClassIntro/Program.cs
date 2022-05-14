using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Selim Koc";
            kurs2.IzlenmeOranı = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Eser eser";
            kurs3.IzlenmeOranı = 62;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "how to become king";
            kurs4.Egitmen = "Melih HOPA";
            kurs4.IzlenmeOranı = 100;

            //Console.Write(kurs1.KursAdi + " " + kurs1.Egitmen + " " + 
            //    " " + kurs1.IzlenmeOranı);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi +" : "+ kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOranı { get; set; }
    }
}