using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//此示例演示如何在包含一组指定的词语的每个匹配项的文本文件中查找句子。 
//尽管此示例中的搜索词数组采用硬编码形式，但它也可在运行时以动态方式进行填充。
//在此示例中，查询将返回包含单词“Historically,”、“data,”和“integrated”的句子。 
namespace HelloWorld
{
    class FindSentence
    {
        public void SentencFind()
        {
            string text= @"Historically, the world of data and the world of objects " +
            @"have not been well integrated. Programmers work in C# or Visual Basic " +
            @"and also in SQL or XQuery. On the one side are concepts such as classes, " +
            @"objects, fields, inheritance, and .NET Framework APIs. On the other side " +
            @"are tables, columns, rows, nodes, and separate languages for dealing with " +
            @"them. Data types often require translation between the two worlds; there are " +
            @"different standard functions. Because the object world has no notion of query, a " +
            @"query can only be represented as a string without compile-time type checking or " +
            @"IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to " +
            @"objects in memory is often tedious and error-prone.";

            //Split the text block into array of sentences.
            string[] sentences = text.Split(new char[] { '.', '?', '!' });

            //Define the search terms.This list could also be dynamically populated at runtime
            string[] wordsToMatch = { "Historically", "data", "integrated" };

            //Find sentences that contain all the terms in wordsToMatch array
            // Note that the number of terms to match is not specified at compile time.
            var sentenceQuery = from sentence in sentences
                                let w = sentence.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' },
                                                               StringSplitOptions.RemoveEmptyEntries)
                                where w.Distinct().Intersect(wordsToMatch).Count() == wordsToMatch.Count()
                                //Distinct 各个单词比较区别，  Interect,交叉匹配到的单词，Count:交叉匹配到的单词的量
                                select sentence;

            //Execute the query.Note that you cna explicity type
            // the iteration variable here even though sentenceQuery
            // was implicity typed
            foreach (var item in sentenceQuery)
            {
                Console.WriteLine(item);
            }
            //Keep the Console windows open in debug mode
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
