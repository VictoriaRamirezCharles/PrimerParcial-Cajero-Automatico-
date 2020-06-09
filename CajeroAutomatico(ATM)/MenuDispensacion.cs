using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico_ATM_
{
    class MenuDispensacion
    {
        //Opciones Mantenimiento
        public enum OpcionesMenuDispensacion
        {
            DISPENSACION_UNO = 1,
            DISPENSACION_DOS,
            DISPENSACION_EFICIENTE
        }
        public void ImprimirMenu()
        {
            try
            {
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                Console.Clear();
                Console.WriteLine(" Modo de Dispensacion\n");
                Console.WriteLine(" 1.Dispensacion Uno(1000 & 200) \n 2.Dispensacion Dos(500 & 100) \n 3.Dispensacion Eficiente");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case (int)OpcionesMenuDispensacion.DISPENSACION_UNO:
                        Repositorio.Instance.DispensacionType = (int)OpcionesMenuDispensacion.DISPENSACION_UNO;
                        Console.WriteLine("Modo de Dispensacion Configurado ");
                        Console.ReadKey();
                        menuPrincipal.ImprimirMenu();
                        break;
                    case (int)OpcionesMenuDispensacion.DISPENSACION_DOS:
                        Repositorio.Instance.DispensacionType = (int)OpcionesMenuDispensacion.DISPENSACION_DOS;
                        Console.WriteLine("Modo de Dispensacion Configurado ");
                        Console.ReadKey();
                        menuPrincipal.ImprimirMenu();
                        break;

                    case (int)OpcionesMenuDispensacion.DISPENSACION_EFICIENTE:
                        Repositorio.Instance.DispensacionType = (int)OpcionesMenuDispensacion.DISPENSACION_EFICIENTE;
                        Console.WriteLine("Modo de Dispensacion Configurado ");
                        Console.ReadKey();
                        menuPrincipal.ImprimirMenu();
                        break;

                    default:
                        Repositorio.Instance.DispensacionType = (int)OpcionesMenuDispensacion.DISPENSACION_EFICIENTE;
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
