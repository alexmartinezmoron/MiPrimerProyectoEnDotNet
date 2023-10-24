using System;

namespace CSharpHelloWorld;
class HelloWorld
{

    static void Main(string[] args)
    {
        // Hola mundo
        Console.WriteLine("Hello, C#!");

        /*
        Comentario en varias
        lineas
        */

        string miPrimerString = "Esto es una cadena de texto";
        miPrimerString = " Cambiamos el valor del String :)";

        Console.WriteLine(miPrimerString);

        // Vamos con los numeros

        int miEntero = 7 ;
        int suma = miEntero + 5;

        // Vamos al float y double

        float miFloat = 6.5f;
        double miDouble = 6.5;

        Console.WriteLine(miDouble + miFloat);
        Console.WriteLine(miDouble + miDouble + miEntero);

        // Podemos utilizar datos dinamicos

        dynamic miDynamic = 6;
        Console.WriteLine(miDynamic);

        miDynamic = "Le podemos meter texto";
        Console.WriteLine(miDynamic);

        // Tambien podemos crear una variable y que el propio C# lo identifique

        var myString2 = "Hola";
        var miInt2 = 2;

        // Pero una vez definido no podriamos cambiar el tipo de var es decir

        /*
        myString2 = 4 ;

        Dará error ya que inicialmente c# le ha asignado a esa variable que sea un String por lo que no podemos cambiarlo a un int sobre la marcha, dicha variable sera
        un String hasta que muera

        */

        // Boleanos

        bool aceptar = true;

        Boolean denegar = false;

        // Podemos intercalar variables sin necesita de ustilizar el mas siplemnte declaramos al principio el simbolo $ y las variables entre llaves
        Console.WriteLine("Esta aceptado " + aceptar);
        Console.WriteLine($"Esta denegado {denegar}");

        // Vamos con datos mas complejos , constantes las contantes hay que definir que tipo de dato primario es

        const string MiConstante = "Mi Constante de texto";

        const int MiConstanteNumerica = 2;

        Console.WriteLine(MiConstante);
        Console.WriteLine(MiConstanteNumerica);

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///

        // Estructuras

        var miArray =  new String[]  {"Alex", "Martinez", "Moron"};

        Console.WriteLine(miArray[0]);

        // VAmos a crear una structura de diccionario donde tendramos una clave y un valor

        var miDicionario = new Dictionary<string, int>
        {
            {"Alex" , 28},
            {"Paco" , 36},
            {"Leticia", 80 }
        };

        // Vamos a indicar la clave por lo que me pintará el valor

        Console.WriteLine("Ejemplo de diccionario: " + miDicionario["Alex"]);


        // Estructura desordenada, vamos a crear un HashSet para no repetir valores

        var miSet = new HashSet<String> {"Alex", "Martinez", "Moron", "Alex", "Martinez", "Moron"};

        //  Tambien podemos crear un Tuple en la cual no hay que difinir el tipo de dato y aunque tambien es deshordenada está estructura si que permite repetir valores

        var miTuple = ("Alex", "Martinez", "Moron" , "Alex", "Martinez", "Moron");
        Console.WriteLine(miTuple);

        ///////////////////////////////////////////////////////////
        ///

        // BUCLES

        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            
        }

        Console.WriteLine("Vamos con los foreach"); 

        foreach( var i in miArray)
        {
           Console.WriteLine(i); 
        }

        Console.WriteLine("hasset: "); 

         foreach( var i in miSet)
        {
           Console.WriteLine(i); 
        }


              Console.WriteLine("Diccionario: "); 

         foreach( var i in miDicionario)
        {
           Console.WriteLine(i); 
        }     


        // FLujos: if else

        int numero = 7;
        bool boleanito = true;

        if(numero == 8){
            Console.WriteLine("El nummero era 8");
        }else{
            Console.WriteLine("El numero no era 8");
        }

        // And y or

        if(numero == 8 && boleanito == true){
            Console.WriteLine("El nummero era 8");
        }

        if(numero == 8 || boleanito == true){
            Console.WriteLine("El nummero era 8");
        }


    // Metodos o funciones

    Mifuncion();
    Mifuncion();
    Mifuncion();


    Console.WriteLine(SumaDiez(5));


    // Llamamos a una clase

    Persona miPersona = new Persona("Alex","Martinez", 28);

    Console.WriteLine("Mi objeto persona tiene de nombre: " + miPersona.nombre + " " + miPersona.apellido + " y su edad es: " + miPersona.edad);



// final del main
    }
        static void Mifuncion()
    {
        Console.WriteLine("Estas llamando al metodo mi funcion");
    }

    static int SumaDiez(int numerito)
    {
        return numerito + 10;
    }      


}




