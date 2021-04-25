using System;

namespace Parcial
{
     class Peliculas{
        public string nombre;
        public string tipo;
        public string genero;
        public string sinopsis;
        public Peliculas(string nombre, string tipo, string genero, string sinopsis){
            this.nombre = nombre;
            this.tipo = tipo;
            this.genero = genero;
            this.sinopsis = sinopsis;
        }

        public Peliculas(){
            System.Console.WriteLine("Escriba el nombre de la pelicula");
            nombre = Console.ReadLine();
            System.Console.WriteLine("Escriba el nombre tipo de pelicula");
            System.Console.WriteLine("1. Serie");
            System.Console.WriteLine("2. Pelicula");
            tipo = Console.ReadLine();
            System.Console.WriteLine("escoja el nombre del genero de la pelicula");
            System.Console.WriteLine("1. Drama");
            System.Console.WriteLine("2. Comedia");
            System.Console.WriteLine("3. Terror");
            System.Console.WriteLine("4. Suspenso");
            genero =Console.ReadLine();
            System.Console.WriteLine("escriba la sinopsis de la pelicula");
            sinopsis = Console.ReadLine();

        }
    }
}