using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessoni
{
    internal class TestClass<T>
    {
        
        public T Meth<T>(T value,ref bool mybool)
        {
            if(value is string){
                mybool = true;
            }
            return value;

        }

        public void Method(ref bool mybool)
        {
            if (mybool)
            {
                Console.WriteLine(mybool);
            }
            else
            {
                Console.WriteLine(mybool);
            }
        }
    }
}
