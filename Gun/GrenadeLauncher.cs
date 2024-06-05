using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun
{
    internal class GrenadeLauncher : Weapon, IExplodable
    {
        public GrenadeLauncher(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("Boom !!!");
        }

        public void Explode()
        {
            Console.WriteLine($"{Name} reloaded.");
        }
    }

}
