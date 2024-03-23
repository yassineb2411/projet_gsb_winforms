using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3aApp
{
    public class RapportClass
    {
        public int id { get; set; }
        public DateTime date { get; set; } 
        public string motif { get; set; }
        public string bilan { get; set; }
        public string idVisiteur { get; set; }
        public int idMedecin { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
    }
}
