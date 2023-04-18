using Microsoft.VisualBasic;
using System.Dynamic;
using System.IO.Pipes;

Animal[] animals = new Animal[3];
animals[0] = new Animal("Animal", 1);
animals[1] = new Dog("Ranger", 10, "Labrador");
animals[2] = new Cat("Minino", 3, 0.60);

foreach (var animal in animals)
{
    animal.MakeSound();
}

class Animal {
    protected string Name;
    protected int Age;

    public Animal(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine($"El animal hace un sonido");
    }
}

class Dog : Animal {
    private string Breed;

    public Dog( string name, int age, string breed) : base(name, age)
    {
        Breed = breed;
    }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} Ladra!!!!!!");
    }
}

class Cat : Animal
{
    private double Height;
    public Cat(string name, int age, double height) : base(name, age)
    {
        Height = height;
    }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} hace miau!");
    }
}