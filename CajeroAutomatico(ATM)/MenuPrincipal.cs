using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico_ATM_
{
    class MenuPrincipal
    {
        //Opciones Mantenimiento
        public enum OpcionesMenuPrincipal
        {
            MODO_DISPENSACION = 1,
            RETIRAR_DINERO,
            SALIR
        }

        public void ImprimirMenu()
        {
            try
            {
                MenuDispensacion menuDispensacion = new MenuDispensacion();
                ServicioRetiro servicioRetiro = new ServicioRetiro();
                Console.Clear();
                Console.WriteLine(" ATM\n");
                Console.WriteLine(" 1.Configurar Modo De Dispensación \n 2.Retirar Dinero\n 3.Salir");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case (int)OpcionesMenuPrincipal.MODO_DISPENSACION:
                        menuDispensacion.ImprimirMenu();
                        break;
                    case (int)OpcionesMenuPrincipal.RETIRAR_DINERO:
                        servicioRetiro.Retirar();
                        break;

                    case (int)OpcionesMenuPrincipal.SALIR:
                        Console.Clear();
                        Console.WriteLine("Gracias por utilizar el sistema");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Esta opcion no es valida");
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Debe Introducir las opciones del menu");
                Console.ReadKey();

                ImprimirMenu();
            }
        }
    }
}
