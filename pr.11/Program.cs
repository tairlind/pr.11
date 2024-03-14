using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Xml.Linq;

class Animal
{
    public string Name { get; set; }
    public bool IsHungry { get; set; }

public Animal(string name)
    {
        Name = name;
        IsHungry = true;
    }

    public void Eat()
    {
        if (IsHungry)
        {
            IsHungry = false;
            Console.WriteLine($"{Name} поел(а)");
            Console.WriteLine($"{Name} больше не ест");
        }
    }
}

class Program
{
    static void Main()
    {
        Animal[] animalsOnField = new Animal[4];
        while (true)
        {
            if (animalsOnField.Length < 4)
            {
                Console.Write("Введите имя нового животного: ");
                string newAnimalName = Console.ReadLine();
                Animal newAnimal = new Animal(newAnimalName);

                animalsOnField[animalsOnField.Length + 1] = newAnimal;
                Console.WriteLine($"{newAnimalName} появился(ась) на поляне.");
            }
            else
            {
                foreach (var animal in animalsOnField)
                {
                    if (animal.IsHungry)
                    {
                        animal.Eat();
                    }
                }
            }

            Console.Write("Желаете добавить еще одно животное? (yes/no): ");
            string action = Console.ReadLine();
            if (action.ToLower() != "yes")
            {
                break;
            }
        }
    }
}

class Animal
{
    def __init__(self, name): 
        self.name = name
        self.hungry = True


    def eat(self):
        self.hungry = False
        print(f"{self.name} поел(а)")
        print(f"{self.name} больше не ест")

animals_on_field = []

while True:
    if len(animals_on_field) < 4:
        new_animal_name = input("Введите имя нового животного: ")
        new_animal = Animal(new_animal_name)


        animals_on_field.append(new_animal)
        print(f"{new_animal_name} появился(ась) на поляне.")
    else:
        for animal in animals_on_field:
            if animal.hungry:
                animal.eat()


    action = input("Желаете добавить еще одно животное? (yes/no): ")
    if action.lower() != "yes":
        break
        }