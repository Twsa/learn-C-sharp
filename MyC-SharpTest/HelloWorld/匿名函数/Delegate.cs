using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Delegate //委托
    {
        delegate void TestDelegate(string s);
        static void M(string s)
        {
            Console.WriteLine(s);
        }
        
        public void Test()
        {
            // C# 3.0 A delegate can be initilized with 
            // a lambda expression.The lamba also takes a string
            // as an input paramter (x). The type of x is inferred by compiler
            TestDelegate testDelC = (x) => { Console.WriteLine(x); };

            //Invoke the delegate
            testDelC("Hello,every one.");

            //Keep console window open in debug mode
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
