using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico_ATM_
{
    interface  IDispensacion
    {
      void configurarDispensacion(int quantity);
        //bool decimalOrNot(string n);
        //int digitsQuantity(int n);
        string messages(int messageType);
            
    }
}
