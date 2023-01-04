using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{

    class Pojadz
    {
        private string nazwa;
        private string vin;

        public void jedz()
        {
            Console.WriteLine("jade");
        }
        public void tankuj()
        {
            Console.WriteLine("tankuje");
        }
    }

    class Samochod : Pojadz
    {
        private string oc;
        public void Zaparkuj()
        {
            Console.WriteLine("Parkuje");
        }
    }

    class Motur : Pojadz
    {
        public void zalozKask()
        {
            Console.WriteLine("Zakladam kask");
        }
    }

    class Koparka : Pojadz
    {
        private string udt;

        public void kop()
        {
            Console.WriteLine("Kopie");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pojadz p = new Pojadz();
            Koparka k = new Koparka();
            k.kop();
            p.jedz();
        }
    }
}
