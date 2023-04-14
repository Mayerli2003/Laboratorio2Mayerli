using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2Montalvo
{
    public class listaAuxiliar
    {
        public static List<string> listaAreas = new List<string>() { "Cocina", "Limpieza", "Zapateria", "Carnes" };
        public static List<string> listaCocina = new List<string>() { "Sarten", "Plancha", "Tenedores", "Platos" };
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
            { switch(listaAuxiliar.listaCocina.Count)

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
                if(listaAuxiliar.listaCocina.Count > 5)
                {
                    Console.WriteLine("Por el momento sole se pueden agregar 5 categorias");
                    Console.ReadKey();
                }

            }
            while (listaAuxiliar.listaCocina.Count > 5);
            

           
        }
        
    }
    }
//    class CategoriaLimpieza : ProcesoCategoria
//    {
//        public override string lista()
//        {
//            List<string> listaLimpieza = new List<string>() { "Jabon", "Rinso", "Acondicionador", "Gel" };
//            foreach (string mostrar in listaLimpieza)
//            {
//                Console.WriteLine($"-{mostrar}");
//            }
//            Console.WriteLine("Ingrese un nueva categoria a la area limpieza");
//            string limpieza = Console.ReadLine();
//            Console.WriteLine("Lista editada con la nueva categoria");
//            List<string> listaLimpiezaEditada = new List<string>() { "Jabon", "Rinso", "Acondicionador", "Gel\n" + "-" + limpieza + "\n" };
//            foreach (string mostrar in listaLimpiezaEditada)
//            {
//                Console.WriteLine($"-{mostrar}");
//            }
//            return "El dato agregado es " + limpieza;
//        }

//    }
//    class CategoriaZapatos : ProcesoCategoria
//    {
//        public override string lista()
//        {
//            List<string> listaZapatos = new List<string>() { "Tacon de mujer", "Tenis", "Sandalias", "Botas" };
//            foreach (string mostrar in listaZapatos)
//            {
//                Console.WriteLine($"-{mostrar}");
//            }
//            Console.WriteLine("Ingrese un nueva categoria a la area zapatos");
//            string zapatos = Console.ReadLine();
//            Console.WriteLine("Lista editada con la nueva categoria");
//            List<string> listaZapatosEditada = new List<string>() { "Tacon de mujer", "Tenis", "Sandalias", "Botas\n" + "-" + zapatos + "\n" };
//            foreach (string mostrar in listaZapatosEditada)
//            {
//                Console.WriteLine($"-{mostrar}");
//            }
//            return "El dato agregado es " + zapatos;
//        }

//    }
//    class CategoriaCarnes : ProcesoCategoria
//    {
//        public override string lista()
//        {
//            List<string> listaCarne = new List<string>() { "Res", "Carne molida", "Posta negra", "Muslo pierna de pollo" };
//            int contador = 1;
//            foreach (string mostrar in listaCarne)
//            {
//                Console.WriteLine(contador+" "+mostrar);
//                contador++;
//            }
//            Console.WriteLine("Ingrese un nueva categoria a la area de carnes");
//            string carne = Console.ReadLine();
//            listaCarne.Add(carne);
//            Console.WriteLine("Lista editada con la nueva categoria");
           
//            foreach (string mostrar in listaCarne)
//            {
//                Console.WriteLine($"-{mostrar}");
//            }
            
//            return "El dato agregado es " + carne;
//        }

//    }
//}
