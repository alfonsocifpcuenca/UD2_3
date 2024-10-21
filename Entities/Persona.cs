namespace Ejercicios_UD2_3.Entities
{
    public class Persona
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Lugar { get; set; }

        public Persona(string nombre, DateTime fechaNacimiento, string lugar)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Lugar = lugar;
        }
    }
}