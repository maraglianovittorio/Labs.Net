
namespace Clases
{
    public class A
    {
        public string NombreInstancia { get; set; }
        public A()
        {
            this.NombreInstancia = "Instancia por defecto";
        }
        public A(string nombreInstancia)
        {
            this.NombreInstancia = nombreInstancia;
        }
        public void MostrarNombre()
        {
            Console.WriteLine($"Nombre de la instancia: {this.NombreInstancia}");
        }

        public void M1()
        {
            Console.WriteLine($"M1 de {this.NombreInstancia}");

        }

        internal void M2()
        {
            Console.WriteLine($"M2 de {this.NombreInstancia}");
        }

        public void M3()
        {
            Console.WriteLine($"M3 de {this.NombreInstancia}");
        }
    }
}
