using System.ComponentModel.DataAnnotations.Schema;

namespace Vente_consoles.Models
{
    public class Console
    {
        public int id;
        public string nom;
        public string spec_tech;
        public string construct;

        public Console(int id,string nom,string spec_tech,string construct)
        {
            this.id = id;
            this.nom = nom;
            this.spec_tech = spec_tech;
            this.construct = construct;

        }
        public int getId() { return id; }
        public string getNom() { return nom; }
        public string getSpec_tech() {  return spec_tech; }
        public string getConstruct() { return construct; }
        public int setId(int id) { this.id = id;
        return id; }
        public string setNom(string nom) { this.nom = nom;
            return nom;
        }
        public string setSpec_tech(string spec_tech) { this.spec_tech = spec_tech; 
            return spec_tech; 
        }
        public string setConstruct(string construct) { this.construct = construct; 
            return this.construct; 
        }

        
    }
}
