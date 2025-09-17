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

                get { return kor; }
                set { kor = value; }

            }

            public override string ToString()
            {
                return $"A személy neve {nev} életkora: {kor}";
            }
        }

        public class Bankszamla
        {
            private int egyenleg;

            public int Egyenleg
            {
                get { return egyenleg; }
                set 
                {
                    if (value >= 0)
                    {
                        
                    egyenleg = value; 
                    }
                    else
                    {
                        Console.WriteLine("Az érték nem lehet negatív.");
                    }

                }
            }

            public void Betesz()
            {

            }

            public void Kivesz()
            {

            }


        }
        

        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely();
            tanulo1.Nev = "Gábor";
            tanulo1.Kor = 20;

            Console.WriteLine(tanulo1);  
         
            Bankszamla bankszamla1 = new Bankszamla();
            bankszamla1.Egyenleg = -5700;
            Console.WriteLine(bankszamla1.Egyenleg);

        }
    }
}
