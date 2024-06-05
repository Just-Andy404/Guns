using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player soldier = new Player("Andrii");

            Weapon pistol = new Pistol("Desert Eagle");
            Weapon automata = new automata("M32");
            Weapon grenadeLauncher = new GrenadeLauncher("RPG");

            soldier.UseWeapon(pistol);
            soldier.UseWeapon(automata);
            soldier.UseWeapon(grenadeLauncher);

            soldier.ReloadWeapon(pistol as IReloadable);
            soldier.ReloadWeapon(automata as IReloadable);

            soldier.ExplodeWeapon(grenadeLauncher as IExplodable);

            Console.ReadKey();
        }
    }
}
