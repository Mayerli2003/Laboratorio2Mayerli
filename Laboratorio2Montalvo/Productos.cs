using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2Montalvo
{
    class Productos
    {
        public string Nombre { get; set; }
        public string Proveedor { get; set; }
        public string FechaCaducidad { get; set; }
        public string FechaEntrada { get; set; }
        public string Detalles { get; set; }
        public double Precio { get; set; }
        public int Unidades { get; set; }
        public string Categoria { get; set; }
        public string Area { get; set; }

        public string CreacionProductos(string nombre, string proveedor,string fechaCaducidad, string fechaEntrada, string detalles, double precio, int unidades)
        {
            this.Nombre = nombre;
            this.Proveedor= proveedor;
            this.FechaCaducidad= fechaCaducidad;
            this.FechaEntrada= fechaEntrada;
            this.Detalles= detalles;
            this.Precio = precio;
            this.Unidades = unidades;
            

            Console.WriteLine("_____________________________Creacion de un nuevo producto_____________________________\n");
            Console.WriteLine("Ingrese el nombre del producto");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del proveedor");
            proveedor = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de caducidad ");
            fechaCaducidad = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de entrada ");
            fechaEntrada = Console.ReadLine();
            Console.WriteLine("Ingrese los detalles");
            detalles = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del producto");
            precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese las unidades que tendra dicho producto");
            unidades = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la area del produto (cocina, limpieza, zapatos, carne)");
            Area = Console.ReadLine();
            Console.WriteLine("Ingrese la categoria segun el area elegida");
            Categoria= Console.ReadLine();
            Console.WriteLine("Datos del producto ingresado");

            return "Nombre: "+nombre+ "\n"+"Proveedor: "+proveedor+ "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio + "\n" + "Unidades: " + unidades + "\n" + "Area: " + Area+ "\n" + "Categoria: " + Categoria ;
        }
        

    }
}
