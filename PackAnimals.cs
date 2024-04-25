using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegistry
{
    public abstract class PackAnimals : Animal
    {
        protected PackAnimals(string name, string kind, DateTime birthday, List<string> commands)
            : base(name, kind, birthday, commands) { }
    }
}
