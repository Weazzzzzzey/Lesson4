using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasyvoApvertimas
{ 
    public class NamuDarbai34 
    {
        public void Apvertimas()
        {
            string Sakinys = "Hello world my name is Central park";
            string[] MasZ = Sakinys.Split(' ');
            
            foreach(var a in MasZ.Reverse())
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
        
        public void Calck()
        {
            while (true)
            {
                Console.WriteLine("Iveskite du skaiciuss ir simboli");
                Console.WriteLine("1 skaicius: ");
                double Pirmas = double.Parse(Console.ReadLine());
                Console.WriteLine("2 skaicius: ");
                double Antras = double.Parse(Console.ReadLine());
                Console.WriteLine("ir somboli: ");
                string Symb = Console.ReadLine();

                Console.WriteLine("Atsakymas: ");
                
                if (Symb == "+") 
                    Console.WriteLine(Pirmas + Antras);
                if (Symb == "-")
                    Console.WriteLine(Pirmas - Antras);
                if (Symb == "*")
                    Console.WriteLine(Pirmas * Antras);
                if (Symb == "/")
                    Console.WriteLine(Pirmas / Antras);

                Console.WriteLine("Noredami baigti, rasykite: Baigti");
                if (string.Equals(Console.ReadLine(),"Baigti"))
                {
                    break;
                }
            }
            
        }
    
    
    }

   


    class Program
    {
        static void Main(string[] args)
        {
            NamuDarbai34 M = new NamuDarbai34();
            //M.Apvertimas();
            M.Calck();
        }
    }
}
