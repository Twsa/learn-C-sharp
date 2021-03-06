﻿using System;
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
            //StringFormat msg = new StringFormat();
            //msg.ShowInfo();
            //msg.FormatString();

            //五、使用StringBuilder 快速创建字符串
            //TestStringBuilder stringBuilt = new TestStringBuilder();
            //stringBuilt.StringBuilderTest();

            //六、字符串、扩展方法和LINQ
            //1、查询文本块
            //1）、如何：对某个词在字符串中出现得次数进行计数（LINQ）(C#),
            //演示如何使用LINQ进行简单的文本查询
            //CountWords testCount = new CountWords();
            //testCount.CountTest();

            //如何：查询包含一组指定词语的句子（LINQ）(C#),
            //演示如何在任意边界上拆分文本文件以及如何针对每个部分执行查询
            //FindSentence sentenceFindTest = new FindSentence();
            //sentenceFindTest.SentencFind();

            //如何：将 LINQ 查询与正则表达式合并 (C#)
            //演示如何在 LINQ 查询中使用正则表达式，以便对筛选的查询结果进行复杂的模式匹配。

            //QueryWithRegEx queryWithEegExTest = new QueryWithRegEx();

            //queryWithEegExTest.RegEx();

            //Expression-bodied 成员（C# 编程指南）
            //Person expression_bodiedTest = new Person("Twsa","Liu");
            //expression_bodiedTest.DisplsyName();
            //构造函数中的
            //Location location = new Location("Twsa Liu");
            //location.Name = 5.ToString();

            //匿名函数
            //Delegate delegateTest = new Delegate();
            //delegateTest.Test();

            //如何：在查询中使用 Lambda 表达式
            SimpleLambda simpleLambdaTest = new SimpleLambda();
            simpleLambdaTest.Test();

            Console.ReadLine();
        }
    }
}
