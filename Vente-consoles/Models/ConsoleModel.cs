using System.ComponentModel.DataAnnotations.Schema;

namespace Vente_consoles.Models
{
    public class ConsoleModel
    {
        //private int Id;
        private string nom;
        private int manufacturer;
        private string release_date;

        public string Release_date { get ; set ; }
        public int Id { get; set ; }
        public string Nom { get; set; }
        public int Manufacturer { get; set; }
    }
}
