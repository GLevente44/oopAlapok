using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpAlapok
{
    internal class Program
    {

        public class Szemely
        {
            protected string nev;
            private int kor;

            public Szemely(string name, int age) 
            {
                nev = name;
                kor = age;
            }


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
        
        public class Hallgato : Szemely
        {
            private string neptunKod;

            public Hallgato(string name, int age, string neptuncode) : base(name, age) 
            {
                NeptuKod = neptuncode;
            }

            public string NeptuKod
            {
                get { return neptunKod; }
                set {
                    if (value.Length <= 6)
                    {
                        neptunKod = value; 
                    }
                    else
                    {
                        Console.WriteLine("Nem megfelelő hosszúság!");
                    }
                }
            }
            public override string ToString()
            {
                return $"A hallgató neve: {nev} a nepunkódja: {neptunKod}";
            }   
            
            
        }

        public class Dolgozo : Szemely
        {
            public int ber;
            public Dolgozo(string name, int age, int salary) : base(name, age) 
            {
                ber = salary;
                    
            }


        }


        static void Main(string[] args)
        {
            //Szemely tanulo1 = new Szemely();
            //tanulo1.Nev = "Gábor";
            //tanulo1.Kor = 20;
            //Console.WriteLine(tanulo1);

            //Console.WriteLine("--------------------");

            Bankszamla bankszamla1 = new Bankszamla();
            bankszamla1.Egyenleg = -5700;
            Console.WriteLine(bankszamla1.Egyenleg);

            //Console.WriteLine("-----------------------");

            //Hallgato hallgato1 = new Hallgato();
            //hallgato1.NeptuKod = "asdasd";
            //Console.WriteLine(hallgato1.NeptuKod);

            //Console.WriteLine("-----------------------");

            List<Hallgato> hallgatok = new List<Hallgato>();

            //for (int i = 0; i < 2; i++)
            //{
            //    Hallgato hallgato = new Hallgato();
            //    Console.Write($"Kérem a(z) {i+1} hallgató nevét: ");
            //    hallgato.Nev = Console.ReadLine();
            //    Console.Write($"Kérem a(z) {i + 1} hallgató életkorát: ");
            //    hallgato.Kor = int.Parse(Console.ReadLine());
            //    Console.Write($"Kérem a(z) {i + 1} hallgató neptunkódját: ");
            //    hallgato.NeptuKod = Console.ReadLine();
            //    hallgatok.Add(hallgato);
            //}

            //foreach (var item in hallgatok)
            //{
            //    Console.WriteLine($"A hallgatók neve: {item.Nev}");
            //}

            Console.WriteLine("-----------------------");

            Hallgato hallgato1 = new Hallgato("Peti", 22, "HGJRIS");
            Console.WriteLine(hallgato1);

            Dolgozo dolgozo1 = new Dolgozo("Gábor", 34, 6800);
            Console.WriteLine(dolgozo1);

        }
    }
}
