using PetRegistry.models;
using System;

namespace PetRegistry
{
    internal class Menu
    {
        public void Run()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Реестр животных\n\nВведите нужную команду:\n" +
                    "1 - добавить животное\n" +
                    "2 - список команд конкретного животного\n" +
                    "3 - добавить команду животному\n" +
                    "4 - список животных\n" +
                    "5 - количество всех животных\n" +
                    "6 - выход из программы\n");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        AddAnimal();
                        break;
                    case 2:
                        Console.Write("Введите имя животного: ");
                        string nameInput = Console.ReadLine();

                        CommandList(nameInput);
                        break;
                    case 3:
                        Console.Write("Введите имя животного: ");
                        string nameInput2 = Console.ReadLine();

                        Console.Write("Введите команду: ");
                        string commandInput = Console.ReadLine();

                        AddCommand(nameInput2, commandInput);
                        break;
                    case 4:
                        for (int i = 0; i < AnimalStorage.AnimalList().Count; i++)
                        {
                            Console.WriteLine(AnimalStorage.AnimalList()[i]);
                        }
                        break;
                    case 5:
                        Console.WriteLine(AnimalStorage.AnimalList().Count);
                        break;
                    case 6:
                        Console.WriteLine("Выход из программы...");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Ошибка: команда не существует");
                        break;
                }
            }
        }

        private void AddAnimal()
        {
            Console.WriteLine("Какое животное хотите добавить:\n" +
                            "1 - Собака\n" +
                            "2 - Кот\n" +
                            "3 - Хомяк\n" +
                            "4 - Верблюд\n" +
                            "5 - Осёл\n" +
                            "6 - Лошадь\n");
            Animals kindInput = (Animals)int.Parse(Console.ReadLine());

            Console.WriteLine("Введите имя животного: ");
            string nameInput = Console.ReadLine();

            Console.WriteLine("Введите дату рождения: ");
            DateTime birthdayInput = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Знает ли какие-нибудь команды(если да: через запятую перечислите их, если нет: нажмите Enter)");
            string temp = Console.ReadLine();
            List<string> commandsInput = (temp.Split(',')).ToList();
            for (int i = 0; i < commandsInput.Count; i++)
            {
                _ = commandsInput[i].Trim();
            }

            switch (kindInput)
            {
                case (Animals)1:
                    AnimalStorage.Add( new Dog(nameInput, birthdayInput, commandsInput));
                    break;
                case (Animals)2:
                    AnimalStorage.Add(new Cat(nameInput, birthdayInput, commandsInput));
                    break;
                case (Animals)3:
                    AnimalStorage.Add(new Hamster(nameInput, birthdayInput, commandsInput));
                    break;
                case (Animals)4:
                    AnimalStorage.Add(new Camel(nameInput, birthdayInput, commandsInput));
                    break;
                case (Animals)5:
                    AnimalStorage.Add(new Donkey(nameInput, birthdayInput, commandsInput));
                    break;
                case (Animals)6:
                    AnimalStorage.Add(new Horse(nameInput, birthdayInput, commandsInput));
                    break;
                default:
                    break;
            }

            //foreach (var item in Enum.GetNames<Animals>())
            //{
            //    Console.WriteLine($"{0} - {item}", Enum.GetValues(typeof(Animals)),item);
            //}
        }

        private void CommandList(string nameInput)
        {
            for (int i = 0; i < AnimalStorage.AnimalList().Count; i++)
            {
                if (AnimalStorage.AnimalList()[i].Name == nameInput)
                {
                    AnimalStorage.AnimalList()[i].Commands.ForEach(Console.WriteLine);
                }
            }
        }

        private void AddCommand(string name, string command)
        {
            foreach (var animal in AnimalStorage.AnimalList())
            {
                if (animal.Name == name)
                {
                    animal.AddCommand(command);
                }
            }
        }
    }
}
