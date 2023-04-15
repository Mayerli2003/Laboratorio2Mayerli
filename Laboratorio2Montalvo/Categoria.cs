﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2Montalvo
{
    public class listaAuxiliar
    {
        //lista de las areas del supermercado
        public static List<string> listaAreas = new List<string>() { "Cocina", "Limpieza", "Zapateria", "Carnes" };
        //listas para las categorias del supermercado
        //4 lista de manera predefinidas
        public static List<string> listaCocina = new List<string>() { "Sartenes", "Utencilios", "Comida", "Platos" };
        public static List<string> listaLimpieza = new List<string>() { "Jabones", "Rinsos", "Utensilios de limpieza", "Cremas" };
        public static List<string> listaZapatos = new List<string>() { "Tacones", "Tenis", "Sandalias", "Botas" };
        public static List<string> listaCarne = new List<string>() { "Carne de res", "Carne molida", "Carne de cerdo", "Carne de pollo" };
        //4 listas de categorias definidas e la ejecucion
        public static List<string> lista5 = new List<string>();
        public static List<string> lista6 = new List<string>();
        public static List<string> lista7 = new List<string>();
        public static List<string> lista8 = new List<string>();
        

    }


    abstract class ProcesoCategoria
    {
        public abstract void lista();

    }
    class CategoriaCocina : ProcesoCategoria
    {
        
        public override void lista()
        {

            do
            {
                switch (listaAuxiliar.listaCocina.Count)
                {
                    case 0:
                        foreach (string mostrar in listaAuxiliar.listaCocina)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area cocina");
                        string cocina = Console.ReadLine();
                        listaAuxiliar.listaCocina.Add(cocina);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaCocina)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }

                        break;
                    case 1:
                        foreach (string mostrar in listaAuxiliar.listaCocina)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area cocina");
                        string cocina1 = Console.ReadLine();
                        listaAuxiliar.listaCocina.Add(cocina1);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaCocina)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 2:
                        foreach (string mostrar in listaAuxiliar.listaCocina)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area cocina");
                        string cocina2 = Console.ReadLine();
                        listaAuxiliar.listaCocina.Add(cocina2);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaCocina)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 3:
                        foreach (string mostrar in listaAuxiliar.listaCocina)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area cocina");
                        string cocina3 = Console.ReadLine();
                        listaAuxiliar.listaCocina.Add(cocina3);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaCocina)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 4:
                        foreach (string mostrar in listaAuxiliar.listaCocina)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area cocina");
                        string cocina4 = Console.ReadLine();
                        listaAuxiliar.listaCocina.Add(cocina4);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaCocina)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 5:
                        foreach (string mostrar in listaAuxiliar.listaCocina)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area cocina");
                        string cocina5 = Console.ReadLine();
                        listaAuxiliar.listaCocina.Add(cocina5);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaCocina)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 6:
                        foreach (string mostrar in listaAuxiliar.listaCocina)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area cocina");
                        string cocina6 = Console.ReadLine();
                        listaAuxiliar.listaCocina.Add(cocina6);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaCocina)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Por el momento no podemos agregar mas de 7 categorias a cada area");
                        Console.ReadLine();
                        break;

                }

                

            }
            while (listaAuxiliar.listaCocina.Count > 7);
            

           
        }
        
    }
    class CategoriaLimpieza : ProcesoCategoria
    {
        public override void lista()
        {
            do
            {
                switch (listaAuxiliar.listaLimpieza.Count)
                {
                    case 0:
                        foreach (string mostrar in listaAuxiliar.listaLimpieza)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area cocina");
                        string limpieza = Console.ReadLine();
                        listaAuxiliar.listaLimpieza.Add(limpieza);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaLimpieza)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }

                        break;
                    case 1:
                        foreach (string mostrar in listaAuxiliar.listaLimpieza)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area de limpieza");
                        string limpieza1 = Console.ReadLine();
                        listaAuxiliar.listaLimpieza.Add(limpieza1);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaLimpieza)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 2:
                        foreach (string mostrar in listaAuxiliar.listaLimpieza)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area de limpieza");
                        string limpieza2 = Console.ReadLine();
                        listaAuxiliar.listaLimpieza.Add(limpieza2);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaLimpieza)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 3:
                        foreach (string mostrar in listaAuxiliar.listaLimpieza)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area de limpiza");
                        string limpieza3 = Console.ReadLine();
                        listaAuxiliar.listaLimpieza.Add(limpieza3);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaLimpieza)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 4:
                        foreach (string mostrar in listaAuxiliar.listaLimpieza)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area de limpieza");
                        string limpieza4 = Console.ReadLine();
                        listaAuxiliar.listaLimpieza.Add(limpieza4);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaLimpieza)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 5:
                        foreach (string mostrar in listaAuxiliar.listaLimpieza)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area de limpieza");
                        string limpieza5 = Console.ReadLine();
                        listaAuxiliar.listaLimpieza.Add(limpieza5);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaLimpieza)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 6:
                        foreach (string mostrar in listaAuxiliar.listaLimpieza)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area limpieza");
                        string limpieza6 = Console.ReadLine();
                        listaAuxiliar.listaLimpieza.Add(limpieza6);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaLimpieza)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Por el momento no podemos agregar mas de 7 categorias a cada area");
                        Console.ReadLine();
                        break;

                }



            }
            while (listaAuxiliar.listaLimpieza.Count > 7);


        }

    }
    class CategoriaZapatos : ProcesoCategoria
    {
        public override void lista()
        {
            do
            {
                switch (listaAuxiliar.listaZapatos.Count)
                {
                    case 0:
                        foreach (string mostrar in listaAuxiliar.listaZapatos)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area de zapatos");
                        string zapatos = Console.ReadLine();
                        listaAuxiliar.listaLimpieza.Add(zapatos);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaZapatos)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }

                        break;
                    case 1:
                        foreach (string mostrar in listaAuxiliar.listaZapatos)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area de zapatos");
                        string zapatos1 = Console.ReadLine();
                        listaAuxiliar.listaZapatos.Add(zapatos1);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaZapatos)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 2:
                        foreach (string mostrar in listaAuxiliar.listaZapatos)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area de zapatos");
                        string zapatos2 = Console.ReadLine();
                        listaAuxiliar.listaLimpieza.Add(zapatos2);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaZapatos)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 3:
                        foreach (string mostrar in listaAuxiliar.listaZapatos)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area de zapatos");
                        string zapatos3 = Console.ReadLine();
                        listaAuxiliar.listaZapatos.Add(zapatos3);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaZapatos)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 4:
                        foreach (string mostrar in listaAuxiliar.listaZapatos)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area de zapatos");
                        string zapatos4 = Console.ReadLine();
                        listaAuxiliar.listaZapatos.Add(zapatos4);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaZapatos)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 5:
                        foreach (string mostrar in listaAuxiliar.listaZapatos)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area de zapatos");
                        string zapatos5 = Console.ReadLine();
                        listaAuxiliar.listaZapatos.Add(zapatos5);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaZapatos)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 6:
                        foreach (string mostrar in listaAuxiliar.listaZapatos)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area de zapatos");
                        string zapatos6 = Console.ReadLine();
                        listaAuxiliar.listaZapatos.Add(zapatos6);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaZapatos)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Por el momento no podemos agregar mas de 7 categorias a cada area");
                        Console.ReadLine();
                        break;

                }



            }
            while (listaAuxiliar.listaCocina.Count > 7);
        }

    }
    class CategoriaCarnes : ProcesoCategoria
    {
        public override void lista()
        {
            do
            {
                switch (listaAuxiliar.listaCarne.Count)
                {
                    case 0:
                        foreach (string mostrar in listaAuxiliar.listaCarne)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area de carne");
                        string carne = Console.ReadLine();
                        listaAuxiliar.listaCarne.Add(carne);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaCarne)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }

                        break;
                    case 1:
                        foreach (string mostrar in listaAuxiliar.listaCarne)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area de carne");
                        string carne1 = Console.ReadLine();
                        listaAuxiliar.listaCarne.Add(carne1);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaCarne)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 2:
                        foreach (string mostrar in listaAuxiliar.listaCarne)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area de carne");
                        string carne2 = Console.ReadLine();
                        listaAuxiliar.listaCarne.Add(carne2);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaCarne)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 3:
                        foreach (string mostrar in listaAuxiliar.listaCarne)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area de carne");
                        string carne3 = Console.ReadLine();
                        listaAuxiliar.listaCarne.Add(carne3);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaCarne)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 4:
                        foreach (string mostrar in listaAuxiliar.listaCarne)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area de carne");
                        string carne4 = Console.ReadLine();
                        listaAuxiliar.listaCarne.Add(carne4);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaCarne)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 5:
                        foreach (string mostrar in listaAuxiliar.listaCarne)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area de carne");
                        string carne5 = Console.ReadLine();
                        listaAuxiliar.listaCarne.Add(carne5);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaCarne)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 6:
                        foreach (string mostrar in listaAuxiliar.listaCarne)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        Console.WriteLine("Ingrese un nueva categoria a la area de carne");
                        string carne6 = Console.ReadLine();
                        listaAuxiliar.listaCarne.Add(carne6);
                        Console.WriteLine("Lista ya editada");
                        foreach (string mostrar in listaAuxiliar.listaCarne)
                        {
                            Console.WriteLine($"-{mostrar}");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Por el momento no podemos agregar mas de 7 categorias a cada area");
                        Console.ReadLine();
                        break;

                }



            }
            while (listaAuxiliar.listaCocina.Count > 7);

        }

    }
    class Categoria5 : ProcesoCategoria
    {
        int Option;
        public override void lista()
        {
            do
            {
                Console.WriteLine("\n¿Qué desea hacer?\n");
                Console.WriteLine("1.Salir");
                Console.WriteLine("2.Agregar las categorias faltantes");
                Console.WriteLine("\nSeleccione una opción 1-2");
                Console.Write("\nIngrese un número entero: ");
                string entrada6 = Console.ReadLine();
                

                while (!int.TryParse(entrada6, out Option))
                {
                    Console.WriteLine("Error: Debe ingresar un número entero.");
                    Console.WriteLine("\nIngrese un numero entero:");
                    entrada6= Console.ReadLine();
                }
                switch (Option)
                {
                    case 1:
                        Console.WriteLine("Fin de las consultas");
                        Console.ReadLine();
                        break;
                    case 2:
                        do
                        {
                            switch (listaAuxiliar.lista5.Count)
                            {
                                case 0:
                                    foreach (string mostrar in listaAuxiliar.lista5)
                                    {
                                        Console.WriteLine($"-{mostrar}");
                                    }
                                    Console.WriteLine("1-Ingrese un nueva categoria al area " + listaAuxiliar.listaAreas[4]);
                                    string dato0 = Console.ReadLine();
                                    listaAuxiliar.lista5.Add(dato0);
                                    Console.WriteLine("Lista ya editada");
                                    foreach (string mostrar in listaAuxiliar.lista5)
                                    {
                                        Console.WriteLine($"-{mostrar}");
                                    }

                                    break;
                                case 1:

                                    Console.WriteLine("2-Ingrese un nueva categoria a la area  " + listaAuxiliar.listaAreas[4]);
                                    string dato1 = Console.ReadLine();
                                    listaAuxiliar.lista5.Add(dato1);
                                    Console.WriteLine("Lista ya editada");
                                    foreach (string mostrar in listaAuxiliar.lista5)
                                    {
                                        Console.WriteLine($"-{mostrar}");
                                    }
                                    break;
                                case 2:

                                    Console.WriteLine("3-Ingrese un nueva categoria a la area " + listaAuxiliar.listaAreas[4]);
                                    string dato2 = Console.ReadLine();
                                    listaAuxiliar.lista5.Add(dato2);
                                    Console.WriteLine("Lista ya editada");
                                    foreach (string mostrar in listaAuxiliar.lista5)
                                    {
                                        Console.WriteLine($"-{mostrar}");
                                    }
                                    break;
                                case 3:

                                    Console.WriteLine("4-Ingrese un nueva categoria a la area " + listaAuxiliar.listaAreas[4]);
                                    string dato3 = Console.ReadLine();
                                    listaAuxiliar.lista5.Add(dato3);
                                    Console.WriteLine("Lista ya editada");
                                    foreach (string mostrar in listaAuxiliar.lista5)
                                    {
                                        Console.WriteLine($"-{mostrar}");
                                    }
                                    break;
                                case 4:

                                    Console.WriteLine("Ingrese un nueva categoria a la area cocina");
                                    string cocina4 = Console.ReadLine();
                                    listaAuxiliar.lista5.Add(cocina4);
                                    Console.WriteLine("Lista ya editada");
                                    foreach (string mostrar in listaAuxiliar.lista5)
                                    {
                                        Console.WriteLine($"-{mostrar}");
                                    }
                                    break;
                                case 5:

                                    Console.WriteLine("Ingrese un nueva categoria a la area cocina");
                                    string cocina5 = Console.ReadLine();
                                    listaAuxiliar.lista5.Add(cocina5);
                                    Console.WriteLine("Lista ya editada");
                                    foreach (string mostrar in listaAuxiliar.lista5)
                                    {
                                        Console.WriteLine($"-{mostrar}");
                                    }
                                    break;
                                case 6:

                                    Console.WriteLine("Ingrese un nueva categoria a la area cocina");
                                    string cocina6 = Console.ReadLine();
                                    listaAuxiliar.lista5.Add(cocina6);
                                    Console.WriteLine("Lista ya editada");
                                    foreach (string mostrar in listaAuxiliar.lista5)
                                    {
                                        Console.WriteLine($"-{mostrar}");
                                    }
                                    break;
                                case 7:
                                    int Contador = 1;
                                    foreach (string mostrar in listaAuxiliar.lista5)
                                    {
                                        Console.WriteLine(Contador +" "+ mostrar);
                                        Contador++;
                                    }
                                    Console.WriteLine("Por el momento no podemos agregar mas de 7 categorias a cada area");
                                    Console.ReadLine();
                                    break;

                            }
                            Console.ReadKey();

                        }
                        while (listaAuxiliar.lista5.Count != 7);
                        break;
                    default:

                        Console.WriteLine("Opción no válida.");
                        break;
                }
               
            }
            while (Option!=1);
            Console.ReadLine();
        }
    }
}




