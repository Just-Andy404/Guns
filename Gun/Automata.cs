using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun
{
    internal class automata : Weapon, IReloadable
    {
        public automata(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("Trr, trr, trr, trr!");
        }

        public void Reload()
        {
            Console.WriteLine($"{Name} reloads.");
        }
    }

}
