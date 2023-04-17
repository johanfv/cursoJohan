string nombre, apellido, puesto;
bool existe = false;
int count = 0;
string mensage = "Algún dato es incorrecto, llene nuevamente el formulario";

do
{
    if (count >= 1)
    {
        Console.WriteLine(mensage);
    }
    Console.WriteLine("Ingrese los datos del empleado \nNombre:");
    nombre = Console.ReadLine();

    Console.WriteLine("Apellido:");
    apellido = Console.ReadLine();

    Console.WriteLine("Puesto Laboral");
    puesto = Console.ReadLine();

    count++;
 

}while ( (nombre=="" || nombre == null )
        ||
        (apellido=="" || apellido == null)
        ||
        (puesto=="" || puesto == null)
         
       );

Empleado e1 = new Empleado(nombre, apellido, puesto);

e1.MostrarDatos();


public class Empleado
{
    private string nombre { get; set; }
    private string apellido { get; set; }
    private string puesto { get; set; }

    public Empleado(string nombre, string apellido, string puesto)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.puesto = puesto;
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"El nombre del empleado es: {this.nombre} {this.apellido}\ny su puesto laboral es: {this.puesto}");
    }
}