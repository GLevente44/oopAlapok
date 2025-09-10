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
            private string nev;
            private int kor;

            public string Nev { 

                get { return nev; } 
                set { nev = value; }
            
            }

            public int Kor
            {

                get { return Kor; }
                set { Kor = value; }

            }

            public override string ToString()
            {
                return $"A személy neve {nev} életkora: {kor}";
            }



            //public Szemely(string Nev, int Kor)
            //{
            //    nev = Nev;
            //    kor = Kor;
            //}

            //public string Kiir()
            //{
            //    return $"A tanuló neve: {nev} és {kor} éves";

            //}
        }

        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely();
            tanulo1.Nev = "Gábor";
            tanulo1.Kor = 20;

            Console.WriteLine(tanulo1);  
            //Szemely tanulo1 = new Szemely("Jani",55);
            //Console.WriteLine(tanulo1.Kiir());
            //Szemely tanulo2 = new Szemely("Ildi", 45);
            //Console.WriteLine(tanulo2.Kiir());


        }
    }
}
