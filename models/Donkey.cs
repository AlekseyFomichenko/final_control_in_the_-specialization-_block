using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegistry.models
{
    internal class Donkey : PackAnimals
    {
        public Donkey(string name, DateTime birthday, List<string> commands)
            : base(name, Animals.Donkey.ToString(), birthday, commands)
        {
        }
    }
}
