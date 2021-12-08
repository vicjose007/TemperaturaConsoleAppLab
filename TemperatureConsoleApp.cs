using ISBNc;
using System;

namespace TemperatureConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature obj = new Temperature();

            int celcius;
            int farenheit;
            int kelvin;
            int num;
            string key;


            Console.WriteLine("Ingrese temperatura que quiera: 1:farenheit, 2:celcius, 3:kelvin");

            int Opcion = int.Parse(Console.ReadLine());

            switch(Opcion)
            {
                case 1:

                    Console.WriteLine("farenheit: Ingrese Valor:");

                    num = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese temperatura a convertir: celcius o kelvin");

                    key = Console.ReadLine();

                    if(key == "celcius")
                    {
                        celcius = num;

                        Console.WriteLine(obj.Fahrenheit(num, key) + " celcius");
                    }
                    else if(key == "kelvin")
                    {
                        kelvin = num;

                        Console.WriteLine(obj.Fahrenheit(num, key) + " kelvin");
                    }
                    else if (key == "farenheit")
                    {
                        Console.WriteLine(obj.Fahrenheit(num, key) + "farenheit");
                    }
                    break;

                case 2:

                    Console.WriteLine("celcius: Ingrese Valor:");

                    num = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese temperatura a convertir: farenheit o kelvin");

                    key = Console.ReadLine();

                    if (key == "celcius")
                    {

                        Console.WriteLine(obj.Celsius(num, key) + " celcius");;
                    }
                    else if (key == "kelvin")
                    {
                        kelvin = num;

                        Console.WriteLine(obj.Celsius(num, key) + " kelvin");
                    }
                    else if (key == "farenheit")
                    {
                        Console.WriteLine(obj.Celsius(num, key) + "farenheit");
                    }
                    break;


                case 3:

                    Console.WriteLine("kelvin: Ingrese Valor:");

                    num = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese temperatura a convertir: farenheit o celcius");

                    key = Console.ReadLine();

                    if (key == "celcius")
                    {
                        celcius = num;

                        Console.WriteLine(obj.Kelvin(num, key) + " celcius"); ;
                    }
                    else if (key == "kelvin")
                    {
                        Console.WriteLine(obj.Kelvin(num, key) + " kelvin");
                    }
                    else if (key == "farenheit")
                    {
                        farenheit = num;

                        Console.WriteLine(obj.Kelvin(num, key) + "farenheit");
                    }
                    break;

                default:

                    Console.WriteLine("No es una opcion");
                    break;
            }
        }
    }
}