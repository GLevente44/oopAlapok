using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpAlapok
{
    internal class Program
    {

        public class Szemely
        {
            public string nev = "Levi";
            public int kor = 1000;
        }

        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely();
            Console.WriteLine($"A tanuló neve: {tanulo1.nev} és {tanulo1.kor} éves");





        }
    }
}
