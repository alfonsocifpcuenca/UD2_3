using Ejercicios_UD2_3.Interfaces;

namespace Ejercicios_UD2_3.Entities
{
    public class Soldado : Persona, IAtacable
    {
        public int Salud { get; private set; }

        public Soldado(string nombre, DateTime fechaNacimiento, string lugar, int salud = 100)
            : base(nombre, fechaNacimiento, lugar)
        {
            Salud = salud;
        }

        public void RecibirAtaque(int danio)
        {
            Salud -= danio;
            if (Salud < 0) Salud = 0;
            Console.WriteLine($"{Nombre} ha recibido {danio} puntos de daño. Salud restante: {Salud}");
        }
    }
}