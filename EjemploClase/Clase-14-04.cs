// Unidad 2 - Capitulo 1 - Laboratorio 1

// Estructuras de decision


/*Console.WriteLine("Ingrese un texto: ");
string inputTexto = Console.ReadLine();

if (inputTexto != null)
{
    Console.WriteLine("Menu de Opciones:\n1- Convertir la frase ingresada a mayusculas\n2- Convertir la frase ingresada a minusculas\n3- Mostrar la cantidad de caracteres de la frase ingresada");
    ConsoleKeyInfo opcion = Console.ReadKey();
*//*    while(opcion.Equals(1) && opcion.Equals(2) && opcion.Equals(3))
    {
    Console.WriteLine("\nMenu de Opciones:\n1- Convertir la frase ingresada a mayusculas\n2- Convertir la frase ingresada a minusculas\n3- Mostrar la cantidad de caracteres de la frase ingresada");
    opcion = Console.ReadKey();
    }*//*
    if (opcion.Key == ConsoleKey.D1)
     {
        Console.WriteLine("\nLa frase ingresada en mayusculas es: " + inputTexto.ToUpper());
        Console.ReadKey();

    }
    else if (opcion.Key == ConsoleKey.D2)
    {
        Console.WriteLine("\nLa frase ingresada en minusculas es: " + inputTexto.ToLower());
        Console.ReadKey();

    }
    else if (opcion.Key == ConsoleKey.D3)
    {
        Console.WriteLine("\nLa cantidad de caracteres de la frase ingresada es: " + inputTexto.Length);
        Console.ReadKey();

    }
    else
    {
        Console.WriteLine("\nOpcion no valida");
        Console.ReadKey();
    }



}
else
{
    Console.WriteLine("El texto ingresado esta vacio");
}
*/

// Ejercicio anterior usando case

/*Console.WriteLine("Ingrese un texto: ");
string inputTexto = Console.ReadLine();

if (inputTexto != null)
{
    Console.WriteLine("Menu de Opciones:\n1- Convertir la frase ingresada a mayusculas\n2- Convertir la frase ingresada a minusculas\n3- Mostrar la cantidad de caracteres de la frase ingresada");
    ConsoleKeyInfo opcion = Console.ReadKey();
    *//*    while(opcion.Equals(1) && opcion.Equals(2) && opcion.Equals(3))
        {
        Console.WriteLine("\nMenu de Opciones:\n1- Convertir la frase ingresada a mayusculas\n2- Convertir la frase ingresada a minusculas\n3- Mostrar la cantidad de caracteres de la frase ingresada");
        opcion = Console.ReadKey();
        }*//*
    switch (opcion.Key)
    {
        case ConsoleKey.D1:
            Console.WriteLine("\nLa frase ingresada en mayusculas es: " + inputTexto.ToUpper());
            Console.ReadKey();
            break;

        case ConsoleKey.D2:
            Console.WriteLine("\nLa frase ingresada en minusculas es: " + inputTexto.ToLower());
            Console.ReadKey();
            break;

        case ConsoleKey.D3:
            Console.WriteLine("\nLa cantidad de caracteres de la frase ingresada es: " + inputTexto.Length);
            Console.ReadKey();
            break;

        default:
            Console.WriteLine("\nOpcion no valida");
            Console.ReadKey();
            break;
    }               



}
else
{
    Console.WriteLine("El texto ingresado esta vacio");
}*/

// Estructuras de iteracion

/*
Objetivo

Uso de un array de elementos en conjunto con una estructura de iteración for. 
Crear un vector de cadenas de texto, llenarlo y luego mostrar el contenido ordenado inversamente a como se ingresó.
*/
/*
int cantIteraciones = 5;
string[] arreglo = new string[cantIteraciones];

for (int i = 0; i < cantIteraciones; i++)
{
    Console.WriteLine("Ingrese el valor para el indice " + i + " del arreglo:\n");
    string texto = Console.ReadLine();
    arreglo[i] = texto;
    
}

for (int i = 4; i >= 0; i--)
{
    Console.WriteLine(arreglo[i]);
}*/

//Ejercicio 4: Ejercicios para pensar

//1- Construir una aplicación que sume dos números y proporcione el resultado con el formato siguiente:
//El resultado de la suma de < número uno > y < número dos > es < resultado >.


