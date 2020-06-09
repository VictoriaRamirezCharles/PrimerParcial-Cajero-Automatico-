using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico_ATM_
{
    public sealed class Repositorio
    {
        public int DispensacionType=3;
        public static Repositorio Instance { get; } = new Repositorio();
        private Repositorio()
        {
        }
    }
}
