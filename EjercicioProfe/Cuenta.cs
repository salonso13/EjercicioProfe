using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProfe
{
    public class Cuenta
    {
        private string iban;
        private string fechacrea;
        private long saldo;

        public Cuenta(string iban, string fechacrea, long saldo)
        { 
            this.iban = iban;
            this.saldo = saldo;
            this.fechacrea = fechacrea;
        }
        
        public Cuenta() { }

        public string Iban { get; set; }
        public string Fechacrea { get;set; }

        public long Saldo { get; set; }

        public static Cuenta CrearCuenta()
        {
            string iban = "";
            string fechacrea = "";
            long saldo = 0;
            Cuenta cuenta = new Cuenta(iban, fechacrea, saldo);
            Random rnd = new Random();

            //Creo un numero aleatorio para el IBAN
            //Lo separo en dos por la longitud y luego lo almaceno en un string
            long iban1 = rnd.NextInt64(1111111111, 9999999999);
            long iban2 = rnd.NextInt64(1111111111, 9999999999);
            cuenta.Iban = "ES 33" + iban1 + " " + iban2;

            //Introduzco fecha creacion
            Console.WriteLine("Introducir fecha actual (DD de MM de YYYY)");
            cuenta.Fechacrea = Console.ReadLine();

            //Creo un numero aleatorio para la cantidad
            cuenta.Saldo = rnd.NextInt64(0000000000, 9999999999);

            return cuenta;
        }

        public static void MostrarCuenta(Cuenta cuenta)
        {
            int opcion = 0;
            do
            {
                try
                {
                    Console.WriteLine("Selecione una opcion.");
                    Console.WriteLine("1. Ver IBAN");
                    Console.WriteLine("2. Consultar fecha creacion.");
                    Console.WriteLine("3. Consultar saldo de la cuenta");
                    Console.WriteLine("0. Salir");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Tu IBAN es: " + cuenta.Iban);
                            break;
                        case 2:
                            Console.WriteLine("Creaste la cuenta el " + cuenta.Fechacrea);
                            break;
                        case 3:
                            Console.WriteLine("Tu saldo en la cuenta es de " + cuenta.Saldo);
                            break;
                        default:
                            Console.WriteLine("Opcion invalida, vuelva a intentarlo");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error, intentelo de nuevo");
                }
            } while (opcion != 0);

        }

        public static void Ingresar(Cuenta cuenta)
        {
            Boolean ingresado = false;
            Console.WriteLine("Cantidad a ingresar");
            long ingresar = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Se va ha ingresar un total de: " + ingresar);
            Console.WriteLine("¿Es correcta al cantidad?");
            string pregunta = Console.ReadLine();
            do
            {
                try
                {
                    if (pregunta.Equals("Si") || pregunta.Equals("si") || pregunta.Equals("SI"))
                    {
                        Console.WriteLine("Perfecto, se ha ingresado un total de " + ingresar);
                        cuenta.Saldo += ingresar;
                        Console.WriteLine("Su saldo es de " + cuenta.Saldo);
                        ingresado = true;
                    }
                    else if (pregunta.Equals("No") || pregunta.Equals("no") || pregunta.Equals("NO"))
                    {
                        Console.WriteLine("Volviendo a intentar...");
                        Console.WriteLine("Cantidad a ingresar");
                        ingresar = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Se va ha ingresar un total de: " + ingresar);
                        cuenta.Saldo += ingresar;
                        Console.WriteLine("Su saldo es de " + cuenta.Saldo);
                        ingresado = true;

                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine("Error, vuelva a intentarlo");
                }
            }while (ingresado != false);
        }

        public static void Retirar(Cuenta cuenta)
        {
            Boolean retirado = false;
            Console.WriteLine("Cantidad a retirar");
            long retirar = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Se va ha retirar un total de: " + retirar);
            Console.WriteLine("¿Es correcta al cantidad?");
            string pregunta = Console.ReadLine();
            do
            {
                try
                {
                    if (pregunta.Equals("Si") || pregunta.Equals("si") || pregunta.Equals("SI"))
                    {
                        Console.WriteLine("Perfecto, se ha retirado un total de " + retirar);
                        cuenta.Saldo -= retirar;
                        Console.WriteLine("Su saldo es de " + cuenta.Saldo);
                        retirado = true;
                    }
                    else if (pregunta.Equals("No") || pregunta.Equals("no") || pregunta.Equals("NO"))
                    {
                        Console.WriteLine("Volviendo a intentar...");
                        Console.WriteLine("Cantidad a retirar");
                        retirar = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Se va ha retirar un total de: " + retirar);
                        cuenta.Saldo -= retirar;
                        Console.WriteLine("Su saldo es de " + cuenta.Saldo);
                        retirado = true;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error, vuelva a intentarlo");
                }
            } while (retirado == true);
        }

        public static void Transferir(Cuenta cuenta)
        {
            Boolean transferido = false;
            Console.WriteLine("Cantidad a transferir");
            long transferir = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Se va ha transferir un total de: " + transferir);
            Console.WriteLine("¿Es correcta al cantidad?");
            string pregunta = Console.ReadLine();
            do
            {
                try
                {
                    if (pregunta.Equals("Si") || pregunta.Equals("si") || pregunta.Equals("SI"))
                    {
                        Console.WriteLine("Perfecto, se ha transferido un total de " + transferir);
                        cuenta.Saldo -= transferir;
                        Console.WriteLine("Su saldo es de " + cuenta.Saldo);
                        transferido = true;
                    }
                    else if (pregunta.Equals("No") || pregunta.Equals("no") || pregunta.Equals("NO"))
                    {
                        Console.WriteLine("Volviendo a intentar...");
                        Console.WriteLine("Cantidad a transferir");
                        transferir = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Se va ha transferir un total de: " + transferir);
                        cuenta.Saldo -= transferir;
                        Console.WriteLine("Su saldo es de " + cuenta.Saldo);
                        transferido = true;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error, vuelva a intentarlo");
                }
            } while (transferido == true);
        }
    }
}
