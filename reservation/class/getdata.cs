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

        public string nom { get; set; }
        public string postNom;
        public string prenom;
        public string sexe;
        public string phone;
    }

    class showDatadb
    {
        public string nombd { get; set; }
        public string postNombd { get; set; }
        public string prenombd { get; set; }
        public string sexebd { get; set; }
        public string telbd { get; set; }
        public string datedb { get; set; }
        public string nbreJoursbd { get; set; }
        public string typeChambrebd { get; set; }
        public string categorieChbrebd { get; set; }
        public string numChambrebd { get; set; }
        public string montantPayebd { get; set; }
    }

    class getDonneeEntree
    {
        public void DonnerEntrer()
        {
            /*reserver rsver = new reserver();
            string DatabdNom = rsver.txtnom.Text;
            string DatabdPostNom = txtpostnom.Text;
            string DatabdPrenom = txtprenom.Text;
            string Databdtel = txtphone.Text;
            string Databdsexe = txtsexe.Text;
            string DatabdDatePrevu = dateTimePicker1.Text;
            int DatabdNombreJours = int.Parse(txtNbreJrs.Text);
            string DatabdTypeChambre = txtTypeChambre.Text;
            int DatabdNumChambre = int.Parse(txtNumChbre.Text);
            decimal Databdmontant = decimal.Parse(txtmontant.Text);
            string DatabdnomCategorie = txtCategorieChbre.Text;*/
        }
    }
}


