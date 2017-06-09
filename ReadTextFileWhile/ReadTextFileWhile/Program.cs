using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadTextFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                StreamReader myReader = new StreamReader("Values.txt");
                string line = "";

                while (line != null)
                {
                    line = myReader.ReadLine();
                    string myStr = line;
                    if (line != null)
                        Console.WriteLine(myStr);
                }
                myReader.Close();
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Could't find the file, Are you sure the DIRECTORY exists?");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Couldn't find the file , Are you sure you're lookiing for the correct file?");
            }

            catch (Exception e)
            {
                Console.WriteLine("Somthing didn't quite work correctly: {0}",e.Message);
            }
            finally
            {
                //Perform any cleanup to roll back the data or close connections
                //to files,database,network,etc.
            }
            Console.ReadLine();
        }
    }
}
