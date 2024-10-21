namespace Ejercicios_UD2_3.Entities
{
    public class Ejercito
    {
        public List<Batallon> Batallones { get; private set; } = new List<Batallon>();
        public General General { get; private set; }

        public string NombreEjercito { get; set; }

        public Ejercito(string nombreEjercito)
        {
            NombreEjercito = nombreEjercito;
        }

        public void EstablecerGeneral(General general)
        {
            General = general;
            Console.WriteLine($"El General {general.Nombre} ha sido asignado al ejército {NombreEjercito}");
        }

        public void AgregarBatallon(Batallon batallon)
        {
            Batallones.Add(batallon);
            Console.WriteLine($"Batallón {batallon.NombreBatallon} agregado al ejército {NombreEjercito}");

        }
    }
}
