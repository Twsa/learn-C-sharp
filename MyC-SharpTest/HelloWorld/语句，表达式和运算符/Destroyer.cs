using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//终结器 析构函数
//终结器的表达式主体定义通常包含清理语句，例如释放非托管资源的语句。
//下面的示例定义了一个终结器，该终结器使用表达式主体定义来指示已调用该终结器。
namespace HelloWorld
{
    class Destroyer
    {
        public override string ToString() => GetType().Name;

        ~Destroyer()=>Console.WriteLine($"The {ToString()} destructor is executing.");
    }
}
