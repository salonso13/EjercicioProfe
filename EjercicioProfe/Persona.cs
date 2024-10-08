﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProfe
{
    public class Persona
    {
        public int id = 0;
        public string nombre;
        public string apellidos;
        public string dni;
        public string domicilio;
        public int edad;
        public string fechanac;

        public Persona(int id, string nombre, string apellidos, string dni, string domicilio, int edad, string fechanac)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.domicilio = domicilio;
            this.edad = edad;
            this.fechanac = fechanac;
        }

        public Persona() { }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string Domicilio { get; set; }
        public int Edad { get; set; }
        public string Fechanac { get; set; }

        public static Persona CrearPerso()
        {
            int id = 0;
            string nombre = "";
            string apellidos = "";
            string dni = "";
            string domicilio = "";
            int edad = 0;
            string fechanac = "";

            //Creo el objeto Persona
            Persona persona = new Persona(id,nombre,apellidos,dni,domicilio, edad,fechanac);
            
            //Aumento el id por cada vez que se cree una Persona
            persona.Id++;

            //Introduzco el nombre.
            Console.WriteLine("Introducir nombre: ");
            persona.Nombre = Console.ReadLine();

            //Introduzco los apellidos
            Console.WriteLine("Introducir apellidos: ");
            persona.Apellidos = Console.ReadLine();

            //Introduzco DNI
            Console.WriteLine("Introducir DNI: ");
            persona.Dni = Console.ReadLine();

            //Introduzco domicilio
            Console.WriteLine("Introducir domicilio: ");
            persona.Domicilio = Console.ReadLine();

            //Introduzco edad
            Console.WriteLine("Introducir edad: ");
            persona.Edad = Convert.ToInt32(Console.ReadLine());

            //Introduzco la fecha de nacimiento
            Console.WriteLine("Introducir fecha nacimiento (DD de MM de YY): ");
            persona.Fechanac = Console.ReadLine();

            return persona;
        }

        public static void EditarPerso(Persona persona)
        {
            int opcion = 0;
            do
            {
                try
                {
                    Console.WriteLine("Selecione una opcion");
                    Console.WriteLine("1. Editar nombre");
                    Console.WriteLine("2. Editar apellidos");
                    Console.WriteLine("3. Editar DNI");
                    Console.WriteLine("4. Editar domicilio");
                    Console.WriteLine("5. Editar edad");
                    Console.WriteLine("6. Editar fecha nacimiento");
                    Console.WriteLine("0. Salir");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Introducir nombre: ");
                            persona.Nombre = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Introducir apellidos: ");
                            persona.Apellidos = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Introducir DNI: ");
                            persona.Dni = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Introducir domicilio: ");
                            persona.Domicilio = Console.ReadLine(); ;
                            break;
                        case 5:
                            Console.WriteLine("Introducir edad: ");
                            persona.Edad = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("Introducir fecha nacimiento (DD de MM de YY): ");
                            persona.Fechanac = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Opcion no valida, vuelva a intentarlo");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error, vuelva a intentarlo");
                }
            } while (opcion != 0);
        }
    }
}
