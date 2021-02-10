using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_chicken_egg
{
    class Program
    {
        static void Main(string[] args)
        {
            var chicken1 = new Chicken();
            var egg = chicken1.Lay();
            var childChicken = egg.Hatch();
        }
    }
}
