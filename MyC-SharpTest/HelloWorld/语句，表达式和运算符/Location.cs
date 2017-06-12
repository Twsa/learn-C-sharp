using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Expression-bodied在构造函数中的使用
namespace HelloWorld
{
    class Location
    {
        private string locationName;

        public Location(string name)=>locationName=name;

        public string Name
        {
            get => locationName;
            set => locationName = value;
        }
    }
}
