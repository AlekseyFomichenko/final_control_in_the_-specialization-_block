using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PetRegistry
{
    public abstract class Animal
    {
        protected int id;
        protected string name;
        protected string kind;
        protected DateTime birthday;
        protected List<string> commands;

        public int Id { get; }
        public string Name 
        { 
            get => name;
            set 
            {
                if (value.Equals(string.Empty))
                {
                    throw new ArgumentNullException(nameof(value), "Пустое имя недопустимо");
                }
                name = value;
            } 
        }
        public DateTime Birthday
        {
            get => birthday;
            set
            {
                if (value < DateTime.Parse("24.04.1974") || value > DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        "Недопустимый диапазон");
                }
                birthday = value;
            }
        }
        public List<string> Commands { get; set; }
        public string Kind { get; }

        public Animal(string name, string kind, DateTime birthday, List<string> commands)
        {
            id = new Random().Next(100000);
            Name = name;
            Kind = kind;
            Birthday = birthday;
            Commands = commands;
        }

        public void ShowCommands()
        {
            foreach (var command in commands)
            {
                Console.WriteLine(command);
            }
        }

        public void AddCommand(string command)
        {
            Commands.Add(command);
        }
    }
}
