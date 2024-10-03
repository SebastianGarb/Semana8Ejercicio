using System.Text.Json;
int opc,num1 = 0, num2 = 0;
char continuar;
do
{
    do
    {
        Console.WriteLine("BIENVENIDO AL SISTEMA DE FUNCIONES ");
        Console.WriteLine("______________________________________");
        Console.WriteLine("1° Suma");
        Console.WriteLine("2° Resta");
        Console.WriteLine("3° Multiplicacion");
        Console.WriteLine("4° Division");
        Console.WriteLine("0° Salir");
        Console.WriteLine("_____________________________________ \n");

        Console.Write("Ingrese el numero que esta asignado a la operacion (1,2,3,4,0): ");
        opc = int.Parse(Console.ReadLine());
        Console.Clear();
    }
    while (opc < 0 || opc > 4);

    if (opc != 0)
    {
        Console.Write("\nIngrese el primer valor: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("\nIngrese el segundo valor: ");
        num2 = int.Parse(Console.ReadLine());
    }
    switch (opc)
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            Console.Write("\nLa suma es: "); suma(num1, num2);
            break;
        case 2:
            Console.Write("\nLa resta es: "); resta(num1, num2);
            break;
        case 3:
            Console.Write("\nLa multiplicacion es: "); multiplicacion(num1, num2);
            break;
        case 4:
            Console.Write("\nLa division es: "); division(num1, num2);
            break;
    }
    Console.WriteLine("\nQuieres hacer otra operacion? Presione (y) para continuar o presiones cualquier tecla para terminar");
    continuar = char.Parse(Console.ReadLine());
    Console.Clear();
}
while (continuar == 'y');
void suma(int num1, int num2)
{
    
    Console.WriteLine(num1 + num2);
}

void resta(int num1, int num2)
{
    
    Console.WriteLine(num1 - num2);
}

void multiplicacion(int num1, int num2)
{
    
    Console.WriteLine(num1 * num2);
}

void division(int num1, int num2)
{
    if (num2 == 0)
    {
        Console.WriteLine("\nIndeterminado");
    }
    else
    {
        Console.WriteLine(num1 / num2);
    }
}

