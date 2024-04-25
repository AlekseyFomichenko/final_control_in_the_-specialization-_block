using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegistry.models
{
    internal class Dog : Pets
    {
        public Dog(string name, DateTime birthday, List<string> commands)
            : base(name, Animals.Dog.ToString(), birthday, commands) { }
    }
}
