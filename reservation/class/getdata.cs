using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reservation;

namespace getdataNames
{
    public class getdata
    {
        reserver rsver = new reserver();


        private string _nom;
        public string nom
        {
            get
            {
                return _nom;
            } 
            set
            {
                _nom = value;
            }
        }           


        public string postNom { get; set; }
        public string prenom { get; set; }
        public string sexe { get; set; }
        public string phone { get; set; }
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


