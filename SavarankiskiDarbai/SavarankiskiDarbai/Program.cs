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
        

    }

    
    class Program
    {
        static void Main(string[] args)
        {
            NamuDarbai D1 = new NamuDarbai();
            D1.TipoF();
        }
    }
}
