using System;
using System.Collections;

namespace pcStore
{
    class Program
    {
        static void Main(string[] args)
        {
            bool closeApp = false;
            while (closeApp == false)
            {
                Console.WriteLine("### PCSTORE MAIN MENU ### "+"\n"+
                "AQUI mostrar datos de facturas,productos,clientes,empleados"
                );
                Console.Write("Input de number for selected option:"+"\n"+
                "1 - Search."+"\n"+"2 - Add."+"\n"+"3 - Delete."+"\n"+
                "4 - Exit Program.");
                int selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1: //Search
                    break;
                    
                    case 2: //Add
                    {
                        Console.Write("Select:"+"\n"+
                        "1 - Customer."+"\n"+"2 - Product."+"\n"+"3 - Employee."+"\n"+
                        "4 - Sale."+"\n"+"5 - Back."+"\n"+"6 - Exit Program.");
                        int addSel = int.Parse(Console.ReadLine());

                        switch (addSel)
                        {
                            
                            case 1: //ADD CUSTOMERS
                            {
                                
                                break;
                            }
                        }
                        break;
                    }

                    case 3: //Delete
                    break;

                    case 4: //Exit
                    {
                        closeApp = true;
                        break;
                    }
                }
            }
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