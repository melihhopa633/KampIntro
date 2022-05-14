using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {   
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Acıklama = "Amasya Elması";
            product1.StokAdeti = 2;

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Acıklama = "Diyarbakır karpuzu";
            product2.StokAdeti = 22;


            Product[] products = new Product[] { product1, product2 };

            foreach (var item in products)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Fiyati);
                Console.WriteLine(item.Acıklama);
                Console.WriteLine(item.StokAdeti);
                Console.WriteLine("***********************");
            }

            Console.WriteLine("----------Metotlar------------");

            // instance -- örneği
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            Console.WriteLine("Ikinci gun");

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,3);
            sepetManager.Ekle2("Armut", "Yeşil armut", 12,2);
            sepetManager.Ekle2("Armut", "Yeşil armut", 12,4);
            sepetManager.Ekle2("Armut", "Yeşil armut", 12,1);
        }
    }
}