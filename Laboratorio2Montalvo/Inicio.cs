using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2Montalvo
{
    public  class Inicio
    {
        //public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public string Nivel { get; set; }

        private static int UltimoId = 0;
        public int Id { get; private set; }
       



        public void Usuario(string nombre, int edad)
        {
            this.Id = ++UltimoId;
            this.Nombre = nombre;
            this.Edad = edad;
            
           
            Console.WriteLine("----------  DATOS DEL USUARIO  ----------");
            Console.WriteLine("\n-Ingrese su nombre de usuario: ");
            nombre = Console.ReadLine();
            Console.WriteLine("\n-Ingrese su edad: ");
            string entrada3 = Console.ReadLine();

            while (!int.TryParse(entrada3, out edad))
            {
                Console.WriteLine("Error: Debe ingresar un número entero.");
                Console.WriteLine("\n-Ingrese su edad: ");
                entrada3 = Console.ReadLine();
            }
            
            Console.WriteLine("Bienvenido al programa usuario "+nombre +" con ID "+UltimoId+ "\n");
            Console.WriteLine("_______________________________________________________________");
        }
    }
}
