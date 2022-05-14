using System;

namespace Matematiko
{
     class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();

            dortIslem.Topla(5, 6);
            dortIslem.Topla(15, 36);
            dortIslem.Topla(25, 6);
            dortIslem.Topla(5, 16);
            Console.ReadLine(); 
        }
    }
}
