using System.Runtime.CompilerServices;

namespace Lessoni
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            bool mybool=false;
            TestClass<string> testClass = new TestClass<string>();  
            testClass.Meth("fhf",ref mybool);
            testClass.Method(ref mybool);
           
                            
        }
        
        
    }
}