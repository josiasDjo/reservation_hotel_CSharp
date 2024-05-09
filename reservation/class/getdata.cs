using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reservation;

namespace getdataNames
{
    class getdata
    {
        reserver rsver = new reserver();
        public string bdNom { get; set; }
        public string bdPostNom { get; set; }
        public string bdPrenom { get; set; }
        public string bdtel { get; set; }
        public string bdsexe { get; set; }
        public string bdDatePrevu { get; set; }
        public string bdTypeChambre { get; set; }
        public string bdmontant { get; set; }
        public string bdNumChambre { get; set; }
        public string bdnomCategorie { get; set; }
        public string bdDatePayement { get; set; }
        public string bdNombreJours { get; set; }
    }
}
