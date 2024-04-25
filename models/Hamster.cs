using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegistry.models
{
    internal class Hamster : Pets
    {
        public Hamster(string name, DateTime birthday, List<string> commands)
            : base(name, Animals.Hamster.ToString(), birthday, commands)
        {
        }
    }
}
