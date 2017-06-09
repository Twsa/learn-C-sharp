using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        //static public string GetName(int ID)
        //{
        //    if (ID < names.Length)
        //        return names[ID];
        //    else
        //        return String.Empty;
        //}
        //static private string[] names = { "Spencer", "Sally", "Doug" };

        //public struct CoOrds
        //{
        //    public int x, y;
        //    public CoOrds(int p1 , int p2)   //构造函数
        //    {
        //        x = p1;
        //        y = p2;
        //    }
        //}

        public enum FileMode
        {
            CreateNew,
            Create,
            Open,
            CpenOrCreeate,
            Truncate,
            Append
        }

        static void Main(string[] args)
        {
            /*
            //一、A Hello World! program in C#
           Console.WriteLine("Hello World!");

            // Keep the console windows open in debug mode
           Console.WriteLine("Press any key to exit.");
           Console.ReadLine();
           */

            /*
            // Display the number of command line arguments
            System.Console.WriteLine(args.Length);
            Console.ReadLine();
            */

            // 二、类型（C#编程指南）
            // 类型、变量和值
            /* int a = 5;
             int b = a + 2;   //OK

             bool test = true;

             //Error. Operator '+' cannot be applied to operands of type 'int' and 'bool'.
             //int c = a + test;
             */

            //在变量声明中指定类型
            /*
            // Declaration only;
            float temperation;
            string name;
            //MyClass myClass;

            //Declaration with initializers (four examples):
            char firstLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5 };
            var query = from item in source
                        where item < limit
                        select item;
             */

            /*
            //方法签名得使用
            for (int i = 0; i < names.Length; i++)
            {
                string nameISelected = GetName(i);
                Console.WriteLine(nameISelected);
            }
            Console.ReadLine();
            */

            /*
             * //值类型
            // Static method on type Byte
            byte b = Byte.Parse("123"); 
            Console.WriteLine(b);
            Console.ReadLine();

            byte num = 0xA;
            int i = 5;
            char c = 'Z';
            */

            /*
             * //struct 结构体参数
            CoOrds structData = new CoOrds(1,2);
            Console.WriteLine(structData.x.ToString()+','+ structData.y.ToString());
            Console.ReadLine();
            */

            //枚举类型

            /*
            //引用类型
            MyClass mc = new MyClass();
            MyClass mc2 = mc;

            // Declare and initialize an array of integers 
            int[] nums = { 1, 2, 3, 4, 5 };

            //Access an instance property of System.Array
            int len = nums.Length;
            */

            /*
            //文本值类型
            string s = "The answer is " + 5.ToString();
            //Outputs:"The answer is 5";
            Console.WriteLine(s);

            Type type = 12345.GetType();
            // Outputs: "System.Int32"
            Console.WriteLine(type);
            Console.ReadLine();
            */

            /*
            //泛型类型
            List<string> stringList = new List<string>();
            stringList.Add("String example");
            // compile time error adding a type other than string:
            //stringList.Add(4);
            stringList.Add("Twsa Liu");
            foreach (var item in stringList)
            {
                Console.WriteLine(item);

            }
            Console.ReadLine();
            */

            /*
            //三、阵列
            //数组 （C#编程指南）

            // Specify the data souces.
            int[] scores = new int[] { 97, 92, 81, 60 };

            //Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;
            //  Excute the query
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
            */

            //四、字符串
            StringFormat msg = new StringFormat();
            //msg.ShowInfo();
            msg.FormatString();
        }
    }
}
