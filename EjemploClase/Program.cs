namespace EjemploClase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase Persona
            Persona persona = new Persona("Juan", 30);

            // Mostrar la información de la persona
            Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");

            // Cambiar el nombre y la edad de la persona
            persona.Nombre = "Pedro";
            persona.Edad = 35;

            // Mostrar la información actualizada de la persona
            Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");
        }
    }
}   
