using Ejercicios_UD2_3.Interfaces;

namespace Ejercicios_UD2_3.Entities
{
    public class Enemigo
    {
        public string Nombre { get; set; }
        public int Poder { get; set; }

        public Enemigo(string nombre, int poder)
        {
            Nombre = nombre;
            Poder = poder;
        }

        // Método para atacar un objeto IAtacable
        public void Atacar(IAtacable objetivo)
        {
            Console.WriteLine($"{Nombre} está atacando con un poder de {Poder}!");
            objetivo.RecibirAtaque(Poder);
        }
    }
}
