

namespace Clases
{
    public class B:A
    {
        public B(string nombreInstanciaB) : base(nombreInstanciaB)
        {
        }
        public void M4()
        {
            Console.WriteLine("Metodo del hijo invocado");
            this.M2();
        }
    
    }

}
