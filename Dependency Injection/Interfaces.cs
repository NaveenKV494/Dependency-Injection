using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class Interfaces
    {
        public interface ITransformer
        {
            void Attack();
        }

        public interface IGun
        {
            void Shoot();
        }

        public interface ISword
        {
            void Slash();
        }

    }
}
