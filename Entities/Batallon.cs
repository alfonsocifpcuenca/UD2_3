namespace Ejercicios_UD2_3.Entities
{
    public class Batallon
    {
        public List<Soldado> Soldados { get; private set; } = new List<Soldado>();
        public string NombreBatallon { get; set; }

        public Batallon(string nombreBatallon)
        {
            NombreBatallon = nombreBatallon;
        }

        public void AgregarSoldado(Soldado soldado)
        {
            Soldados.Add(soldado);
            Console.WriteLine($"Soldado {soldado.Nombre} agregado al batallón {NombreBatallon}");
        }
    }
}