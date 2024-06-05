using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun
{
    internal abstract class Weapon
    {
        public string Name { get; set; }
        public Weapon(string name)
        {
            Name = name;
        }
        public abstract void Attack();
    }
}
