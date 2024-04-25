using PetRegistry.models;
using System;


namespace PetRegistry
{
    static class AnimalStorage
    {
        private static List<Animal> animals = new List<Animal>();

        public static List<Animal> AnimalList()
        {
            return animals;
        }
        public static void Add(Animal animal)
        {
            animals.Add(animal);
        }


    }
}
