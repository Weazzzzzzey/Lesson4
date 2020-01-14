using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SavarankiskiDarbai
{
    public class NamuDarbai
    {
        public void TipoF()
        {

            int breikas = Convert.ToInt32(Console.ReadLine());
            int ats = 0;
            if (breikas > 0)
            {

                for (int i = 0; i <= breikas; i++)
                {
                    ats = ats + i;
                }
            }
            else
            {
                for (int i = 0; i >= breikas; i--)
                {
                    ats = ats + i;
                }
            }
            //Console.WriteLine(breikas);
            Console.WriteLine(ats);
            Console.ReadKey();
        }

        public void Lyginis()
        {

            int breikas = Convert.ToInt32(Console.ReadLine());
            char symb = ',';

            if (breikas > 0)
            {

                for (int i = 0; i <= breikas; i++)
                {
                    if (i % 2 == 0)
                    {
                        if (i + 1 == breikas) symb = '.';
                        Console.Write($"{i}{symb}");
                    }
                }
            }
            else
            {
                for (int i = 0; i >= breikas; i--)
                {
                    if (i % 2 == 0)
                    {
                        if (i - 1 == breikas) symb = '.';
                        Console.Write($"{i}{symb}", i);
                    }
                }
            }
            Console.ReadLine();
        }

        public void Vertikalas()
        {

            string vertimas = "Olimpines zaidynes 2020, Tokijas";

            for (int i = vertimas.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(vertimas[i]);
            }


            Console.ReadKey();
        }

        public void neverEnd()
        {

            while (true)
            {

                Console.WriteLine("Iveskite skaiciu, kurio daugybos lentele bus iskaciuota.");
                int sk = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine($"{sk}*{i}={i * sk}");
                }
                Console.WriteLine("Ar norite baigti? Rasykite: Ne");
                if (string.Equals("Ne", Console.ReadLine()))
                {
                    Console.WriteLine("Programa baigta");
                    break;
                }
                Console.WriteLine("Programa tesis toliau..");
            }

            Console.ReadKey();
        }

        public void Baras()
        {
            int IvestasSk = Convert.ToInt32(Console.ReadLine());
            int ats = 0;
            Console.Clear();

            decimal BarP = 100m / IvestasSk;

            decimal Procesas = BarP;

            Console.WriteLine("                                                                                                      ╔════════╗   ");
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════╣ - ?  X ╠═╗");
            Console.WriteLine("║                                                                                                     ╚════════╝ ║");
            Console.WriteLine("║        ┌─────────────────────────────────────────────────────────────────────────────────────────────────────┐ ║");
            Console.WriteLine("║        │                                                                                                     │ ║");
            Console.WriteLine("║        └─────────────────────────────────────────────────────────────────────────────────────────────────────┘ ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");


            for (int i = 1; i <= IvestasSk; i++)
            {
                ats = ats + i;
                Thread.Sleep(100);

                int poslinkis = 10;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(10, 2);
                Console.WriteLine("Apaskaiciuota suma: {0}, skaiciaus {1}", ats, IvestasSk);
                Console.SetCursorPosition(3, 4);
                Console.WriteLine("{0}%", Math.Round(Procesas));
                Console.SetCursorPosition(10, 4);
                Console.BackgroundColor = ConsoleColor.Green;
                int pabaiga = 0;
                for (int j = 0; j <= Procesas; j++)
                {
                    pabaiga = j;
                    Console.Write("▐");
                }
                if(pabaiga == 99)
                {
                    Console.Write("▐");
                }
                Procesas = Procesas + BarP;
            }
            
            Console.ReadKey();
        }

        public void piramide()
        {

            Console.WriteLine("Kokio dydzio bus piramide?: ");
            int eilutes = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            string symb = "* ";
            int consolesC = (Console.WindowWidth - symb.Length) / 2;
            //Console.SetCursorPosition((Console.WindowWidth - symb.Length) / 2, Console.CursorTop);

            for (int i = 0; i < eilutes; i++)
            {
                Thread.Sleep(100);
                Console.SetCursorPosition(consolesC - i, i);
                for (int j = 0; j < 1 + i; j++)
                {
                    Console.Write(symb);
                }
            }
            Console.ReadLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            NamuDarbai D1 = new NamuDarbai();
            //D1.TipoF();
            //D1.Lyginis();
            D1.Baras();
        }
    }
}
