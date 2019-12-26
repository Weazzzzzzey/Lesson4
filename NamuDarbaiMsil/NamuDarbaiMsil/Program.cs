using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuDarbaiMsil
{
    
    public class CiklaiMail
    {

        public void Desimtukas()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Deividas {0}", i+1);
            }
        }

        public void DesimtukasNumb()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void NumbSum()
        {

            int Start = 10;
            int Pabaiga = 20;
            int Sum = 0;

            for (int i = Start; i < Pabaiga + 1; i++)
            {
                Sum = Sum + i; 
            }
            Console.WriteLine("Skaiciaus {0} ir {1} suma yra: {2}",Start,Pabaiga,Sum);
        }

        public void Simtukas()
        {

            const int iki = 100;

            for (int i = 0; i < iki + 1; i++)
            {
                if(i % 3 == 0)
                Console.WriteLine("Skaiciai dalijasi is 3 be liekanos: {0}",i);
            }
        }

        public void Trikampis()
        {

            const int iki = 5;
            Console.Clear();

            for (int i = 0; i < iki; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void Dlentele()
        {

            const int iki = 10+1;
            Console.Clear();

            for (int i = 1; i < iki; i++)
            {
                for (int j = 1; j < iki; j++)
                {
                    Console.Write("{0}*{1}={2} ", i,j,j*i);
                }
                Console.WriteLine();
            }
        }
    }

    public class Masyvai
    {

        public void Isvedimas()
        {
            int[] Arr = {1,2,3,4,5 };
            int Sum = 0;

            for (int i = 0; i < Arr.Length; i++)
            {
                Sum = Sum + Arr[i];
            }

            Console.WriteLine("Suma: {0}",Sum);

            foreach (var item in Arr)
            {
                Console.WriteLine(item);
            }

        }

        public void Raidinis()
        {
            string[] Arr = { "a", "b", "c","d","e"};


            foreach (var item in Arr)
            {
                Console.WriteLine(item);
            }

            for (int i = Arr.Length-1; i >= 0; i--)
            {
                Console.WriteLine(Arr[i]);
            }
        
        }

        public void Vardas()
        {
            string Vardas = "Deividas";

            for (int i = 0; i < Vardas.Length; i++)
            {
                Console.WriteLine(Vardas[i]);
            }

            for (int i = Vardas.Length-1; i >= 0; i--)
            {
                Console.WriteLine(Vardas[i]);
            }

        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {

            CiklaiMail Ciklas = new CiklaiMail();
            Masyvai Mas = new Masyvai();
            Mas.Vardas();
            //6 pradeti
            Console.ReadKey();

        }
    }
}
