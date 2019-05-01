using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kald SigNoget for alle klasser som implementerer IDyr interface
            List<IDyr> DyreListe = new List<IDyr>
            {
                new Hund(),
                new Kat(),
                new Fugl()
            };

            DyreListe.ForEach(dyr => Console.WriteLine(dyr.SigNoget()));

        }
    }
}
