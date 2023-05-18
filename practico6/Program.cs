// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// int a;
// int b;
 
// a = 10;
// b = a;
// Console.WriteLine("valor de a: "+a);
// Console.WriteLine("valor de b: "+b);
// int numero;
// Console.WriteLine("Ingresar un numero");

// string? cadena = Console.ReadLine();

// bool resultado = int.TryParse(cadena, out numero);

// if(resultado){
//         Console.WriteLine(numero);
// }
// else {
//         Console.WriteLine("No es un numero");
// }

//Obtener la longitud de la cadena y muestre por pantalla.

Console.WriteLine("Ingresar una cadena: ");

string? cadena = Console.ReadLine();
int longitud = cadena.Length;

Console.WriteLine("La longitud es: "+ longitud);

//A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas.


Console.WriteLine("Ingresar una cadena: ");

string? cadena2 = Console.ReadLine();

Console.WriteLine("Cadenas concatenadas: " + cadena + cadena2);


//Extraer una subcadena de la cadena ingresada
string valor = cadena.Substring(4);

Console.WriteLine("Cadena substring: "+ valor);

//Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla

foreach (var c in cadena)
{
    Console.WriteLine(c);
}

//Buscar la ocurrencia de una palabra determinada en la cadena ingresada

