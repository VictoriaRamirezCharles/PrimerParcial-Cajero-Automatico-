using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico_ATM_
{
  
    class ServicioDispensacionEficiente:IDispensacion 
    {
        MenuPrincipal principal;
        public ServicioDispensacionEficiente()
        {
            principal = new MenuPrincipal();
        }
        public void configurarDispensacion(int quantity)
        {
            try
            {
                var bills = new int[] { 1000,500,200,100 };
                int[] result = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    var bill = bills[i];

                    if (quantity >= bill)
                    {
                        var billsQuantity = 0;
                        while (quantity >= bill)
                        {
                            quantity -= bill;
                            billsQuantity += 1;
                        }
                        result[i] = billsQuantity;
                    }
                }

                if (quantity == 0)
                {
                    for (int i = 0; i < bills.Length; i++)
                    {
                        if (result[i] > 0) Console.WriteLine(result[i] + " Papeleta(s) de " + bills[i]);

                    }
                    Console.ReadKey();


                }
                else
                {
                    Console.WriteLine(messages(2));
                }

             
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(messages(3));
            }


            principal.ImprimirMenu();

        }

        public bool decimalOrNot(string n)
        {
            bool entero = true;
            char[] prueba = n.ToCharArray();
            for (int i = 0; i < prueba.Length; i++)
            {
                if (prueba[i] == '.')
                {
                    entero = false;
                }
            }
            return entero;
        }

        public int digitsQuantity(int n)
        {
            n = (int)Math.Log10(n);
            return n;
        }

        public string messages(int messageType)
        {
            string message = "";
            switch (messageType)
            {
                case 1:

                    message = "El valor ingresado tiene que ser mayor o igual 100";
                    break;

                case 2:
                    message = "En este modo de dispensacion no se aceptan estos valores, intente con otro monto";
                    break;

                case 3:
                    message = "Esta Opcion no es valida";
                    break;
            }
            return message;

        }
    }
}