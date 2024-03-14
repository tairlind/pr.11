using System;

class Animal
{
    public string Name { get; set; }
    public bool IsEating { get; set; }

    public Animal(string name)
    {
        Name = name;
        IsEating = false;
    }

    public void Eat()
    {
        Console.WriteLine(Name + " is eating.");
        IsEating = true;
    }
}

class Program
{
    static void Main()
    {
        Animal[] herd = new Animal[7];
        for (int i = 0; i < 7; i++)
        {
            herd[i] = new Animal("Animal" + i);
        }

        int animalsEating = 0;
        while (animalsEating < 7)
        {
            Console.WriteLine("Animals currently eating:");
            for (int i = 0; i < 7; i++)
            {
                if (herd[i].IsEating)
                {
                    Console.WriteLine(herd[i].Name);
                }
            }

            Console.WriteLine("Enter the number of animals to let eat (1-4):");
            int numToFeed = int.Parse(Console.ReadLine());

            for (int i = 0; i < 7; i++)
            {
                if (numToFeed == 0)
                {
                    break;
                }
                if (!herd[i].IsEating)
                {
                    herd[i].Eat();
                    numToFeed--;
                }
            }

            animalsEating = 0;
            for (int i = 0; i < 7; i++)
            {
                if (herd[i].IsEating)
                {
                    animalsEating++;
                }
            }
        }

        Console.WriteLine("All animals have finished eating.");
    }
}