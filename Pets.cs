using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegistry
{
    abstract class Pets : Animal
    {
        protected Pets(string name, string kind, DateTime birthday, List<string> commands)
            : base(name, kind, birthday, commands) { }
        
    }
}
