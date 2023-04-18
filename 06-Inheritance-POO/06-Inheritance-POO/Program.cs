var dog = new Dog("Canelo", 5, "aguacatero");
dog.Eat();
dog.Sleep();
dog.bark();

class Animal
{
    protected String Name;
    protected int Age;

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Eat() 
    {
        Console.WriteLine($"{Name} está comiendo");
    }
    public void Sleep()
    {
        Console.WriteLine($"{Name} está durmiendo");
    }
}

class Dog : Animal {
    public Dog(string name, int age, string breed) : base(name, age)
    {
        this.breed = breed;
        
    }
    private string breed;

    public void bark()
    {
        Console.WriteLine($"{Name} es de raza {breed} y está ladrando.");
    }
}