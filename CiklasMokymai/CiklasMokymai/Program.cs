using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CiklasMokymai
{
    public class DienosDarbas4
    {
        public void Ciklas()
        {
            for (int i = 10-1;i>=0;i--)
            {
                Console.WriteLine("I reiksmes: {0}", i);
            }
            Console.ReadKey();
        }

        public void CharCiklas()
        {
            for (char i = 'A'; i <= 'z'; i++)
            {
                Console.WriteLine("I reiksmes: {0}", i);
            }
            Console.ReadKey();
        }

        public void arrejus()
        {
            string vardas = "C#kursas";

            for(int i = 0;i < vardas.Length; i++)
            {
                char current = vardas[i];
                Console.WriteLine(current);
            }
            Console.ReadKey();
        }

        public void progressBar()
        {
            for (int i = 0; i  < 50; i++)
            {
                Thread.Sleep(100);
                Console.Write("#");
            }
            Console.WriteLine();
            Console.WriteLine("Pabaiga");
        }

    }
    

    
    class Program
    {
        static void Main(string[] args)
        {
            DienosDarbas4 D1 = new DienosDarbas4();
            //D1.Ciklas();
            //D1.CharCiklas();
            //D1.arrejus();
            D1.progressBar();
        }
    }
}
