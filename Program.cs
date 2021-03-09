using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario
{

    class Usuario
    {
        //Atributos = Campos, Hola
        private string nombre;
        private string correo;
        private int numeroSeguidores;

        public void Publicar(string mensaje)
        {
            Console.WriteLine($"{nombre} acaba de publicar lo siguiente {mensaje}");
        }

        public void VerPerfil()
        {
            Console.WriteLine($"User: {nombre} Correo: {correo} Seguidores: {numeroSeguidores}");
        }

        public void setNombre(string nombre)
        {
            // TO DO: Verificar que el nombre de usuario no exista 
            this.nombre = nombre;
        }

        public void setCorreo(string correo)
        {
            this.correo = correo;
        }

        public void setSeguidores(int n)
        {
            if (n < 0)
                n= n  * -1;
            numeroSeguidores = n;
        }
        
    }



    class Program
    {
        static void Main(string[] args)
        {
            Usuario mario = new Usuario();

            // mario.nombre = "mariosky";
            mario.setNombre("mariosky");
            mario.setCorreo("mariosky@gmail.com");
            mario.setSeguidores(-50);


            mario.VerPerfil();
            mario.Publicar("Hola al curso de Prog OO #ProgOO");

            Console.ReadKey();
        }
    }
}
