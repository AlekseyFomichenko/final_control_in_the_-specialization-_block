using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegistry.models
{
    internal class Camel : PackAnimals
    {
        public Camel(string name, DateTime birthday, List<string> commands) 
            : base(name, Animals.Camel.ToString(), birthday, commands)
        {
        }
    }
}
