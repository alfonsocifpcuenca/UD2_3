using Ejercicios_UD2_3.Interfaces;

namespace Ejercicios_UD2_3.Entities
{
    public class General : Persona, IAtacable
    {
        public int Estrategia { get; set; }
        public int Salud { get; private set; }

        public General(string nombre, DateTime fechaNacimiento, string lugar, int estrategia, int salud = 150)
            : base(nombre, fechaNacimiento, lugar)
        {
            Estrategia = estrategia;
            Salud = salud;
        }

        public void RecibirAtaque(int danio)
        {
            Salud -= danio;
            if (Salud < 0) Salud = 0;
            Console.WriteLine($"General {Nombre} ha recibido {danio} puntos de daño. Salud restante: {Salud}");
        }
    }
}