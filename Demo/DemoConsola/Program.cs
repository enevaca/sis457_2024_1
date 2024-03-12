﻿// See https://aka.ms/new-console-template for more information
/* Esto es un comentario
 * en múltiples líneas...
 */
// Console.WriteLine("Hello, World!");

// Variables
var variable = "Cualquier valor";
bool esActivo = false;
int entero = 7;
long enteroLargo = 104656546546;
double real = 56.21;
decimal real2 = 12.33M;
float real3 = 69.7F;
char caracter = 'A';
string cadena = "Esto es una cadena";
Int32 entero2 = 9;
Int64 enteroLargo2 = 104656546546;
DateTime fecha = DateTime.Now;

// Constantes
const double PI = 3.1416;
const string SIGLA_MATERIA = "SIS457";

// Operadores y Expresiones
entero = 15;
entero2 += 2;
entero2 %= 2;
bool esPar = entero % 2 == 0;
int a = 2 + 3 * 2;
int b = (2 - 3) * 2;

// Conversiones y cadenas
string conversionCadena = Convert.ToString(entero);
int conversionEntero = Convert.ToInt32("6");
bool conversionBoolean = Convert.ToBoolean("true");

string materia = "Fundamentos de la Programación ";
string mayuscula = materia.ToUpper();
string minuscula = materia.ToLower();
string reemplazo = materia.Replace(" ", "*");
string eliminar = materia.Replace("Programación", "");
string subcadena = materia.Substring(0, 10);
string concatenar = SIGLA_MATERIA + " " + materia;
string concatenar2 = $"{SIGLA_MATERIA} {materia}";
int cantidadCaracteres = materia.Length;
string quitarExtremos = materia.Trim();
int cantidadCaracteres2 = quitarExtremos.Length;
string[] separar = materia.Split(" ");
string primeraPosicion = separar[0];
string terceraPosicision = materia.Split(' ')[3];

// Estructuras de control
bool esMayorCero;
if (cadena.Length > 0) esMayorCero = true;
else esMayorCero = false;
bool esMayorCero2 = cadena.Length > 0 ? true : false;
bool esMayorCero3 = cadena.Length > 0;

switch (materia)
{
    case "Informatica": materia += "Info"; break;
    default: materia = materia.Trim(); break;
}

int datoPantalla = 0;
while (datoPantalla <= 0)
{
    Console.WriteLine("Introduzca un número mayor a Cero (while):");
    datoPantalla = 5; //Convert.ToInt32(Console.ReadLine());
}

do
{
    Console.WriteLine("Introduzca un número mayor a Cero (do while):");
    datoPantalla = 7; //Convert.ToInt32(Console.ReadLine());
} while (datoPantalla <= 0);

List<string> lista = new List<string>();
for (int i = 0; i < separar.Length; i++)
{
    Console.WriteLine($"for: {separar[i]}");
    lista.Add(separar[i]);
}

foreach (string s in lista) Console.WriteLine($"foreach: {s}");

// Funciones/métodos

void saludo(string nombre)
{
    Console.WriteLine($"Hola {nombre} desde método");
}

int suma(int numero1, int numero2)
{
    saludo("SIS457"); // llamada a otro método
    return numero1 + numero2;
}

int sumatoria = suma(5, 9);
Console.WriteLine(sumatoria);
