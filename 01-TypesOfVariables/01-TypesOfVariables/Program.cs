// See https://aka.ms/new-console-template for more information   
using System.Numerics;

//Console.WriteLine("Hello, World!");

//programa de pruebam ejercicio de variables
//Declaración y tipo de variables

string name = "Miguel";
int    age = 20;
Double salary = 200.50;
//El tipo decimal tiene un intervalo más pequeño, pero mayor precision que un double
decimal disccount = 100.50m;
bool isEmployee = true;


Console.WriteLine($" Nombre: {name}\n Edad:{age}\n Empleado: {isEmployee}\n Salario: {salary}\n Descuento {disccount}");
//Mas tipos de variables

DateTime date = DateTime.Now;
char character = 'a'; //almacena un unico caracter Unicode
byte myByte = 255; //almacena un valor entero sin signo pero solo de 8 bits
short myShort = -587; // almacena un valor entero con signo y es de 64bits
long myLong = 1313131332; //almacena un valor entero con signo de 64bits
float myFloat = 3.141652f; //almacena un numero de punto flotante de presicion simple

