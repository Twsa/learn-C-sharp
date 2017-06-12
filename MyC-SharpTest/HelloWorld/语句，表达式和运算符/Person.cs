using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld //语句_表达式和运算符
{
    class Person
    {
        private string fname;
        private string lname;
        
        public Person(string firstName,string lastName)
        {
            fname = firstName;
            lname = lastName;
        }

        public override string ToString() => $"{fname} {lname}".Trim();
        public void DisplsyName() => Console.WriteLine(ToString());
    }
}
