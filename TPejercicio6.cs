/*Crear un menú de usuario con las opciones necesarias para solicitar que se ingresen 2 
números y que tipo de operación matemática se desea realizar: multiplicación, suma, resta,
división, Paran finalizar mostrar resultado de la operación por pantalla.*/
using System;
using System.Threading;
namespace TpCSharpEjercicio6
{
        class Program
    {
        static void Main(string[] args)
        {
            float numero1 = 0, numero2 = 0;
            titulo ();
            numero1= ingresoDeNumero ();       
            titulo ();
            numero2= ingresoDeNumero (); 
            titulo ();
            Console.WriteLine("Usted a elegido como primer número el " + numero1);
            Console.WriteLine("     ...y como segundo número el " + numero2);
            Thread.Sleep(3000);
            titulo ();
                switch (menu ())
                {
                    case "1":
                        suma(numero1,numero2);
                    break;
                    case "2":
                        resta(numero1,numero2);
                    break;
                    case "3":
                        multiplicacion (numero1, numero2);
                    break;
                    case "4":
                        division (numero1, numero2);
                    break;
                    default:
                    break;
                }
        }
        static void titulo ()
        {
            Console.Clear();
            Console.WriteLine("-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|");
            Console.WriteLine("      Operaciones Matematicas");
            Console.WriteLine("-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-| \n");
        }
        static float ingresoDeNumero ()
        {
            string entrada ="";
            float num =0;
            Console.WriteLine("         Ingrese un número");
            Console.WriteLine("----------------------------------");
            entrada = Console.ReadLine();
            num = Convert.ToSingle(entrada);
            return num;
        }
        static string menu ()
        { 
            Console.WriteLine("   MENU DE OPCIONES");
            Console.WriteLine("     1 - Sumar");
            Console.WriteLine("     2 - Restar");
            Console.WriteLine("     3 - Multiplicar");
            Console.WriteLine("     4 - Dividir");
            Console.WriteLine("Cualquier tecla para salir");
            string opcion = Console.ReadLine();
            return opcion;
        }
        static void suma (float uno, float dos)
        {
            float resultado = uno + dos;
            Console.WriteLine("La suma de los dos números es " + resultado);
        }
        static void resta (float uno, float dos)
        {
            float resultado = uno - dos;
            Console.WriteLine("La resta entre los dos números es " + resultado);
        }
        static void multiplicacion (float uno, float dos)
        {
            float resultado = uno * dos;
            Console.WriteLine("La multiplicacion entre los dos números es " + resultado);
        }
        static void division (float uno, float dos)
        {
            if (dos != 0)
                {
                    float resultado = uno / dos;
                    Console.WriteLine("La división entre los dos números es " + resultado);
                }
                else
                {
                    Console.WriteLine("El divisor debe ser distinto a 0");
                }
        }
    }
}
