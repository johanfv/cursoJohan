//CONTROL DE ESTRUCTURAS DE SELECCION O DECISIONES

using System.Timers;

int age = 18;
if(age >= 18)
{
    Console.WriteLine("Eres mayor de edad");
}

int num = 5;
if(num % 2 == 0)
{
    Console.WriteLine($"{num}  número es par");
}
else
{
    Console.WriteLine($"{ num} No es par");
}

char letter = 'a';
switch(letter)
{
    case 'a':
        Console.WriteLine("La letra es a");
            break;
    case 'b':
        Console.WriteLine("la letra es b");
        break;
    default: Console.WriteLine("la letra no es ni a, ni b");
        break;
}

//Estructuras de repetición o bucles
int i = 0;

while(i < 5)
{
    Console.WriteLine($"el valor de i es {i}");
    i++;
}

int j = 7;
// se ejecuta al menos una ves antes de hacer la evaluacion
do
{
    Console.WriteLine($"el valor de i es {i}");
    i++;
} while (j < 5);

Console.WriteLine("\n");

for(int k=0; k<5; k++)
{
    Console.WriteLine($"El valor de k es {k}");
}

int[] nums = { 1, 2, 3, 4, 5, 10, 15, 20 };

foreach(var item in nums)
{
    Console.WriteLine($"el valor es {item}");
}

//Coestructuras de saltos
for(int n =0;  n<5; n++)
{
    if (n == 3)
        continue;
    Console.WriteLine($"El valor es {n}");
}

int Sum(int num1, int num2)
{ int result = num1 + num2;
    return result;
}

int suma = Sum(1, 2);
Console.WriteLine(suma);