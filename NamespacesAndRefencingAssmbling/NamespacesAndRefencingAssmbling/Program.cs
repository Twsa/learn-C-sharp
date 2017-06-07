using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabor;

namespace NamespacesAndRefencingAssmbling
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader myStreamReader = new StreamReader();
            Bob bob = new Bob();

            string html = bob.Lookup("https://github.com/Twsa");

            Console.WriteLine(html);
            Console.ReadLine();
        }
    }
}
