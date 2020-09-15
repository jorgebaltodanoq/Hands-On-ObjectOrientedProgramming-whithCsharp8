using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp08_Genericos
{
    class ClaseGenerica<T>
    {

        T obj1; // Variable de tipo T
        
        public ClaseGenerica(T obj1)
        {
            this.obj1 = obj1;
        }

        //Metodo para saber que tipo de dato estoy pasando
        public void printType()
        {
            Console.WriteLine($"El T es de tipo :{typeof(T)}");
        }

        public T GetAdd() => obj1;
        




    }
}