/*suma(1, 2);

static void suma(int num1, int num2)
{
    int suma = num1 + num2;
    Console.WriteLine("El resultado de la suma de " + num1 + " y " + num2 + " es " + suma);
}


//2- Crear una aplicación que te pida un año y verifique si el año es bisiesto o no. 
EsBisiesto(1700);
void EsBisiesto(int anio) { 
    if(anio %4 == 0)
    {
        if(anio %100 != 0)
        {
            Console.WriteLine("Es bisiesto");
        }
        else if (anio %400 == 0)
        {
            Console.WriteLine("Es bisiesto");
        }
        else
        {
            Console.WriteLine("No es bisiesto");
        }
    }
    else
    {
        Console.WriteLine("No es bisieto");
    }
}

//3- Hacer un programa para calcular la serie de Fibonacci
Fibonacci(10);
void Fibonacci(int limite)
{
    int num1 = 0;
    int num2 = 1;
    int sum = 0;

    for (int i = 0; i < limite; i++)
    {
        Console.WriteLine("Los numeros a sumar son: " + num1 + " " + num2);
        sum = num1 + num2;
        num1 = num2;
        num2 = sum;
        Console.WriteLine("La suma parcial es: " + sum);
    }
    Console.WriteLine("El resultado de la serie de Fibonacci es: " + sum);
}*/
// 4- Construir una aplicación que proporcione todos los números pares entre el 1 y el 100.

/*NumerosPares();
void NumerosPares()
{
    int sum = 0;
    for(int i = 0;i <= 100; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine("El numero par es: " + i);
            sum++;
            Console.WriteLine("Los numeros pares son: " + sum);

        }
    }
}*/

// 5- Construir una aplicación que reciba el nombre de un mes del año como parámetro y
// proporcione su número correspondiente.
// Debe ser con el formato: < Nombre del mes > + < número del mes >.

/*QueMesEs("Noviembre");
void QueMesEs(string mes)
{
    switch (mes.ToUpper())
    {
        case "ENERO":
            Console.WriteLine(1); break;
        case "FEBRERO":
            Console.WriteLine(2); break;
        case "MARZO":
            Console.WriteLine(3); break;
        case "ABRIL":
            Console.WriteLine(4); break;
        case "MAYO":
            Console.WriteLine(5); break;
        case "JUNIO":
            Console.WriteLine(6); break;
        case "JULIO":
            Console.WriteLine(7); break;
        case "AGOSTO":
            Console.WriteLine(8); break;
        case "SEPTIEMBRE":
            Console.WriteLine(9); break;
        case "OCTUBRE":
            Console.WriteLine(10); break;
        case "NOVIEMBRE":
            Console.WriteLine(11); break;
        case "DICIEMBRE":
            Console.WriteLine(12); break;
    
    }
}*/

// 6-Dado un número entero, que se convierta a número romano.
ConvertirANumeroRomano(999);

