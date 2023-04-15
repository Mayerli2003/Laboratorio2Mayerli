using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Laboratorio2Montalvo
{
    public class Program
    {
        private static string respuesta;
        private static object area4;

        //Instancia

        static void Main(string[] args)
        {
            
            //Instancias de clases
            CategoriaCocina cocina = new CategoriaCocina();
            CategoriaLimpieza limpieza = new CategoriaLimpieza();
            CategoriaZapatos zapatos = new CategoriaZapatos();
            CategoriaCarnes carnes=new CategoriaCarnes();
            Categoria5 categoria5 = new Categoria5();
            //Instancia de productos
            Productos productos= new Productos();
            listaAuxiliar listaAuxiliar = new listaAuxiliar();
            AuxiliarProductos auxiliarProductos = new AuxiliarProductos();
            Inicio inicio = new Inicio();
            int Option;
            

            do
            {
                Console.Clear();
                Console.WriteLine("===============================================");
                Console.WriteLine("    BIENVENIDO AL SUPERMERCADO EL BARATILLO\n");
                inicio.Usuario(inicio.Nombre, inicio.Edad);
                Console.WriteLine("_______________Indique su rol_______________\n");
                Console.WriteLine("\n1.Administrador");
                //El Administrador tiene opciones de agregar areas, categorias, productos y vender productos
                Console.WriteLine("\n2.Comprador");
               
                //El comprador solo puede realizar la venta
                Console.WriteLine("\n3.Salir");


                Console.WriteLine("\nSeleccione una opción 1-3");
                Console.Write("\nIngrese un número entero: ");
                string entrada = Console.ReadLine();

                while (!int.TryParse(entrada, out Option))
                {
                    Console.WriteLine("Error: Debe ingresar un número entero.");
                    Console.WriteLine("\nIngrese un numero entero:");
                    entrada = Console.ReadLine();
                }
                if (Option == 1)
                {
                    inicio.Nivel = "Administrador";
                    Console.WriteLine("Opciones del nivel de "+inicio.Nivel);
                }
                if (Option == 2)
                {
                    inicio.Nivel = "Vendedor";
                    Console.WriteLine("Opciones del nivel de " + inicio.Nivel);
                }
               
                //switch de opciones segun el rol seleccionado
                switch (Option)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Ha seleccionado la opcion 1\n ");
                            Console.WriteLine("__________ROL DE ADMINISTRADOR__________\n");
                           

                            Console.WriteLine("-Seleccione la opcion que quiere agregar  ");
                            List<string> listaMenu = new List<string>() { "1-Crear Area", "2-Crear Categorias", "3-Crear Productos", "4-Comprar" ,"5-Salir"};
                            foreach (string mostrar in listaMenu)
                            {
                                Console.WriteLine($"{mostrar}");
                            }
                            Console.WriteLine("\nIngrese el numero de la opcion (1-5)");
                            Console.Write("\nIngrese un número entero: ");
                            string entrada1 = Console.ReadLine();

                            while (!int.TryParse(entrada1, out Option))
                            {
                                Console.WriteLine("Error: Debe ingresar un número entero.");
                                Console.WriteLine("\nIngrese un numero entero:");
                                entrada1 = Console.ReadLine();
                            }

                            switch (Option)
                            {
                                case 1:
                                    Console.WriteLine("Opcion 1");

                                    Console.WriteLine("----------------------------CREACIÓN DE ÁREAS---------------------------- ");
                                    Console.WriteLine("Como las siguientes:");

                                    int Contador = 1;
                                    foreach (string mostrar in listaAuxiliar.listaAreas)
                                    {
                                        Console.WriteLine(Contador + " " + mostrar);
                                        Contador++;
                                    }
                                    //Console.WriteLine("9.Salir");
                                    
                                        do
                                        {
                                            Console.WriteLine("\n¿Qué desea hacer?\n");
                                            Console.WriteLine("1.Salir");
                                            Console.WriteLine("2.Agregar las areas faltantes 5-8");
                                            Console.WriteLine("\nSeleccione una opción 1-2");
                                            Console.Write("\nIngrese un número entero: ");
                                            string entrada5 = Console.ReadLine();

                                            while (!int.TryParse(entrada5, out Option))
                                            {
                                                Console.WriteLine("Error: Debe ingresar un número entero.");
                                                Console.WriteLine("\nIngrese un numero entero:");
                                                entrada5 = Console.ReadLine();
                                            }
                                            switch (Option)
                                            {
                                                case 1:
                                                    Console.WriteLine("Fin de las consultas");
                                                    Console.ReadLine();

                                                    break;
                                                case 2:
                                                    Console.WriteLine("Continuar....");
                                                do
                                                {
                                                    switch (listaAuxiliar.listaAreas.Count)
                                                    {
                                                        case 0:
                                                            Console.Write("1-Ingrese un área : \n");
                                                            string area = Console.ReadLine();
                                                            //En esta parte ToLower es para comparar palabras en string sin importar si esta en mayuscula o minuscula

                                                            listaAuxiliar.listaAreas.Add(area);
                                                            int Contado = 1;
                                                            foreach (string mostrar in listaAuxiliar.listaAreas)
                                                            {
                                                                Console.WriteLine(Contado + " " + mostrar);
                                                                Contado++;
                                                            }
                                                            break;
                                                        case 1:
                                                            Console.Write("2-Ingrese un área : \n");
                                                            string area1 = Console.ReadLine();
                                                            //En esta parte ToLower es para comparar palabras en string sin importar si esta en mayuscula o minuscula

                                                            listaAuxiliar.listaAreas.Add(area1);
                                                            int Contado1 = 1;
                                                            foreach (string mostrar in listaAuxiliar.listaAreas)
                                                            {
                                                                Console.WriteLine(Contado1 + " " + mostrar);
                                                                Contado1++;
                                                            }
                                                            break;
                                                        case 2:
                                                            Console.Write("3-Ingrese un área : \n");
                                                            string area2 = Console.ReadLine();
                                                            //En esta parte ToLower es para comparar palabras en string sin importar si esta en mayuscula o minuscula

                                                            listaAuxiliar.listaAreas.Add(area2);
                                                            int Contado2 = 1;
                                                            foreach (string mostrar in listaAuxiliar.listaAreas)
                                                            {
                                                                Console.WriteLine(Contado2 + " " + mostrar);
                                                                Contado2++;
                                                            }
                                                            break;
                                                        case 3:
                                                            Console.Write("4-Ingrese un área : \n");
                                                            string area3 = Console.ReadLine();
                                                            //En esta parte ToLower es para comparar palabras en string sin importar si esta en mayuscula o minuscula

                                                            listaAuxiliar.listaAreas.Add(area3);
                                                            int Contado3 = 1;
                                                            foreach (string mostrar in listaAuxiliar.listaAreas)
                                                            {
                                                                Console.WriteLine(Contado3 + " " + mostrar);
                                                                Contado3++;
                                                            }
                                                            break;
                                                        case 4:

                                                            Console.Write("5-Ingrese un área : \n");
                                                            string area4 = Console.ReadLine();

                                                            //En esta parte ToLower es para comparar palabras en string sin importar si esta en mayuscula o minuscula
                                                            listaAuxiliar.listaAreas.Add(area4);
                                                            int Contado4 = 1;
                                                            foreach (string mostrar in listaAuxiliar.listaAreas)
                                                            {
                                                                Console.WriteLine(Contado4 + " " + mostrar);
                                                                Contado4++;
                                                            }


                                                            break;
                                                        case 5:
                                                            Console.Write("6-Ingrese un área : \n");
                                                            string area5 = Console.ReadLine();
                                                            //En esta parte ToLower es para comparar palabras en string sin importar si esta en mayuscula o minuscula

                                                            listaAuxiliar.listaAreas.Add(area5);
                                                            int Contado5 = 1;
                                                            foreach (string mostrar in listaAuxiliar.listaAreas)
                                                            {
                                                                Console.WriteLine(Contado5 + " " + mostrar);
                                                                Contado5++;
                                                            }
                                                            break;
                                                        case 6:
                                                            Console.Write("7-Ingrese un área : \n");
                                                            string area6 = Console.ReadLine();
                                                            //En esta parte ToLower es para comparar palabras en string sin importar si esta en mayuscula o minuscula

                                                            listaAuxiliar.listaAreas.Add(area6);
                                                            int Contado6 = 1;
                                                            foreach (string mostrar in listaAuxiliar.listaAreas)
                                                            {
                                                                Console.WriteLine(Contado6 + " " + mostrar);
                                                                Contado6++;
                                                            }
                                                            break;
                                                        case 7:
                                                            Console.Write("8-Ingrese un área : \n");
                                                            string area7 = Console.ReadLine();
                                                            //En esta parte ToLower es para comparar palabras en string sin importar si esta en mayuscula o minuscula

                                                            listaAuxiliar.listaAreas.Add(area7);
                                                            int Contado7 = 1;
                                                            foreach (string mostrar in listaAuxiliar.listaAreas)
                                                            {
                                                                Console.WriteLine(Contado7 + " " + mostrar);
                                                                Contado7++;
                                                            }
                                                            break;
                                                        case 8:
                                                            Console.WriteLine("Por el momento no podemos agregar más de 8 áreas al supermercado...");
                                                            Console.ReadLine();
                                                            break;
                                                        default:

                                                            Console.WriteLine("Opción no válida.");
                                                            break;

                                                    }
                                                    Console.ReadKey();

                                                }
                                                while (listaAuxiliar.listaAreas.Count != 8);
                                                break;
                                              default:

                                                Console.WriteLine("Opción no válida.");
                                                break;

                                            }
                                        }
                                        while (Option!= 1) ;

                                        break;
     
                                        
                                case 2:
                                    Console.WriteLine("Opcion 2");
                                    Console.WriteLine("----------------------------CREACIÓN DE CATEGORÍAS---------------------------- ");
                                    Console.WriteLine("Lista de las distintas categorias:");
                                    do
                                    {
                                        int Contar = 1;
                                        foreach (string mostrar in listaAuxiliar.listaAreas)
                                        {
                                            Console.WriteLine(Contar + " " + mostrar);
                                            Contar++;
                                        }
                                        Console.WriteLine("9.Salir");
                                        Console.WriteLine("\nNOTA: de la opcion 1 a la 4 ya contienen categorias\n");
                                        Console.WriteLine("---------------------------------------------------------------------------");

                                        if (listaAuxiliar.listaAreas.Count > 4)
                                        {
                                            int proceso = listaAuxiliar.listaAreas.Count - 4;
                                            Console.WriteLine("Por el momento hay " + proceso + " opciones aparte de las cuatro que ya tienen categorias");
                                           
                                        }
                                        Console.WriteLine("* Seleccione el área a la que quiere agregar la categoria");
                                        Console.Write("\nIngrese un número entero: ");
                                        string entrada3 = Console.ReadLine();

                                        while (!int.TryParse(entrada3, out Option))
                                        {
                                            Console.WriteLine("Error: Debe ingresar un número entero.");
                                            Console.WriteLine("\nIngrese un numero entero:");
                                            entrada3 = Console.ReadLine();
                                        }
                                        switch (Option)
                                        {
                                            case 1:
                                                Console.WriteLine("----------------------------Opcion agregar categorias de cocina----------------------------");
                                                cocina.lista();
                                                break;
                                            case 2:
                                                Console.WriteLine("----------------------------Opcion agregar categorias de Limpieza----------------------------");
                                                limpieza.lista();
                                                break;
                                            case 3:
                                                Console.WriteLine("----------------------------Opcion agregar categorias de Zapatos----------------------------");
                                                zapatos.lista();
                                                break;
                                            case 4:
                                                Console.WriteLine("----------------------------Opcion agregar categorias de Carnes----------------------------");
                                                carnes.lista();
                                                break;
                                            case 5:

                                                if (listaAuxiliar.listaAreas.Count <= 4 || string.IsNullOrEmpty(listaAuxiliar.listaAreas[4]))
                                                {

                                                    Console.WriteLine("El espacio [4] de la lista está vacío.");
                                                    Console.ReadLine();
                                                    
                                                }
                                                else
                                                    
                                                {
                                                    Console.WriteLine($"El espacio [4] de la lista está ocupado con el valor '{listaAuxiliar.listaAreas[4]}'.");
                                                    categoria5.lista();
                                                    Console.ReadLine();
                                                }
                                           
                                                break; 
                                            case 6:
                                                break;
                                            case 7:
                                                break;
                                            case 8:
                                                break;
                                            case 9:
                                                break;
                                            case 10:
                                                break;

                                            case 11:

                                                Console.WriteLine("Fin de las consultas");
                                                Console.ReadLine();
                                                Environment.Exit(0);
                                                break;
                                            default:

                                                Console.WriteLine("Opción no válida.");
                                                break;
                                        }

                                    }
                                    while (Option != 9);
                                   
                                    break;
                                case 3:
                                    Console.WriteLine("Opcion 3");
                                    Console.WriteLine("----------------------------Creacion de Productos---------------------------- ");
                                    productos.CreacionProductos(productos.Nombre,productos.Proveedor, productos.FechaCaducidad, productos.FechaEntrada, productos.Detalles, productos.Precio, productos.Unidades, productos.Area,productos.Categoria);
                                    do
                                    {
                                        Console.WriteLine("\n Lista de Productos actualizada");
                                        int Contarr = 1;
                                        foreach (string mostrar in AuxiliarProductos.listaProductos)
                                        {
                                            Console.WriteLine(Contarr + " " + mostrar);
                                            Contarr++;
                                        }
                                        Console.WriteLine("6 Salir");
                                        Console.ReadLine();
                                        Console.WriteLine("Ingrese la opcion de la cual quiere visualizar los detalles de los productos:");
                                        Console.WriteLine("\nIngrese el numero de la opcion (1-6)");
                                        Console.Write("\nIngrese un número entero: ");
                                        string entrada4 = Console.ReadLine();

                                        while (!int.TryParse(entrada4, out Option))
                                        {
                                            Console.WriteLine("Error: Debe ingresar un número entero.");
                                            Console.WriteLine("\nIngrese un numero entero:");
                                            entrada4 = Console.ReadLine();
                                        }
                                        switch (Option)
                                        {
                                            case 1:
                                                break;
                                            case 2:
                                                break;
                                            case 3:
                                                break;
                                            case 4:
                                                break;
                                            case 5:
                                                break;
                                            case 6:

                                                Console.WriteLine("Fin de las consultas");
                                                Console.ReadLine();
                                                Environment.Exit(0);
                                                break;
                                            default:

                                                Console.WriteLine("Opción no válida.");
                                                break;


                                        }

                                    }
                                    while(Option != 6);
                                    

                                    break;
                                case 4:
                                    Console.WriteLine("Opcion 4");
                                    Console.WriteLine("----------------------------Comprar producto---------------------------- ");

                                    break;
                                case 5:

                                    Console.WriteLine("Fin de las consultas");
                                    Console.ReadLine();
                                    Environment.Exit(0);
                                    break;
                                default:

                                    Console.WriteLine("Opción no válida.");
                                    break;
                            }


                        }
                        while (Option != 5);
                        break;
                    case 2:
                        do
                        {

                        }
                        while (Option != 6);
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Fin de las consultas");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    default:

                        Console.WriteLine("Opción no válida.");
                        break;

                }
                            
               
                
            }
            while (Option != 3);

        }
    }
}