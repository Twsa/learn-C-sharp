using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class StringFormat
    {
        //Declare without initializing
        string message1;

        // Initialize to null
        string message2 = null;

        // Initialize as an empty string
        // Use the Empty constant instead of literal ""
        string message3 = System.String.Empty;

        //Initialize with a regular string literal
        string oldPath = "C:\\Users\\Twsa\\OneDrive\\Documents\\工程材料试卷_南昌航空大学";

        //Initialize with a verbatim string literal.
        public string newPath = @"C:\Users\Twsa\OneDrive\Documents\工程材料试卷_南昌航空大学";

        // Use System.String if you prefer
        System.String greeting = "Hello World";

        // In local variable (i.e within a method body)
        //you can use implicit typing
        //var temp = "I'm still a strongly-typed System.String!";

        // Use a const string to prevent 'message4' from
        // being using to store another string value.
        const string message4 = "You can't get rid of me";

        // Use the String constructor only when creating 
        // a string from a char*,char[],or sbyte*.See
        // System.String documentation for details.
        static char[] letters = { 'A', 'B', 'C' };
        string alphabet = new string(letters);

        //字符串对象不可变性
        //string s1 = "A string is more ";
        //string s2 = "than the sum of its chars";

        //创建了字符串得引用
        string s1 = "Hello";

        //常规和逐字字符串文本
        string columns = "Column 1\tColumn 2\tColumn 3";
        //Output:Column 1  Column 2  Column 3
        string rows = "Row 1\r\nRow 2\r\nRow 3\r\n";
        /*
         * Output:
           Row 1
           Row 2
           Row 3
         */
        string title = "\"The \u00C6olean Harp\", by Samuel Taylor Coleridge";
        string filePath = @"C:\Users\Twsa\OneDrive\Documents";
        //Output:C:\Users\Twsa\OneDrive\Documents

        string text = @"今天是我最开心得日子！。。。";
        string quote = @"His name was ""Twsa.""";//引述

        //格式化字符串
        public void FormatString()
        {
            /*
            // Get user input
            System.Console.WriteLine("Enter a number");
            string input = System.Console.ReadLine();

            //Convert the input string to an int
            int j;
            System.Int32.TryParse(input, out j);   //解析输入字符

            //Write a different string each iteration.
            string s;
            for (int i = 0; i < 10; i++)
            {
                // A simple format string with no alignment formatting
                s = System.String.Format("{0} times {1} = {2}", i, j, (i * j));
                System.Console.ReadLine();
            }
            */

            /*
            //子字符串
            string s3 = "Visual C# Express";
            System.Console.WriteLine(s3.Substring(7, 2));

            System.Console.WriteLine(s3.Replace("C#", "Basic"));


            int index = s3.IndexOf("C");
            System.Console.WriteLine(index);



            // Keep the console windows open in debug mode
            System.Console.ReadKey();
            */

            //访问单个字符串
            /*string s5 = "Printing backwards";
            for (int i = 0; i < s5.Length; i++)
            {
                System.Console.Write(s5[s5.Length - i - 1]);
            }
            //System.Console.WriteLine(s5);
            System.Console.ReadLine();
            */

            /*
            string questions = "hOW DOES mICROSOFT wORD ";
            System.Text.StringBuilder sb = new System.Text.StringBuilder(questions);
            sb.Append("DEAL WITH THE cAPS lOCK KEY?");

            for (int i = 0; i < sb.Length; i++)
            {
                if (System.Char.IsLower(sb[i]) == true)
                {
                    sb[i] = System.Char.ToUpper(sb[i]);
                }
                else if (System.Char.IsUpper(sb[i]) == true)
                    sb[i] = System.Char.ToLower(sb[i]);

            }
            //Store the new string.
            string corrented = sb.ToString();
            System.Console.WriteLine(corrented);
            System.Console.ReadLine();
            */

            /*
            //Null 字符串和空字符串
            //string s = String.Empty;
            string str = "hello";
            string nullStr = null;
            string emptyStr = String.Empty;

            string tempStr = str + nullStr;
            //Output of following line:hello
            Console.WriteLine(tempStr);

            bool b = (emptyStr == nullStr);
            //Output of the following line:False
            Console.WriteLine(b);

            // The following line creates a new empty string;
            string newStr = emptyStr + nullStr;

            //Null strings and empty strings behave differently.The following
            //two lines display 0.
            Console.WriteLine(emptyStr.Length);
            Console.WriteLine(newStr.Length);
            //The following line raises a NullReferenceException.
            //Console.WriteLine(nullStr.Length);

            // The null character can be displayed and counted ,like other chars
            string s1 = "\x0" + "abc";
            string s2 = "abc" + "\x0";  //空字符也占用一个字节得内存
            Console.WriteLine("*" + s1 + "*");
            Console.WriteLine("*" + s2 + "*");

            Console.WriteLine(s2.Length);
            */

            //使用StringBuilder 快速创建字符串

            Console.ReadLine();
        }

        public void ShowInfo()
        {
            // Concatenate s1 and s2.This actually creates a new
            //string object and stores it in s1.releasing the 
            // reference to the original object    
            //string s2 = s1;
            //s1 += "World";
            Console.WriteLine(quote);
            
            Console.ReadLine();

        }

    }
}
