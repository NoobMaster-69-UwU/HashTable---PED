using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableEjemplo
{
    class Program
    {
        static void Main(string[] args)           
        {

            ////////// EN ESTE EJERCICO DEMOSTRAREMOS LAS FUNCIONES PARA MANEJARUNA TABLA HASH
            Hashtable miTabla = new Hashtable();

            //Elementos existentes
            miTabla.Add(123, "Elemento1");
            miTabla.Add(155, "Elemento2");
            miTabla.Add(457, "Elemento3");
            miTabla.Add(490, "Elemento4");
            miTabla.Add(567, "Elemento5");

            //Se muestran elementos
            foreach (DictionaryEntry elemento in miTabla)
            {
                Console.WriteLine("({0},{1})",elemento.Key, elemento.Value);
            }


            Console.WriteLine("***********");

            Console.WriteLine("Cantidad de elementos", miTabla.Count);

            Console.WriteLine("***********");

            // Mostrar elemento en base a su llave

            Console.WriteLine("Mostrar elemento en base a su llave");

            Console.WriteLine("Elemento con llave 567: ", miTabla[567]);
            Console.WriteLine(miTabla[155]);

            Console.WriteLine("***********");

            Console.WriteLine("Agregar nuevo Elemento");

            miTabla[45] = "NuevoElemento1";
            miTabla[300] = "Nuevo Elemento2";

            foreach (DictionaryEntry elemento in miTabla)
            {
                Console.WriteLine("({0},{1})", elemento.Key, elemento.Value);
            }

            //Comprobar si un elemento existe

            Console.WriteLine("***********");

            Console.WriteLine("Existe elemento 567: ",miTabla.Contains(567));
            Console.WriteLine("Existe elemento 334: ", miTabla.Contains(334)) ;

            Console.WriteLine("***********");


            //Eliminar Elemento

            Console.WriteLine("***********");

            miTabla.Remove(567);


            Console.WriteLine("Eliminar elemento con key 567");


            foreach (DictionaryEntry elemento in miTabla)
            {
                Console.WriteLine("({0},{1})", elemento.Key, elemento.Value);
            }


            Console.WriteLine("***********");

            foreach (int llave in miTabla.Keys)
            {
                Console.WriteLine(llave);
            }

            Console.WriteLine("***********");

            foreach (string valor in miTabla.Values)
            {
                Console.WriteLine(valor);
            }

            Console.WriteLine("Presiona Enter para salir...");
            Console.ReadLine();
        }
    }
}
