//OPERADORES ARITMETICOS

int x = 50;
int y = 25;
string z = "75";



int suma =  x + Convert.ToInt32(z);
int resta = x - y;
int multiplicacion = x * y;
int division = x / y;
int mod = x % y;

Console.WriteLine($" Suma {suma} \n Resta {resta} \n multiplicación {multiplicacion} \n División {division} \n Modulo {mod}");

//OPERADORES DE ASIGNACIÓN
int a = 5;
    a +=2;
    a -= 2;
    a *= 2;
    a /= 2;
    a %=2;
Console.WriteLine(a);

//OPERADORES DE COMPARACIÓN
//Operador de igualdad ==
bool resultEquiality =  x == y; //el valor de resultEquality será falso
//Operador de desigualdad !=
bool resultInequility = x != y; // el resultado de Inequality será true
//Operador mayor que <
bool resultGreaterThan =  x < y; //el resultado de GreaterThan será true
//Operador menor que >
bool resultLessThan  = x > y; //el resultado de LessThan será false
//Operador mayor o igual qué
bool resultGreatOrEqual = x >= y; // el resultado de resultGreatOrEqual será true
//Operador menor o igual qué
bool resultLessOrEqual = x <= y; // el resultado de resultLessOrEqual será false
Console.WriteLine($"operador de igualdad {resultEquiality} \ndesigualdad {resultInequility} \nmayor qué {resultGreaterThan} \nmenor que {resultLessThan} \n mayor o igual que {resultGreatOrEqual} \nmenor o igual {resultLessOrEqual} ");

//Operadores logicos
bool isStudent = true;
int age = 20;
bool hasDiscount = false;

//AND Operador &&
bool isEligibleForDiscount = (isStudent && age < 25); // el valor será true
//OR Operador ||
bool isEligibleForCredit = (isStudent || hasDiscount); //el valor será true
//NOT Operador !
bool isNotEligableForDiscount = !hasDiscount; 
