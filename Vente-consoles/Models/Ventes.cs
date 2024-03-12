namespace Vente_consoles.Models
{
    public class Ventes
    {
        //private int Id;
        private int year;
        private float nb_ventes;
        private string id_console;

        public int Id { get ; set ; }
        public int Year { get ; set; }
        public float Nb_ventes { get => nb_ventes; set => nb_ventes = value; }
        public string Id_console { get => id_console; set => id_console = value; }
    }
}
