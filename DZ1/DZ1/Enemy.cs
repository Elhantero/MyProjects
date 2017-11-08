using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    public abstract class Enemy
    {
        private int Power;

        public Enemy(string name, short health)
        {
            this.Name = name;
            this.Health = health;
            this.Power = health / 10;
        }

        public virtual string Name { get; set; }
        public virtual short Health { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name = {Name}  Health = {Health} Power = {Power}");
        }
    }
}
