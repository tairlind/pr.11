using System;
using System.Collections.Generic;
class Animal
{
    public string name;
    public bool hungry;

    public Animal(string name)
    {
        this.name = name;
        this.hungry = true;
    }

    public void Eat()
    {
        this.hungry = false;
        Console.WriteLine($"{this.name} поел(а)");
        Console.WriteLine($"{this.name} больше не ест");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals_on_field = new List<Animal>();

        while (true)
        {
            if (animals_on_field.Count < 4)
            {
                Console.Write("Введите имя нового животного: ");
                string new_animal_name = Console.ReadLine();
                Animal new_animal = new Animal(new_animal_name);
                animals_on_field.Add(new_animal);
                Console.WriteLine($"{new_animal_name} появился(ась) на поляне.");
            }
            else
            {
                foreach (Animal animal in animals_on_field)
                {
                    if (animal.hungry)
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
