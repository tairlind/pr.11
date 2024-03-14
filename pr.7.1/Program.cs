using System;
using static System.Collections.Specialized.BitVector32;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Collections.Generic;

class Animal
{
    public string Name { get; set; }
    public int Hunger { get; set; }

    public Animal(string name)
    {
        Name = name;
        Hunger = 1;
    }

    public void Eat()
    {
        if (Hunger > 0)
        {
            Hunger--;
            Console.WriteLine($"{Name} питается. Осталось еще {Hunger} единиц еды.");
            
        }
        else
        {
            Console.WriteLine($"{Name} уже сыт и уходит с поляны.");
        }
    }
}

class Program
{
    static void Main()
    {
        Animal[] herd = new Animal[7];
        herd[0] = new Animal("Корова");
        herd[1] = new Animal("Овца");
        herd[2] = new Animal("Коза");
        herd[3] = new Animal("Свинья");
        herd[4] = new Animal("Лошадь");
        herd[5] = new Animal("Курица");
        herd[6] = new Animal("Утка");

        int counter = 0;
        while (counter < 7)
        {
            for (int i = 0; i < 7 && counter < 7; i++)
            {
                if (herd[i] != null)
                {
                    herd[i].Eat();
                    if (herd[i].Hunger == 0)
                    {
                        herd[i] = null;
                        counter++;
                    }
                }
            }
        }

        Console.WriteLine("Все животные стада насытились и ушли с поляны.");
        Console.ReadLine();
    }
}