void ConvertirANumeroRomano(int numero)
{
    string numeroString = numero.ToString();
    char[] simbolos = new char[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
    int[] valores = new int[] { 1, 5, 10, 50, 100, 500, 1000 };
    // Separo cada digito del numero 
    List<char> resultado = new List<char>();
    int longitud = numeroString.Length;
    if (longitud < 4)
    {
        for (int i = 0; i < longitud; i++)
        {
            if (longitud == 3 && i == 0)
            {
                switch (numeroString[i])
                {
                    case '1':
                        resultado.Add(simbolos[4]);
                        break;
                    case '2':
                        resultado.Add(simbolos[4]);
                        resultado.Add(simbolos[4]);
                        break;
                    case '3':
                        resultado.Add(simbolos[4]);
                        resultado.Add(simbolos[4]);
                        resultado.Add(simbolos[4]);
                        break;
                    case '4':
                        resultado.Add(simbolos[4]);
                        resultado.Add(simbolos[5]);
                        break;
                    case '5':
                        resultado.Add(simbolos[5]);
                        break;
                    case '6':
                        resultado.Add(simbolos[5]);
                        resultado.Add(simbolos[4]);
                        break;
                    case '7':
                        resultado.Add(simbolos[5]);
                        resultado.Add(simbolos[4]);
                        resultado.Add(simbolos[4]);
                        break;
                    case '8':
                        resultado.Add(simbolos[5]);
                        resultado.Add(simbolos[4]);
                        resultado.Add(simbolos[4]);
                        resultado.Add(simbolos[4]);
                        break;
                    case '9':
                        resultado.Add(simbolos[4]);
                        resultado.Add(simbolos[6]);
                        break;
                }



            }
            if (longitud == 3 && i == 1)
            {
                switch (numeroString[i])
                {
                    case '1':
                        resultado.Add(simbolos[2]);
                        break;
                    case '2':
                        resultado.Add(simbolos[2]);
                        resultado.Add(simbolos[2]);
                        break;
                    case '3':
                        resultado.Add(simbolos[2]);
                        resultado.Add(simbolos[2]);
                        resultado.Add(simbolos[2]);
                        break;
                    case '4':
                        resultado.Add(simbolos[2]);
                        resultado.Add(simbolos[3]);
                        break;
                    case '5':
                        resultado.Add(simbolos[3]);
                        break;
                    case '6':
                        resultado.Add(simbolos[3]);
                        resultado.Add(simbolos[2]);
                        break;
                    case '7':
                        resultado.Add(simbolos[3]);
                        resultado.Add(simbolos[2]);
                        resultado.Add(simbolos[2]);
                        break;
                    case '8':
                        resultado.Add(simbolos[3]);
                        resultado.Add(simbolos[2]);
                        resultado.Add(simbolos[2]);
                        resultado.Add(simbolos[2]);
                        break;
                    case '9':
                        resultado.Add(simbolos[2]);
                        resultado.Add(simbolos[4]);
                        break;
                }
            }
            if (longitud == 3 && i == 2)
            {
                switch (numeroString[i])
                {
                    case '1':
                        resultado.Add(simbolos[0]);
                        break;
                    case '2':
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[0]);
                        break;
                    case '3':
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[0]);
                        break;
                    case '4':
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[1]);
                        break;
                    case '5':
                        resultado.Add(simbolos[1]);
                        break;
                    case '6':
                        resultado.Add(simbolos[1]);
                        resultado.Add(simbolos[0]);
                        break;
                    case '7':
                        resultado.Add(simbolos[1]);
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[0]);
                        break;
                    case '8':
                        resultado.Add(simbolos[1]);
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[0]);
                        break;
                    case '9':
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[2]);
                        break;
                }
            }
            if (longitud == 2 && i == 0)
            {
                switch (numeroString[i])
                {
                    case '1':
                        resultado.Add(simbolos[2]);
                        break;
                    case '2':
                        resultado.Add(simbolos[2]);
                        resultado.Add(simbolos[2]);
                        break;
                    case '3':
                        resultado.Add(simbolos[2]);
                        resultado.Add(simbolos[2]);
                        resultado.Add(simbolos[2]);
                        break;
                    case '4':
                        resultado.Add(simbolos[2]);
                        resultado.Add(simbolos[3]);
                        break;
                    case '5':
                        resultado.Add(simbolos[3]);
                        break;
                    case '6':
                        resultado.Add(simbolos[3]);
                        resultado.Add(simbolos[2]);
                        break;
                    case '7':
                        resultado.Add(simbolos[3]);
                        resultado.Add(simbolos[2]);
                        resultado.Add(simbolos[2]);
                        break;
                    case '8':
                        resultado.Add(simbolos[3]);
                        resultado.Add(simbolos[2]);
                        resultado.Add(simbolos[2]);
                        resultado.Add(simbolos[2]);
                        break;
                    case '9':
                        resultado.Add(simbolos[2]);
                        resultado.Add(simbolos[4]);
                        break;
                }
            }
            if (longitud == 2 && i == 1)
            {
                switch (numeroString[i])
                {
                    case '1':
                        resultado.Add(simbolos[0]);
                        break;
                    case '2':
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[0]);
                        break;
                    case '3':
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[0]);
                        break;
                    case '4':
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[1]);
                        break;
                    case '5':
                        resultado.Add(simbolos[1]);
                        break;
                    case '6':
                        resultado.Add(simbolos[1]);
                        resultado.Add(simbolos[0]);
                        break;
                    case '7':
                        resultado.Add(simbolos[1]);
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[0]);
                        break;
                    case '8':
                        resultado.Add(simbolos[1]);
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[0]);
                        break;
                    case '9':
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[2]);
                        break;
                }
            }
            if (longitud == 1)
            {
                switch (numeroString[i])
                {
                    case '1':
                        resultado.Add(simbolos[0]);
                        break;
                    case '2':
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[0]);
                        break;
                    case '3':
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[0]);
                        break;
                    case '4':
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[1]);
                        break;
                    case '5':
                        resultado.Add(simbolos[1]);
                        break;
                    case '6':
                        resultado.Add(simbolos[1]);
                        resultado.Add(simbolos[0]);
                        break;
                    case '7':
                        resultado.Add(simbolos[1]);
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[0]);
                        break;
                    case '8':
                        resultado.Add(simbolos[1]);
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[0]);
                        break;
                    case '9':
                        resultado.Add(simbolos[0]);
                        resultado.Add(simbolos[2]);
                        break;
                }
            }

        }

    }
    else
    {
        Console.WriteLine("Por el momento, el numero es muy grande,vuelva a intentarlo mas tarde");
    }
    foreach (char simbolo in resultado)
    {
        Console.Write(simbolo);
    }

}