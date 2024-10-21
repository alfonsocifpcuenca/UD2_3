using Ejercicios_UD2_3.Entities;

namespace Ejercicios_UD2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear General
            General general = new General("Napoleon", new DateTime(1769, 8, 15), "Ajaccio, Francia", 95);

            // Crear Ejercito
            Ejercito ejercito = new Ejercito("Gran Ejército");
            ejercito.EstablecerGeneral(general);

            // Crear Batallón
            Batallon batallon = new Batallon("Infantería 1");

            // Crear Soldados
            Soldado soldado1 = new Soldado("John", new DateTime(1990, 5, 12), "New York, USA");
            Soldado soldado2 = new Soldado("Carlos", new DateTime(1995, 11, 25), "Madrid, España");

            // Agregar Soldados al Batallón
            batallon.AgregarSoldado(soldado1);
            batallon.AgregarSoldado(soldado2);

            // Agregar Batallón al Ejército
            ejercito.AgregarBatallon(batallon);

            // Crear Enemigo
            Enemigo enemigo = new Enemigo("Dragón", 50);

            // El enemigo ataca al soldado y al general
            enemigo.Atacar(soldado1);
            enemigo.Atacar(general);
        }
    }
}
