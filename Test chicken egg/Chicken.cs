using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_chicken_egg
{
    class Chicken : IBird
    {
        public Chicken()
        {
            Console.WriteLine("A chicken.");
        }
        public Egg Lay()
        {
            return new Egg(new Func<Chicken>(() => new Chicken()));
        }

        public void Speak()
        {
            Console.WriteLine("Bawk!");
        }
    }
}
