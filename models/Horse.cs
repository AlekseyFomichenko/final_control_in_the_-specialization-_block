using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegistry.models
{
    internal class Horse : PackAnimals
    {
        public Horse(string name, DateTime birthday, List<string> commands)
            : base(name, Animals.Horse.ToString(), birthday, commands)
        {
        }
    }
}
