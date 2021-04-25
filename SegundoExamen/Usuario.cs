using System;

namespace Parcial
{
    class Usuario{
        public string nombre;
        public string direccion;
        public int edad;

        public Usuario(string nombre, string direccion, int edad){
            this.nombre = nombre;
            this.direccion = direccion;
            this.edad = edad;
        }
        public Usuario(){
            System.Console.WriteLine("===============================");
            System.Console.WriteLine("Escriba el nombre del usuario");
            nombre = Console.ReadLine();
                                            
            System.Console.WriteLine("Escriba la direcion del cliente");
            direccion = Console.ReadLine();

            System.Console.WriteLine("Escriba la edad del cliente");
            edad=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("===============================");

        }
    }
}