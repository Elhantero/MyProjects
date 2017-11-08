using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create composition from 3 classes(1 parent - abstract, 2 - child). Parent class must have one or more field and one or more method
//2. Fill array(min. 3 items) type of abstract class using simple initialization(set element count)
//3. Display array to console using "for"
//4. Create interface and implement it in 2 child classes
//5. Fill array type of interface using object initializer
//6. Display array to console using "foreach"

namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy[] arr = new Enemy[]
            {
                new EasyEnemy(),
                new EasyEnemy(),
                new EnemyHard()
            };

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].ShowInfo();
            }

            IManual[] Iarr = new IManual[]
            {
                new EasyEnemy(),
                new EasyEnemy(),
                new EnemyHard()
            };

            foreach (var i in Iarr)
            {
                i.ShowManual();
            }

            Console.ReadKey();
        }

    }
}