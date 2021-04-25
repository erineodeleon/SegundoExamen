using System;

namespace Parcial
{
    class registro{

        public static int contador = 0;
        public string nombre_usuario;

        public string peliculas_usuario;

        public string[] lista;

        
        public registro(string peliculas_usuario){
            
            this.peliculas_usuario =  peliculas_usuario; 
            contador++; 
            
        }

        public registro(string nombre_usuario,string[] lista){
            this.nombre_usuario = nombre_usuario;
            this.lista = lista;
        }
        
    }
}