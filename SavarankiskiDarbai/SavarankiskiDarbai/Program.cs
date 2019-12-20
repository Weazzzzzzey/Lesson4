using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    if(i%2 == 0)
                    {
                        if (i+1 == breikas) symb = '.';
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
                        Console.Write($"{i}{symb}",i);
                    }
                }
            }
            Console.ReadLine();
        }

        public void Vertikalas()
        {

            string vertimas = "Olimpines zaidynes 2020, Tokijas";

            for (int i = vertimas.Length-1; i >= 0; i--)
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
                for (int i = 0; i<11; i++)
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


    }

    
    class Program
    {
        static void Main(string[] args)
        {
            NamuDarbai D1 = new NamuDarbai();
            //D1.TipoF();
            //D1.Lyginis();
            D1.neverEnd();
        }
    }
}
