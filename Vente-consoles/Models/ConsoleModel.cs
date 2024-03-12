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



        /*public int getId() { return Id; }
        public string getNom() { return nom; }
        public int getManufacturer() { return manufacturer; }
        public int setId(int id) { this.Id = id;
        return id; }
        public string setNom(string nom) { this.nom = nom;
            return nom;
        }
        public int setManufacturer(int manufacturer) { this.manufacturer = manufacturer; 
            return this.manufacturer; 
        }*/


    }
}
