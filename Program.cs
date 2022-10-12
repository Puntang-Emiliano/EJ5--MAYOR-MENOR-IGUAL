using System;

namespace EJ5_
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Holaaa!! Te voy a decir cual de los numeros ingresados es el MAYOR o si son IGUALES");

        int nume1, nume2; 
        Console.WriteLine("Ingrese un numero");
        nume1= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        nume2= Convert.ToInt32 (Console.ReadLine());
        if (nume1 > nume2)
        {
            Console.WriteLine ("El Primer Numero es Mayor ");
        }
        else
            { 
                Console.WriteLine ("El Segundo Numero es el Mayor");
            } 



        }
    }
}
