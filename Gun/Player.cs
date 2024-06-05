using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun
{
    internal class Player
    {
        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public void UseWeapon(Weapon weapon)
        {
            weapon.Attack();
        }

        public void ReloadWeapon(IReloadable reloadable)
        {
            reloadable.Reload();
        }

        public void ExplodeWeapon(IExplodable explodable)
        {
            explodable.Explode();
        }
    }

}
