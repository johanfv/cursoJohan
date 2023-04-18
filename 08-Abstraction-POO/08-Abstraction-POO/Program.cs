using _08_Abstraction_POO;

// Dado que la clase shape es abstracta y el metodo de area es abstracto
//no se puede crear una instancia de shape directamente
//por eso se crean instancias de las hijas
Shape[] shapes = new Shape[2];
shapes[0] = new circle(15);
shapes[1] = new Rectangle(5, 10);

foreach (var shape in shapes)
{
    Console.WriteLine($" Area de  {shape.GetType().Name} : {shape.Area()}");
}