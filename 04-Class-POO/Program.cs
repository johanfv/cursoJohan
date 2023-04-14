Console.WriteLine("Ingrese su nombre: ");
String name = Console.ReadLine();
Console.WriteLine("Ingrese su edad: ");
int age = Convert.ToInt32(Console.ReadLine());

Person p1 = new Person();
p1.Name = name;
p1.Age = age;
p1.helloPerson();

Person p2 = new Person();
p2.Name = "Pedro";
p2.Age = 20;
p2.helloPerson();

Person p3 = new Person("Juana", 20);
p3.helloPerson();
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    //un constructor es un método especial de una clase que se utiliza para inicializar los objetos de esa clase.
    //los contructores tienen el mismo nombre que la clase y no tienen tipo de retorno
    
    public Person()
    {
        
    }
    public Person(string name, int age)
    {
        Name = name;
        this.Age = age;
    }

    public void helloPerson()
    {
        Console.WriteLine($"Nombre {Name} Edad {Age}");
    }
}

