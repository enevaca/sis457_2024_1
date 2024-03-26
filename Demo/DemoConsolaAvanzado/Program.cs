// See https://aka.ms/new-console-template for more information
using DemoBiblioteca;
using DemoConsolaAvanzado;

// Biblioteca de Clases / Librerias
int suma = Calculadora.sumar(6, 7);
int resta = Calculadora.restar(10, 6);
int multipliacicacion = Calculadora.multiplicar(2, 3);
decimal devision = Calculadora.dividir(50, 6);
Console.WriteLine($"Suma: {suma}, Resta: {resta}");

// Delegados
static string revertirCadena(string cadena)
{
    return new string(cadena.Reverse().ToArray());
}
Revertir revertir = revertirCadena;
Console.WriteLine(revertir("Hola Mundo"));

void imprimir(string cadena)
{
    Console.WriteLine($"Delegado Action {cadena}");
}
Action<string> imp = imprimir;
imp("SIS457");

Func<int, int, int> multiplicar = (n1, n2) => n1 * n2;
int multipliacion = multiplicar(6, 9);
Console.WriteLine($"Resultado multiplicación: {multipliacion}");

Predicate<int> mayorEdad = edad => edad >= 18;
bool esMayorEdad = mayorEdad(11);
Console.WriteLine($"Es mayor de edad: {esMayorEdad}");

// Genéricos
Generico<string, int> generico = new Generico<string, int>();
generico.campo = "Cadena de texto";
generico.campo2 = 2;
generico.imprimir("Cadena");

Generico<bool, Automovil> generico2 = new Generico<bool, Automovil>();
generico2.campo = true;
generico2.campo2 = new Automovil();
generico2.imprimir(false);

// Interfaces
// IVehiculo vehiculo = new IVehiculo(); // no se puede instanciar
Automovil automovil = new Automovil();
automovil.acelerar(60);
automovil.frenar();
automovil.girar(15);

// Clases Abstractas
// FiguraGeometrica figuraGeometrica = new FiguraGeometrica(); // no se puede instanciar
Cuadrado cuadrado = new Cuadrado(5);
Console.WriteLine($"El área del cuadrado es: {cuadrado.area()}");
Console.WriteLine($"El perímetro del cuadrado es: {cuadrado.perimetro()}");

Rectangulo rectangulo = new Rectangulo(10, 7);
Console.WriteLine($"El área del rectángulo es {rectangulo.area()}");
Console.WriteLine($"El perímetro del rectángulo es {rectangulo.perimetro()}");

// try/cath/finally
int a, b, division;
try
{
    Console.Write("Introduzca número 1: ");
    a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Introduzca número 2: ");
    b = Convert.ToInt32(Console.ReadLine());

    division = a / b;
    Console.WriteLine($"El resultado es {division}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("No es posible la división por Cero. " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Excepción no controlada. " + ex.Message);
}
finally
{
    division = 0;
    Console.WriteLine("Finalizado");
}

// Programación Asíncrona (async/await)
testAsyncAwaitMethod();
Console.WriteLine("Presione cualquier tecla para salir...");
Console.ReadLine();

static async void testAsyncAwaitMethod()
{
    await longRunningMethod();
}

static async Task<int> longRunningMethod()
{
    Console.WriteLine("Iniciando un método de larga duración...");
    await Task.Delay(5000);
    Console.WriteLine("Fin del método de larga duración");
    return 1;
}

// Inmutabilidad
Inmutable inmutable = new Inmutable(2002);
// inmutable.year = 2003; no se puede modificar
