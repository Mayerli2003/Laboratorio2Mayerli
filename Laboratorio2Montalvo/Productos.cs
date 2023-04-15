using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2Montalvo
{
    public class AuxiliarProductos
    {
        //Istancia para los productos
        public static List<string> listaProductos = new List<string>() { "Arroz", "Jabon de olor", "Tenis para mujer" };
        public static List<string> listaArroz = new List<string>() { "Arroz", "Jabon de olor", "Tenis para mujer" };
        public static List<string> listaJabonOlor = new List<string>() { "Arroz", "Jabon de olor", "Tenis para mujer" };
        public static List<string> listaTenisMujer = new List<string>() { "Arroz", "Jabon de olor", "Tenis para mujer" };
        public static List<string> lista4 = new List<string>() { "Arroz", "Jabon de olor", "Tenis para mujer" };
        public static List<string> lista5 = new List<string>() { "Arroz", "Jabon de olor", "Tenis para mujer" };
    }
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

        public void CreacionProductos(string nombre, string proveedor,string fechaCaducidad, string fechaEntrada, string detalles, double precio, int unidades)
        {
            this.Nombre = nombre;
            this.Proveedor= proveedor;
            this.FechaCaducidad= fechaCaducidad;
            this.FechaEntrada= fechaEntrada;
            this.Detalles= detalles;
            this.Precio = precio;
            this.Unidades = unidades;
            

            Console.WriteLine("_____________________________Creacion de un nuevo producto_____________________________\n");
            if(AuxiliarProductos.listaProductos.Count<5)
            {
                Console.WriteLine("Ingrese el nombre del producto");
                nombre = Console.ReadLine();
                AuxiliarProductos.listaProductos.Add(nombre);
                Console.WriteLine("Ingrese el nombre del proveedor");
                proveedor = Console.ReadLine();
                AuxiliarProductos.lista4.Add(proveedor);
                Console.WriteLine("Ingrese la fecha de caducidad ");
                fechaCaducidad = Console.ReadLine();
                AuxiliarProductos.lista4.Add(fechaCaducidad);
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
                Categoria = Console.ReadLine();
                Console.WriteLine("Datos del producto ingresado");
                Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio + "\n" + "Unidades: " + unidades + "\n" + "Area: " + Area + "\n" + "Categoria: " + Categoria);


            }
            else
            {
                Console.WriteLine("Por el momento solo pueden haber 5 productos ");
            }

        }
        class CompraArroz
        {

        }
        

    }
}
