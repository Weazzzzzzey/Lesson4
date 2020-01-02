using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandymams
{
    class Bandymai
    {
        public void Testavimas()
        {
            int x = 1;
            float y = 1.1f;
            short z = 1;

            float  heloo = 3.14f;

            char chrl = '9';
            int dv = (int)chrl;
            Console.WriteLine("{0}", dv);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Bandymai b = new Bandymai();
            b.Testavimas();
            Console.ReadKey();

        }
    }
}
