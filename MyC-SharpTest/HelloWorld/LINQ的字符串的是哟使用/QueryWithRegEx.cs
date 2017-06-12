using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.IO;


//此示例演示如何使用<xref:System.Text.RegularExpressions.Regex> 类在文本字符串中为更复杂的匹配创建正则表达式。
//通过 LINQ 查询可以轻松地准确筛选要用正则表达式搜索的文件，并对结果进行改良。 
namespace HelloWorld
{
    class QueryWithRegEx
    {
        public void RegEx()
        {
            //Modify this path as necessary so that it accesses your version Vistual Studio
            string startFolder = @"c:\program files (x86)\Microsoft Visual Studio 10.0\";


            // Take a snapshot of the file system
            IEnumerable<System.IO.FileInfo> fileList = GetFiles(startFolder);

            //Create the regular expression to find all things "Visual"
            System.Text.RegularExpressions.Regex searchTerm =
                 new System.Text.RegularExpressions.Regex(@"Visual (Basic|C#|C\+\+|J#|SourceSafe|Studio)");

            //Search the contents of each .htm file.
            // Remove the where clause to find even more matchedValue!
            // This query produces a list of filed where a match
            // was found ,and a list of matchValues in that file.
            //Note: Explict typing of "Match" in select clause.
            // This is required because MatchCollection is not a 
            // genertic IEnumerable collection
            var queryMatchingFiles =
                from file in fileList                 //设置文件查找范围 在设置的路经上
                where file.Extension == ".htm"        // 在设置的路径上上查找扩展名为“.htm”的文件
                let fileText = System.IO.File.ReadAllText(file.FullName)  //fileText为通过访问所设置路经上文件的全称进而访问文件的文本内容
                let matches = searchTerm.Matches(fileText)                //所查到的文本匹配的内容
                where matches.Count > 0                                   //此时存在文本匹配成功的选项
                select new
                {
                    name = file.FullName,
                    matchedValue = from System.Text.RegularExpressions.Match match in matches
                                   select match.Value
                };

            // Execute the query
            Console.WriteLine("The term \"{0}\" was found in:", searchTerm.ToString());

            foreach (var V in queryMatchingFiles)
            {
                // Trim the path a bit,then write
                // the file name in which a match was found 
                string s = V.name.Substring(startFolder.Length - 1);
                Console.WriteLine(s);

                //For this file,write out all the matching strings
                foreach (var v2 in V.matchedValue)
                {
                    Console.WriteLine(" " + v2);

                }

                //Keep the console windo open in debug mode
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }

        }

        //This method assumes that application has discovery
        // permission for all folder under the specification
        static IEnumerable<System.IO.FileInfo> GetFiles(string path)
        {
            if (!System.IO.Directory.Exists(path))
            throw new System.IO.DirectoryNotFoundException();

            string[] fileNames = null;
            List<System.IO.FileInfo> files = new List<System.IO.FileInfo>();

            //获得当前路经的所有的文件名
           
            fileNames = System.IO.Directory.GetFiles(path, "*.*", System.IO.SearchOption.AllDirectories);

            //将文件名加载到文件信息变量中
            foreach (string name in fileNames)
            {
                files.Add(new System.IO.FileInfo(name));
            }
            return files;

        }
    }
}
