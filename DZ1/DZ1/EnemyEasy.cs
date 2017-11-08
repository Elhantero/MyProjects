using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    public class EasyEnemy : Enemy, IManual
    {
        public EasyEnemy() : this("GreenElf",150)
        {
        }

        public EasyEnemy(string name, short health) : base(name, health)
        {
        }

        public void ShowManual()
        {
            Console.WriteLine("This is the easieest enemy in a quest");
        }
    }
}
