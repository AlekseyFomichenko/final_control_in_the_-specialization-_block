using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegistry.models
{
    internal class Cat : Pets
    {
        public Cat(string name, DateTime birthday, List<string> commands)
            : base(name, Animals.Cat.ToString(), birthday, commands)
        {
        }
    }
}
