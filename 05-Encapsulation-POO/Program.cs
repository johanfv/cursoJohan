Console.WriteLine("escriba el nombre de la persona");
String name = Console.ReadLine();
Console.WriteLine("ingrese su edad");
int age = Convert.ToInt32(Console.ReadLine());

person p1 = new person(name, age);

p1.HelloPerson(age);


public class person
{
    public String Name { get; set; }
    public int Age { get; set; }

    public person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public void HelloPerson(int age)
    {
        Console.WriteLine($"Nombre: {Name} Edad :{Age}");
        this.isAdult(age);
    }

    private void isAdult(int age)
    {
        if(age >= 18)
        {
            Console.WriteLine("Es adulto");
        }
        else
        {
            Console.WriteLine("No es adulto");
        }
    }
}