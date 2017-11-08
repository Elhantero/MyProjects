using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    public class EnemyHard :Enemy, IManual
    {
        public EnemyHard():this("BlueElf",200)
        {
        }

        public EnemyHard(string name, short health) : base(name, health)
        {
        }

        public void ShowManual()
        {
            Console.WriteLine("This is the more stronger enemy");
        }

    }
}
