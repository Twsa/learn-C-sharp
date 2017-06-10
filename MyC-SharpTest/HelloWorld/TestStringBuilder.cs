using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class TestStringBuilder
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        //Create a string composed of numbers 0 - 9 
        
        public void StringBuilderTest()
        {
            for (int i = 0; i < 10; i++)
            {
                sb.Append(i.ToString());
            }
            System.Console.WriteLine(sb);          //displays 0123456789

            // Copy one character of the string (not possible with a System.String)
            sb[0] = sb[9];

            System.Console.WriteLine(sb);

            System.Console.ReadLine();
        }
    }
}
