using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun
{
    internal class Pistol : Weapon, IReloadable
    {
        public Pistol(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("Bang!");
        }

        public void Reload()
        {
            Console.WriteLine($"{Name} reloads.");
        }
    }

}
