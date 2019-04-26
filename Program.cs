using System;
using System.Collections;

namespace pcStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### PCSTORE MAIN MENU ### "+"\n"+"Input de number for selected option:"+"\n"+
            "1 - Search."+"\n"+"2 - Add."+"\n"+"3 - Delete."+"\n"+"\n"
            );
            Console.Write(/*mostrar datos de facturas,productos,clientes,empleados*/"");

        }
    }
}


/* 
    ###PCSTORE ###
CLASES / OBJETOS:
-Productos
-Facturas
    -Lista de ventas realizadas
-Clientes
-Empleados

ACCIONES:
-Buscar (productos,facturas,clientes,empleados).
-Añadir (productos,clientes,empleados,ventas)
-Elimnar (productos,clientes,empleados,ventas)


CONSIDERACIONES:
-Constricciones de FK al eliminar objetos? 
-
*/