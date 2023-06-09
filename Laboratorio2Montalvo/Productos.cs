﻿using System;
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
        //public static List<string> listaAreas = new List<string>() { "Cocina", "Limpieza", "Zapateria", "Carnes" };
        //public static List<string> listaCocina = new List<string>() { "Sartenes", "Utencilios", "Comida", "Platos" };
        //public static List<string> listaLimpieza = new List<string>() { "Jabones", "Rinsos", "Utensilios de limpieza", "Cremas" };
        //public static List<string> listaZapatos = new List<string>() { "Tacones", "Tenis", "Sandalias", "Botas" };
        //public static List<string> listaCarne = new List<string>() { "Carne de res", "Carne molida", "Carne de cerdo", "Carne de pollo" };

        public static List<string> listaArroz = new List<string>() { "Nombre: Arroz" ,"Proveedor: Mario Martínez","Fecha de caducidad: 12 de enero 2023","Fecha de entrada: 12 de enero 2022","Detalles: Arroz San Pedro","Area: cocina","Categoria: comida"};
        public static List<double> listaArrozPrecio = new List<double>() {2.0};
        public static List<int> listaArrozUnidades = new List<int>() {12 };

        public static List<string> listaJabonOlor = new List<string>() { "Nombre: Jabon de olor", "Proveedor: Meiko Akisuki", "Fecha de caducidad: 14 de enero 2023", "Fecha de entrada: 14 de enero 2022", "Detalles: Jabon de avena", "Area: limpieza", "Categoria: jabones" };
        public static List<double> listaJabonOlorPrecio = new List<double>() { 4.50};
        public static List<int> listaJabonOlorUnidades = new List<int>() {12 };

        public static List<string> listaTenisMujer = new List<string>() { "Nombre: Tenis de mujer", "Proveedor: Marbely Damaris", "Fecha de caducidad: 12 de marzo 2023", "Fecha de entrada: 12 de marzo 2000", "Detalles: color rosa tierno", "Area: zapateria", "Categoria: tenis" };
        public static List<double> listaTenisMujerPrecio = new List<double>() {45.67 };
        public static List<int> listaTenisMujerUnidades = new List<int>() { 12};

        public static List<string> lista4 = new List<string>() { };
        public static List<double> lista4Precio = new List<double>() { };
        public static List<int> lista4Unidades = new List<int>() { };

        public static List<string> lista5 = new List<string>() { };
        public static List<double> lista5Precio = new List<double>() { };
        public static List<int> lista5Unidades = new List<int>() { };

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

        public void CreacionProductos(string nombre, string proveedor,string fechaCaducidad, string fechaEntrada, string detalles, double precio, int unidades, string area, string categoria)
        {
            this.Nombre = nombre;
            this.Proveedor= proveedor;
            this.FechaCaducidad= fechaCaducidad;
            this.FechaEntrada= fechaEntrada;
            this.Detalles= detalles;
            this.Precio = precio;
            this.Unidades = unidades;
            this.Area = area;
            this.Categoria = categoria;
            int Option;

            int Conti = 1;
            foreach (string mostrar in AuxiliarProductos.listaProductos)
            {
                Console.WriteLine(Conti+" "+ mostrar);
                Conti++;
            }

            Console.WriteLine("\n_____________________________Creacion de un nuevo producto_____________________________\n");
            if(AuxiliarProductos.listaProductos.Count<5)
            {
                Console.WriteLine("                 ------------Ingresando el producto 4------------");
                Console.WriteLine("\nIngrese el nombre del producto:");
                nombre = Console.ReadLine();
                AuxiliarProductos.listaProductos.Add(nombre);
                AuxiliarProductos.lista4.Add(nombre);

                Console.WriteLine("\nIngrese el nombre del proveedor:");
                proveedor = Console.ReadLine();
                AuxiliarProductos.lista4.Add(proveedor);
                
                Console.WriteLine("\nIngrese la fecha de caducidad: ");
                fechaCaducidad = Console.ReadLine();
                AuxiliarProductos.lista4.Add(fechaCaducidad);

                Console.WriteLine("\nIngrese la fecha de entrada:");
                fechaEntrada = Console.ReadLine();
                AuxiliarProductos.lista4.Add(fechaEntrada);

                Console.WriteLine("\nIngrese los detalles:");
                detalles = Console.ReadLine();
                AuxiliarProductos.lista4.Add(detalles);

                Console.WriteLine("\nIngrese el precio del producto:");
                precio = Convert.ToDouble(Console.ReadLine());
                AuxiliarProductos.lista4Precio.Add(precio);

                Console.WriteLine("\nIngrese las unidades que tendra dicho producto:");
                unidades = Convert.ToInt32(Console.ReadLine());
                AuxiliarProductos.lista4Unidades.Add(unidades);

                Console.WriteLine("\nIngrese la area del produto: ");
                int Contado = 1;
                foreach (string mostrar in listaAuxiliar.listaAreas)
                {
                    Console.WriteLine(Contado + " " + mostrar);
                    Contado++;
                }
                Console.WriteLine("\nLista 1-8");
                Console.WriteLine("\nNOTA: solo 1-4 estan definas las otras cuatro opciones se definen en ejecucion");
                
                area = Console.ReadLine();
                if (area != "1" && area !="2" && area !="3" && area !="4" && area != "5" && area != "6" && area != "7" && area != "8")
                {
                    Console.WriteLine("La opcion no es valida");

                }
                if (area == "1")
                {
                    AuxiliarProductos.lista4.Add(listaAuxiliar.listaAreas[0]);
                    foreach (string mostrar in listaAuxiliar.listaCocina)
                    {
                        Console.WriteLine($"-{mostrar}");
                    }
                    Console.WriteLine("\nNOTA: solo 1-4 estan definas las otras  opciones se definen en ejecucion");
                    categoria=Console.ReadLine();
                    if(categoria=="1")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("00.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[0] + "\n" + "Categoria: " + listaAuxiliar.listaCocina[0]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaCocina[0]);
                        Console.ReadLine();
                    }
                    if (categoria == "2")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[0] + "\n" + "Categoria: " + listaAuxiliar.listaCocina[1]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaCocina[1]);
                        Console.ReadLine();

                    }
                    if (categoria == "3")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[0] + "\n" + "Categoria: " + listaAuxiliar.listaCocina[2]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaCocina[2]);
                        Console.ReadLine();
                    }
                    if (categoria == "4")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[0] + "\n" + "Categoria: " + listaAuxiliar.listaCocina[3]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaCocina[3]);
                        Console.ReadLine();
                    }
                    if (categoria == "5")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[0] + "\n" + "Categoria: " + listaAuxiliar.listaCocina[4]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaCocina[4]);
                        Console.ReadLine();
                    }
                    if (categoria == "6")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[0] + "\n" + "Categoria: " + listaAuxiliar.listaCocina[5]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaCocina[5]);
                        Console.ReadLine();
                    }
                    if (categoria == "7")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[0] + "\n" + "Categoria: " + listaAuxiliar.listaCocina[6]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaCocina[6]);
                        Console.ReadLine();
                    }
                   
                    if (categoria != "1" && categoria != "2" && categoria != "3" && categoria != "4" && categoria != "5" && categoria != "6" && categoria != "7" && categoria != "8")
                    {
                        Console.WriteLine("La opcion no es valida");

                    }
                }
                if (area == "2")
                {
                    AuxiliarProductos.lista4.Add(listaAuxiliar.listaAreas[1]);
                    foreach (string mostrar in listaAuxiliar.listaLimpieza)
                    {
                        Console.WriteLine($"-{mostrar}");
                    }
                    Console.WriteLine("\nNOTA: solo 1-3 estan definas las otras cuatro opciones se definen en ejecucion");
                    categoria = Console.ReadLine();
                    if (categoria == "1")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[1] + "\n" + "Categoria: " + listaAuxiliar.listaLimpieza[0]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaLimpieza[0]);
                        Console.ReadLine();
                    }
                    if (categoria == "2")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[1] + "\n" + "Categoria: " + listaAuxiliar.listaLimpieza[1]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaLimpieza[1]);
                        Console.ReadLine();
                    }
                    if (categoria == "3")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[1] + "\n" + "Categoria: " + listaAuxiliar.listaLimpieza[2]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaLimpieza[2]);
                        Console.ReadLine();
                    }
                    if (categoria == "4")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[1] + "\n" + "Categoria: " + listaAuxiliar.listaLimpieza[3]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaLimpieza[3]);
                        Console.ReadLine();
                    }
                    if (categoria == "5")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[1] + "\n" + "Categoria: " + listaAuxiliar.listaLimpieza[4]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaLimpieza[4]);
                        Console.ReadLine();
                    }
                    if (categoria == "6")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[1] + "\n" + "Categoria: " + listaAuxiliar.listaLimpieza[5]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaLimpieza[5]);
                        Console.ReadLine();
                    }
                    if (categoria == "7")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[1] + "\n" + "Categoria: " + listaAuxiliar.listaLimpieza[6]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaLimpieza[6]);
                        Console.ReadLine();
                    }

                    if (categoria != "1" && categoria != "2" && categoria != "3" && categoria != "4" && categoria != "5" && categoria != "6" && categoria != "7" && categoria != "8")
                    {
                        Console.WriteLine("La opcion no es valida");

                    }
                }
                if (area == "3")
                {
                    AuxiliarProductos.lista4.Add(listaAuxiliar.listaAreas[2]);
                    foreach (string mostrar in listaAuxiliar.listaZapatos)
                    {
                        Console.WriteLine($"-{mostrar}");
                    }
                    Console.WriteLine("\nNOTA: solo 1-3 estan definas las otras cuatro opciones se definen en ejecucion");
                    categoria = Console.ReadLine();
                    if (categoria == "1")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[2] + "\n" + "Categoria: " + listaAuxiliar.listaZapatos[0]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaZapatos[0]);
                        Console.ReadLine();
                    }
                    if (categoria == "2")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[2] + "\n" + "Categoria: " + listaAuxiliar.listaZapatos[1]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaZapatos[1]);
                        Console.ReadLine();
                    }
                    if (categoria == "3")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[2] + "\n" + "Categoria: " + listaAuxiliar.listaZapatos[2]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaZapatos[2]);
                        Console.ReadLine();
                    }
                    if (categoria == "4")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[2] + "\n" + "Categoria: " + listaAuxiliar.listaZapatos[3]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaZapatos[3]);
                        Console.ReadLine();
                    }
                    if (categoria == "5")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[2] + "\n" + "Categoria: " + listaAuxiliar.listaZapatos[4]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaZapatos[4]);
                        Console.ReadLine();
                    }
                    if (categoria == "6")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[2] + "\n" + "Categoria: " + listaAuxiliar.listaZapatos[5]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaZapatos[5]);
                        Console.ReadLine();
                    }
                    if (categoria == "7")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[2] + "\n" + "Categoria: " + listaAuxiliar.listaZapatos[6]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaZapatos[6]);
                        Console.ReadLine();
                    }

                    if (categoria != "1" && categoria != "2" && categoria != "3" && categoria != "4" && categoria != "5" && categoria != "6" && categoria != "7" && categoria != "8")
                    {
                        Console.WriteLine("La opcion no es valida");

                    }
                }
                if (area == "4")
                {
                    AuxiliarProductos.lista4.Add(listaAuxiliar.listaAreas[3]);
                    foreach (string mostrar in listaAuxiliar.listaCarne)
                    {
                        Console.WriteLine($"-{mostrar}");
                    }
                    Console.WriteLine("\nNOTA: solo 1-3 estan definas las otras cuatro opciones se definen en ejecucion");
                    categoria = Console.ReadLine();
                    if (categoria == "1")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[3] + "\n" + "Categoria: " + listaAuxiliar.listaCarne[0]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaCarne[0]);
                        Console.ReadLine();
                    }
                    if (categoria == "2")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[3] + "\n" + "Categoria: " + listaAuxiliar.listaCarne[0]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaCarne[1]);
                        Console.ReadLine();

                    }
                    if (categoria == "3")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[3] + "\n" + "Categoria: " + listaAuxiliar.listaCarne[2]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaCarne[2]);
                        Console.ReadLine();
                    }
                    if (categoria == "4")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[3] + "\n" + "Categoria: " + listaAuxiliar.listaCarne[3]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaCarne[3]);
                        Console.ReadLine();
                    }
                    if (categoria == "5")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[3] + "\n" + "Categoria: " + listaAuxiliar.listaCarne[4]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaCarne[4]);
                        Console.ReadLine();
                    }
                    if (categoria == "6")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[3] + "\n" + "Categoria: " + listaAuxiliar.listaCarne[5]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaCarne[5]);
                        Console.ReadLine();
                    }
                    if (categoria == "7")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[3] + "\n" + "Categoria: " + listaAuxiliar.listaCarne[6]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.listaCarne[6]);
                        Console.ReadLine();
                    }

                    if (categoria != "1" && categoria != "2" && categoria != "3" && categoria != "4" && categoria != "5" && categoria != "6" && categoria != "7" && categoria != "8")
                    {
                        Console.WriteLine("La opcion no es valida");

                    }
                }
                if (area == "5")
                {
                    AuxiliarProductos.lista4.Add(listaAuxiliar.listaAreas[4]);
                    foreach (string mostrar in listaAuxiliar.lista5)
                    {
                        Console.WriteLine($"-{mostrar}");
                    }
                    Console.WriteLine("\nNOTA: solo 1-3 estan definas las otras cuatro opciones se definen en ejecucion");
                    categoria = Console.ReadLine();
                    if (categoria == "1")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[4] + "\n" + "Categoria: " + listaAuxiliar.lista5[0]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista5[0]);
                        Console.ReadLine();
                    }
                    if (categoria == "2")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[4] + "\n" + "Categoria: " + listaAuxiliar.lista5[1]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista5[1]);
                        Console.ReadLine();
                    }
                    if (categoria == "3")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[4] + "\n" + "Categoria: " + listaAuxiliar.lista5[2]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista5[2]);
                        Console.ReadLine();
                    }
                    if (categoria == "4")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[4] + "\n" + "Categoria: " + listaAuxiliar.lista5[3]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista5[3]);
                        Console.ReadLine();
                    }
                    if (categoria == "5")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[4] + "\n" + "Categoria: " + listaAuxiliar.lista5[4]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista5[4]);
                        Console.ReadLine();
                    }
                    if (categoria == "6")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[4] + "\n" + "Categoria: " + listaAuxiliar.lista5[5]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista5[5]);
                        Console.ReadLine();
                    }
                    if (categoria == "7")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[4] + "\n" + "Categoria: " + listaAuxiliar.lista5[6]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista5[6]);
                        Console.ReadLine();
                    }

                    if (categoria != "1" && categoria != "2" && categoria != "3" && categoria != "4" && categoria != "5" && categoria != "6" && categoria != "7" && categoria != "8")
                    {
                        Console.WriteLine("La opcion no es valida");

                    }
                }
                if (area == "6")
                {
                    AuxiliarProductos.lista4.Add(listaAuxiliar.listaAreas[5]);
                    foreach (string mostrar in listaAuxiliar.lista6)
                    {
                        Console.WriteLine($"-{mostrar}");
                    }
                    Console.WriteLine("\nNOTA: solo 1-3 estan definas las otras cuatro opciones se definen en ejecucion");
                    categoria = Console.ReadLine();
                    if (categoria == "1")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[5] + "\n" + "Categoria: " + listaAuxiliar.lista6[0]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista6[0]);
                        Console.ReadLine();
                    }
                    if (categoria == "2")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[5] + "\n" + "Categoria: " + listaAuxiliar.lista6[1]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista6[1]);
                        Console.ReadLine();
                    }
                    if (categoria == "3")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[5] + "\n" + "Categoria: " + listaAuxiliar.lista6[2]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista6[2]);
                        Console.ReadLine();
                    }
                    if (categoria == "4")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[5] + "\n" + "Categoria: " + listaAuxiliar.lista6[3]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista6[3]);
                        Console.ReadLine();
                    }
                    if (categoria == "5")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[5] + "\n" + "Categoria: " + listaAuxiliar.lista6[4]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista6[4]);
                        Console.ReadLine();
                    }
                    if (categoria == "6")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[5] + "\n" + "Categoria: " + listaAuxiliar.lista6[5]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista6[5]);
                        Console.ReadLine();
                    }
                    if (categoria == "7")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[5] + "\n" + "Categoria: " + listaAuxiliar.lista6[6]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista6[6]);
                        Console.ReadLine();
                    }

                    if (categoria != "1" && categoria != "2" && categoria != "3" && categoria != "4" && categoria != "5" && categoria != "6" && categoria != "7" && categoria != "8")
                    {
                        Console.WriteLine("La opcion no es valida");

                    }
                }
                if (area == "7")
                {
                    AuxiliarProductos.lista4.Add(listaAuxiliar.listaAreas[6]);
                    foreach (string mostrar in listaAuxiliar.lista7)
                    {
                        Console.WriteLine($"-{mostrar}");
                    }
                    Console.WriteLine("\nNOTA: solo 1-3 estan definas las otras cuatro opciones se definen en ejecucion");
                    categoria = Console.ReadLine();
                    if (categoria == "1")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[6] + "\n" + "Categoria: " + listaAuxiliar.lista7[0]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista7[0]);
                        Console.ReadLine();
                    }
                    if (categoria == "2")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[6] + "\n" + "Categoria: " + listaAuxiliar.lista7[1]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista7[1]);
                        Console.ReadLine();
                    }
                    if (categoria == "3")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[6] + "\n" + "Categoria: " + listaAuxiliar.lista7[2]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista7[2]);
                        Console.ReadLine();
                    }
                    if (categoria == "4")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[6] + "\n" + "Categoria: " + listaAuxiliar.lista7[3]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista7[3]);
                        Console.ReadLine();
                    }
                    if (categoria == "5")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[6] + "\n" + "Categoria: " + listaAuxiliar.lista7[4]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista7[4]);
                        Console.ReadLine();
                    }
                    if (categoria == "6")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[6] + "\n" + "Categoria: " + listaAuxiliar.lista7[5]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista7[5]);
                        Console.ReadLine();
                    }
                    if (categoria == "7")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[6] + "\n" + "Categoria: " + listaAuxiliar.lista7[6]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista7[6]);
                        Console.ReadLine();
                    }

                    if (categoria != "1" && categoria != "2" && categoria != "3" && categoria != "4" && categoria != "5" && categoria != "6" && categoria != "7" && categoria != "8")
                    {
                        Console.WriteLine("La opcion no es valida");

                    }
                }
                if (area == "8")
                {
                    AuxiliarProductos.lista4.Add(listaAuxiliar.listaAreas[7]);
                    foreach (string mostrar in listaAuxiliar.lista8)
                    {
                        Console.WriteLine($"-{mostrar}");
                    }
                    Console.WriteLine("\nNOTA: solo 1-3 estan definas las otras cuatro opciones se definen en ejecucion");
                    categoria = Console.ReadLine();
                    if (categoria == "1")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[7] + "\n" + "Categoria: " + listaAuxiliar.lista8[0]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista8[0]);
                        Console.ReadLine();
                    }
                    if (categoria == "2")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[7] + "\n" + "Categoria: " + listaAuxiliar.lista8[1]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista8[1]);
                        Console.ReadLine();
                    }
                    if (categoria == "3")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[7] + "\n" + "Categoria: " + listaAuxiliar.lista8[2]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista8[2]);
                        Console.ReadLine();
                    }
                    if (categoria == "4")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[7] + "\n" + "Categoria: " + listaAuxiliar.lista8[3]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista8[3]);
                        Console.ReadLine();
                    }
                    if (categoria == "5")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[7] + "\n" + "Categoria: " + listaAuxiliar.lista8[4]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista8[4]);
                        Console.ReadLine();
                    }
                    if (categoria == "6")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[7] + "\n" + "Categoria: " + listaAuxiliar.lista8[5]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista8[5]);
                        Console.ReadLine();
                    }
                    if (categoria == "7")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[7] + "\n" + "Categoria: " + listaAuxiliar.lista8[6]);
                        AuxiliarProductos.lista4.Add(listaAuxiliar.lista8[6]);
                        Console.ReadLine();
                    }

                    if (area != "1" && area != "2" && area != "3" && area != "4" && area != "5" && area != "6" && area != "7")
                    {
                        Console.WriteLine("La opcion no es valida");

                    }
                }
                Console.WriteLine("------------Ingresando el producto 5------------");
                Console.WriteLine("\nIngrese el nombre del producto:");
                nombre = Console.ReadLine();
                AuxiliarProductos.listaProductos.Add(nombre);
                AuxiliarProductos.lista5.Add(nombre);

                Console.WriteLine("\nIngrese el nombre del proveedor:");
                proveedor = Console.ReadLine();
                AuxiliarProductos.lista5.Add(proveedor);

                Console.WriteLine("\nIngrese la fecha de caducidad: ");
                fechaCaducidad = Console.ReadLine();
                AuxiliarProductos.lista5.Add(fechaCaducidad);

                Console.WriteLine("\nIngrese la fecha de entrada: ");
                fechaEntrada = Console.ReadLine();
                AuxiliarProductos.lista5.Add(fechaEntrada);

                Console.WriteLine("\nIngrese los detalles:");
                detalles = Console.ReadLine();
                AuxiliarProductos.lista5.Add(detalles);

                Console.WriteLine("\nIngrese el precio del producto:");
                precio = Convert.ToDouble(Console.ReadLine());
                AuxiliarProductos.lista5Precio.Add(precio);

                Console.WriteLine("\nIngrese las unidades que tendra dicho producto:");
                unidades = Convert.ToInt32(Console.ReadLine());
                AuxiliarProductos.lista5Unidades.Add(unidades);

                Console.WriteLine("\nIngrese la area del produto: ");
                int Contado1 = 1;
                foreach (string mostrar in listaAuxiliar.listaAreas)
                {
                    Console.WriteLine(Contado1 + " " + mostrar);
                    Contado1++;
                }
                Console.WriteLine("\nLista 1-8");
                Console.WriteLine("\nNOTA: solo 1-4 estan definas las otras cuatro opciones se definen en ejecucion");

                area = Console.ReadLine();
                if (area != "1" && area != "2" && area != "3" && area != "4" && area != "5" && area != "6" && area != "7" && area != "8")
                {
                    Console.WriteLine("La opcion no es valida");

                }
                if (area == "1")
                {
                    AuxiliarProductos.lista5.Add(listaAuxiliar.listaAreas[0]);
                    foreach (string mostrar in listaAuxiliar.listaCocina)
                    {
                        Console.WriteLine($"-{mostrar}");
                    }
                    Console.WriteLine("\nNOTA: solo 1-3 estan definas las otras cuatro opciones se definen en ejecucion");
                    categoria = Console.ReadLine();
                    if (categoria == "1")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");

                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[0] + "\n" + "Categoria: " + listaAuxiliar.listaCocina[0]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaCocina[0]);
                        Console.ReadLine();
                    }
                    if (categoria == "2")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[0] + "\n" + "Categoria: " + listaAuxiliar.listaCocina[1]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaCocina[1]);
                        Console.ReadLine();

                    }
                    if (categoria == "3")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[0] + "\n" + "Categoria: " + listaAuxiliar.listaCocina[2]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaCocina[2]);
                        Console.ReadLine();
                    }
                    if (categoria == "4")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[0] + "\n" + "Categoria: " + listaAuxiliar.listaCocina[3]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaCocina[3]);
                        Console.ReadLine();
                    }
                    if (categoria == "5")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[0] + "\n" + "Categoria: " + listaAuxiliar.listaCocina[4]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaCocina[4]);
                        Console.ReadLine();
                    }
                    if (categoria == "6")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[0] + "\n" + "Categoria: " + listaAuxiliar.listaCocina[5]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaCocina[5]);
                        Console.ReadLine();
                    }
                    if (categoria == "7")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[0] + "\n" + "Categoria: " + listaAuxiliar.listaCocina[6]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaCocina[6]);
                        Console.ReadLine();
                    }

                    if (categoria != "1" && categoria != "2" && categoria != "3" && categoria != "4" && categoria != "5" && categoria != "6" && categoria != "7" && categoria != "8")
                    {
                        Console.WriteLine("La opcion no es valida");

                    }
                }
                if (area == "2")
                {
                    AuxiliarProductos.lista5.Add(listaAuxiliar.listaAreas[1]);
                    foreach (string mostrar in listaAuxiliar.listaLimpieza)
                    {
                        Console.WriteLine($"-{mostrar}");
                    }
                    Console.WriteLine("\nNOTA: solo 1-3 estan definas las otras cuatro opciones se definen en ejecucion");
                    categoria = Console.ReadLine();
                    if (categoria == "1")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[1] + "\n" + "Categoria: " + listaAuxiliar.listaLimpieza[0]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaLimpieza[0]);
                        Console.ReadLine();
                    }
                    if (categoria == "2")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[1] + "\n" + "Categoria: " + listaAuxiliar.listaLimpieza[1]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaLimpieza[1]);
                        Console.ReadLine();
                    }
                    if (categoria == "3")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[1] + "\n" + "Categoria: " + listaAuxiliar.listaLimpieza[2]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaLimpieza[2]);
                        Console.ReadLine();
                    }
                    if (categoria == "4")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[1] + "\n" + "Categoria: " + listaAuxiliar.listaLimpieza[3]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaLimpieza[3]);
                        Console.ReadLine();
                    }
                    if (categoria == "5")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[1] + "\n" + "Categoria: " + listaAuxiliar.listaLimpieza[4]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaLimpieza[4]);
                        Console.ReadLine();
                    }
                    if (categoria == "6")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[1] + "\n" + "Categoria: " + listaAuxiliar.listaLimpieza[5]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaLimpieza[5]);
                        Console.ReadLine();
                    }
                    if (categoria == "7")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[1] + "\n" + "Categoria: " + listaAuxiliar.listaLimpieza[6]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaLimpieza[6]);
                        Console.ReadLine();
                    }

                    if (categoria != "1" && categoria != "2" && categoria != "3" && categoria != "4" && categoria != "5" && categoria != "6" && categoria != "7" && categoria != "8")
                    {
                        Console.WriteLine("La opcion no es valida");

                    }
                }
                if (area == "3")
                {
                    AuxiliarProductos.lista5.Add(listaAuxiliar.listaAreas[2]);
                    foreach (string mostrar in listaAuxiliar.listaZapatos)
                    {
                        Console.WriteLine($"-{mostrar}");
                    }
                    Console.WriteLine("\nNOTA: solo 1-3 estan definas las otras cuatro opciones se definen en ejecucion");
                    categoria = Console.ReadLine();
                    if (categoria == "1")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[2] + "\n" + "Categoria: " + listaAuxiliar.listaZapatos[0]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaZapatos[0]);
                        Console.ReadLine();
                    }
                    if (categoria == "2")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[2] + "\n" + "Categoria: " + listaAuxiliar.listaZapatos[1]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaZapatos[1]);
                        Console.ReadLine();
                    }
                    if (categoria == "3")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[2] + "\n" + "Categoria: " + listaAuxiliar.listaZapatos[2]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaZapatos[2]);
                        Console.ReadLine();
                    }
                    if (categoria == "4")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[2] + "\n" + "Categoria: " + listaAuxiliar.listaZapatos[3]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaZapatos[3]);
                        Console.ReadLine();
                    }
                    if (categoria == "5")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[2] + "\n" + "Categoria: " + listaAuxiliar.listaZapatos[4]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaZapatos[4]);
                        Console.ReadLine();
                    }
                    if (categoria == "6")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[2] + "\n" + "Categoria: " + listaAuxiliar.listaZapatos[5]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaZapatos[5]);
                        Console.ReadLine();
                    }
                    if (categoria == "7")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[2] + "\n" + "Categoria: " + listaAuxiliar.listaZapatos[6]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaZapatos[6]);
                        Console.ReadLine();
                    }

                    if (categoria != "1" && categoria != "2" && categoria != "3" && categoria != "4" && categoria != "5" && categoria != "6" && categoria != "7" && categoria != "8")
                    {
                        Console.WriteLine("La opcion no es valida");

                    }
                }
                if (area == "4")
                {
                    AuxiliarProductos.lista5.Add(listaAuxiliar.listaAreas[3]);
                    foreach (string mostrar in listaAuxiliar.listaCarne)
                    {
                        Console.WriteLine($"-{mostrar}");
                    }
                    Console.WriteLine("\nNOTA: solo 1-3 estan definas las otras cuatro opciones se definen en ejecucion");
                    categoria = Console.ReadLine();
                    if (categoria == "1")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[3] + "\n" + "Categoria: " + listaAuxiliar.listaCarne[0]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaCarne[0]);
                        Console.ReadLine();
                    }
                    if (categoria == "2")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[3] + "\n" + "Categoria: " + listaAuxiliar.listaCarne[0]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaCarne[1]);
                        Console.ReadLine();

                    }
                    if (categoria == "3")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[3] + "\n" + "Categoria: " + listaAuxiliar.listaCarne[2]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaCarne[2]);
                        Console.ReadLine();
                    }
                    if (categoria == "4")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[3] + "\n" + "Categoria: " + listaAuxiliar.listaCarne[3]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaCarne[3]);
                        Console.ReadLine();
                    }
                    if (categoria == "5")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[3] + "\n" + "Categoria: " + listaAuxiliar.listaCarne[4]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaCarne[4]);
                        Console.ReadLine();
                    }
                    if (categoria == "6")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[3] + "\n" + "Categoria: " + listaAuxiliar.listaCarne[5]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaCarne[5]);
                        Console.ReadLine();
                    }
                    if (categoria == "7")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[3] + "\n" + "Categoria: " + listaAuxiliar.listaCarne[6]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.listaCarne[6]);
                        Console.ReadLine();
                    }

                    if (categoria != "1" && categoria != "2" && categoria != "3" && categoria != "4" && categoria != "5" && categoria != "6" && categoria != "7" && categoria != "8")
                    {
                        Console.WriteLine("La opcion no es valida");

                    }
                }
                if (area == "5")
                {
                    AuxiliarProductos.lista5.Add(listaAuxiliar.listaAreas[4]);
                    foreach (string mostrar in listaAuxiliar.lista5)
                    {
                        Console.WriteLine($"-{mostrar}");
                    }
                    Console.WriteLine("\nNOTA: solo 1-3 estan definas las otras cuatro opciones se definen en ejecucion");
                    categoria = Console.ReadLine();
                    if (categoria == "1")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[4] + "\n" + "Categoria: " + listaAuxiliar.lista5[0]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista5[0]);
                        Console.ReadLine();
                    }
                    if (categoria == "2")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[4] + "\n" + "Categoria: " + listaAuxiliar.lista5[1]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista5[1]);
                        Console.ReadLine();
                    }
                    if (categoria == "3")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[4] + "\n" + "Categoria: " + listaAuxiliar.lista5[2]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista5[2]);
                        Console.ReadLine();
                    }
                    if (categoria == "4")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[4] + "\n" + "Categoria: " + listaAuxiliar.lista5[3]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista5[3]);
                        Console.ReadLine();
                    }
                    if (categoria == "5")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[4] + "\n" + "Categoria: " + listaAuxiliar.lista5[4]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista5[4]);
                        Console.ReadLine();
                    }
                    if (categoria == "6")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[4] + "\n" + "Categoria: " + listaAuxiliar.lista5[5]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista5[5]);
                        Console.ReadLine();
                    }
                    if (categoria == "7")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[4] + "\n" + "Categoria: " + listaAuxiliar.lista5[6]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista5[6]);
                        Console.ReadLine();
                    }

                    if (categoria != "1" && categoria != "2" && categoria != "3" && categoria != "4" && categoria != "5" && categoria != "6" && categoria != "7" && categoria != "8")
                    {
                        Console.WriteLine("La opcion no es valida");

                    }
                }
                if (area == "6")
                {
                    AuxiliarProductos.lista5.Add(listaAuxiliar.listaAreas[5]);
                    foreach (string mostrar in listaAuxiliar.lista6)
                    {
                        Console.WriteLine($"-{mostrar}");
                    }
                    Console.WriteLine("\nNOTA: solo 1-3 estan definas las otras cuatro opciones se definen en ejecucion");
                    categoria = Console.ReadLine();
                    if (categoria == "1")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[5] + "\n" + "Categoria: " + listaAuxiliar.lista6[0]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista6[0]);
                        Console.ReadLine();
                    }
                    if (categoria == "2")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[5] + "\n" + "Categoria: " + listaAuxiliar.lista6[1]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista6[1]);
                        Console.ReadLine();
                    }
                    if (categoria == "3")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[5] + "\n" + "Categoria: " + listaAuxiliar.lista6[2]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista6[2]);
                        Console.ReadLine();
                    }
                    if (categoria == "4")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[5] + "\n" + "Categoria: " + listaAuxiliar.lista6[3]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista6[3]);
                        Console.ReadLine();
                    }
                    if (categoria == "5")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[5] + "\n" + "Categoria: " + listaAuxiliar.lista6[4]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista6[4]);
                        Console.ReadLine();
                    }
                    if (categoria == "6")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[5] + "\n" + "Categoria: " + listaAuxiliar.lista6[5]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista6[5]);
                        Console.ReadLine();
                    }
                    if (categoria == "7")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[5] + "\n" + "Categoria: " + listaAuxiliar.lista6[6]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista6[6]);
                        Console.ReadLine();
                    }

                    if (categoria != "1" && categoria != "2" && categoria != "3" && categoria != "4" && categoria != "5" && categoria != "6" && categoria != "7" && categoria != "8")
                    {
                        Console.WriteLine("La opcion no es valida");

                    }
                }
                if (area == "7")
                {
                    AuxiliarProductos.lista5.Add(listaAuxiliar.listaAreas[6]);
                    foreach (string mostrar in listaAuxiliar.lista7)
                    {
                        Console.WriteLine($"-{mostrar}");
                    }
                    Console.WriteLine("\nNOTA: solo 1-3 estan definas las otras cuatro opciones se definen en ejecucion");
                    categoria = Console.ReadLine();
                    if (categoria == "1")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[6] + "\n" + "Categoria: " + listaAuxiliar.lista7[0]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista7[0]);
                        Console.ReadLine();
                    }
                    if (categoria == "2")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[6] + "\n" + "Categoria: " + listaAuxiliar.lista7[1]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista7[1]);
                        Console.ReadLine();
                    }
                    if (categoria == "3")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[6] + "\n" + "Categoria: " + listaAuxiliar.lista7[2]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista7[2]);
                        Console.ReadLine();
                    }
                    if (categoria == "4")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[6] + "\n" + "Categoria: " + listaAuxiliar.lista7[3]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista7[3]);
                        Console.ReadLine();
                    }
                    if (categoria == "5")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[6] + "\n" + "Categoria: " + listaAuxiliar.lista7[4]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista7[4]);
                        Console.ReadLine();
                    }
                    if (categoria == "6")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[6] + "\n" + "Categoria: " + listaAuxiliar.lista7[5]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista7[5]);
                        Console.ReadLine();
                    }
                    if (categoria == "7")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[6] + "\n" + "Categoria: " + listaAuxiliar.lista7[6]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista7[6]);
                        Console.ReadLine();
                    }

                    if (categoria != "1" && categoria != "2" && categoria != "3" && categoria != "4" && categoria != "5" && categoria != "6" && categoria != "7" && categoria != "8")
                    {
                        Console.WriteLine("La opcion no es valida");

                    }
                }
                if (area == "8")
                {
                    AuxiliarProductos.lista5.Add(listaAuxiliar.listaAreas[7]);
                    foreach (string mostrar in listaAuxiliar.lista8)
                    {
                        Console.WriteLine($"-{mostrar}");
                    }
                    Console.WriteLine("\nNOTA: solo 1-3 estan definas las otras cuatro opciones se definen en ejecucion");
                    categoria = Console.ReadLine();
                    if (categoria == "1")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[7] + "\n" + "Categoria: " + listaAuxiliar.lista8[0]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista8[0]);
                        Console.ReadLine();
                    }
                    if (categoria == "2")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[7] + "\n" + "Categoria: " + listaAuxiliar.lista8[1]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista8[1]);
                        Console.ReadLine();
                    }
                    if (categoria == "3")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[7] + "\n" + "Categoria: " + listaAuxiliar.lista8[2]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista8[2]);
                        Console.ReadLine();
                    }
                    if (categoria == "4")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[7] + "\n" + "Categoria: " + listaAuxiliar.lista8[3]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista8[3]);
                        Console.ReadLine();
                    }
                    if (categoria == "5")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[7] + "\n" + "Categoria: " + listaAuxiliar.lista8[4]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista8[4]);
                        Console.ReadLine();
                    }
                    if (categoria == "6")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[7] + "\n" + "Categoria: " + listaAuxiliar.lista8[5]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista8[5]);
                        Console.ReadLine();
                    }
                    if (categoria == "7")
                    {
                        Console.WriteLine("\n----------Datos del producto ingresado----------\n");
                        Console.WriteLine("Nombre: " + nombre + "\n" + "Proveedor: " + proveedor + "\n" + "Fecha de caducidad: " + fechaCaducidad + "\n" + "Fecha de entrada: " + fechaEntrada + "\n" + "Detalles: " + detalles + "\n" + "Precio: " + precio.ToString("0.00") + "\n" + "Unidades: " + unidades + "\n" + "Area: " + listaAuxiliar.listaAreas[7] + "\n" + "Categoria: " + listaAuxiliar.lista8[6]);
                        AuxiliarProductos.lista5.Add(listaAuxiliar.lista8[6]);
                        Console.ReadLine();
                    }

                    if (area != "1" && area != "2" && area != "3" && area != "4" && area != "5" && area != "6" && area != "7")
                    {
                        Console.WriteLine("La opcion no es valida");

                    }
                }


            }
            else
            {
                Console.WriteLine("Por el momento solo pueden haber 5 productos ");
            }

        }
       
        

    }
    
}
