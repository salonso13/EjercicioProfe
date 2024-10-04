using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProfe
{
    public class Menu
    {
        public static void MostrarMenu()
        {
            Menu menu = new Menu();
            Cuenta cuenta = new Cuenta();
            Persona persona = new Persona();
            

            int opcion = 0;
            do
            {
                try
                {
                    Console.WriteLine("Selecione una opcion");
                    Console.WriteLine("1. Ingrsar datos persona");
                    Console.WriteLine("2. Crear cuenta");
                    Console.WriteLine("3. Consultar cuenta");
                    Console.WriteLine("4. Editar datos personales");
                    Console.WriteLine("5. Ingresar dinero");
                    Console.WriteLine("6. Retirar dinero");
                    Console.WriteLine("7. Transferir dinero");
                    Console.WriteLine("0. Salir");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion) 
                    {
                        case 1:
                            Persona.CrearPerso();
                            break;
                        case 2:
                            cuenta = Cuenta.CrearCuenta();
                            break;
                        case 3:
                            Cuenta.MostrarCuenta(cuenta);
                            break;
                        case 4:
                            Persona.EditarPerso(persona);
                            break;
                        case 5:
                            Cuenta.Ingresar(cuenta);
                            break;
                        case 6:
                            Cuenta.Retirar(cuenta);
                            break;
                        case 7:
                            Cuenta.Transferir(cuenta);
                            break;
                        default:
                            Console.WriteLine("Opcion no valida, vuelva a intentarlo");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error, Intentelo de nuevo");
                }
        } while (opcion != 0);

        }
    }
}
