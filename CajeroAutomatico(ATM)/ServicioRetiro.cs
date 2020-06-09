using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico_ATM_
{
    class ServicioRetiro
    {
        public void Retirar()
        {
            ServicioDispensacionUno servicioDispensacionUno = new ServicioDispensacionUno();
            ServicioDispensacionDos servicioDispensacionDos = new ServicioDispensacionDos();
            ServicioDispensacionEficiente servicioDispensacioEficiente = new ServicioDispensacionEficiente();
         
            Console.WriteLine("Ingrese la Cantidad que desea Retirar");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            try
            {
                switch (Repositorio.Instance.DispensacionType)
                {
                    case 1:

                        servicioDispensacionUno.configurarDispensacion(cantidad);
                        break;

                    case 2:

                        servicioDispensacionDos.configurarDispensacion(cantidad);
                        break;

                    case 3:

                        servicioDispensacioEficiente.configurarDispensacion(cantidad);

                        break;
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Esta opcion no es Valida");
            }
        }
    }
}
