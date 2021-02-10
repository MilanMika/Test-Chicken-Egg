using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_chicken_egg
{
    class Egg
    {
        bool born = false;
        Func<IBird> create;

        public Egg(Func<IBird> createBird)
        {
            create = createBird;
        }

        public IBird Hatch()
        {
            if (!born)
            {
                Console.WriteLine("It's Alive!");
                born = true;
                return create();
            }
            else
            {
                Console.WriteLine("Egg already hatched");
            }

            return null;
        }
    }
}
