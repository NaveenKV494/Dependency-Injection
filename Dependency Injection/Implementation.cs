using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dependency_Injection.Interfaces;

namespace Dependency_Injection
{
    public class Implementation
    {
        public class Transformer : ITransformer
        {
            private readonly IGun _gun;
            private readonly ISword _sword;

            public Transformer(IGun gun, ISword sword)
            {
                _gun = gun;
                _sword = sword;
            }

            public void Attack()
            {
                Console.WriteLine("Transformer attacks with its weapons:");
                _gun.Shoot();
                _sword.Slash();
            }
        }

        public class LaserGun : IGun
        {
            public void Shoot()
            {
                Console.WriteLine("Laser gun fires lasers!");
            }
        }

        public class EnergySword : ISword
        {
            public void Slash()
            {
                Console.WriteLine("Energy sword slashes through enemies!");
            }
        }

    }
}
