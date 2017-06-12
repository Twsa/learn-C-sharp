using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//在查询中使用Lambda
namespace HelloWorld
{
    class SimpleLambda
    {
        public void Test()
        {
            // Data source
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            // The call to Count forces iteration of the source
            int highScoreCount = scores.Where(n => n > 80).Count();

            Console.WriteLine("{0} scores are greater than 80",highScoreCount);

        }
    } 
}
