using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp08_Genericos
{
    class MetodoGenerico
    {

        public static T Maximo<T>(T valueA, T valueB) where T : IComparable<T>
        {
            return valueA.CompareTo(valueB) > 0 ? valueA:valueB;
        }
    }
}
