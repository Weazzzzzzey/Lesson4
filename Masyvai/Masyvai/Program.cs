using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masyvai
{
    public class Masyvai
    {
        public void MasyvasF()
        {

            string[] SavaitesD =
            {
                "Pirmadienis",
                "Antradienis",
                "Treciadienis",
                "Ketvirtadienis",
                "Penktadienis",
                "Sestadienis",
                "Sekmadienis"
            };

            SavaitesD[2] = "TRECIADIENIS";
            
            foreach(string diena in SavaitesD)
            {
                Console.WriteLine(diena);
            }

            for (int i = 0; i < SavaitesD.Length;i++)
            {
                Console.WriteLine(SavaitesD[i]);
            }
            Console.ReadKey();
        }


    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Masyvai M = new Masyvai();
            M.MasyvasF();
        }
    }
}
