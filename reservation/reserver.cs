using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using connexionDB;
using insererDonnee;
using getdataNames;
using affichageDonnee;

namespace reservation
{

    public partial class reserver : Form
    {
        public reserver()
        {

            InitializeComponent();

            afficherData();
        }


        private void reserver_Load(object sender, EventArgs e)
        {
            
        }
        
        
        public void afficherData()
        {
            showDatadb shwData = new showDatadb();
            dataGridView1.Rows.Add(
                shwData.nombd, 
                shwData.postNombd, 
                shwData.prenombd, 
                shwData.sexebd, 
                shwData.telbd, 
                shwData.datedb, 
                shwData.nbreJoursbd, 
                shwData.typeChambrebd, 
                shwData.categorieChbrebd,
                shwData.numChambrebd,
                shwData.montantPayebd
            );
        }

        private void OpenConnection()
        {
            throw new NotImplementedException();
        }

        private void txtTypeChambre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TypeChambre = txtTypeChambre.Text;
            string CategorieChbre = txtCategorieChbre.Text;
            int NbreJrs = int.Parse(txtNbreJrs.Text);



            if (TypeChambre == "Chambre à lit simple" && CategorieChbre == "Standard")
            {
                int montantTotal = NbreJrs * 30;
                txtmontant.Text = montantTotal.ToString(); 
            } else if (TypeChambre == "Chambre à lit simple" && CategorieChbre == "VIP")
            {
                int montantTotal = NbreJrs * 50;
                txtmontant.Text = montantTotal.ToString();
            } else if (TypeChambre == "Chambre à lit double" && CategorieChbre == "Standard")
            {
                int montantTotal = NbreJrs * 40;
                txtmontant.Text = montantTotal.ToString();
            }
            else if (TypeChambre == "Chambre à lit double" && CategorieChbre == "VIP")
            {
                int montantTotal = NbreJrs * 70;
                txtmontant.Text = montantTotal.ToString();
            } else
            {
                txtmontant.Text = "Valeur incorrecte ! ";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            sendEntree();
        }

        public void sendEntree()
        {
            string DatabdNom = txtnom.Text;
            string DatabdPostNom = txtpostnom.Text;
            string DatabdPrenom = txtprenom.Text;
            string Databdtel = txtphone.Text;
            string Databdsexe = txtsexe.Text;
            string DatabdDatePrevu = dateTimePicker1.Text;
            int DatabdNombreJours = int.Parse(txtNbreJrs.Text);
            string DatabdTypeChambre = txtTypeChambre.Text;
            int DatabdNumChambre = int.Parse(txtNumChbre.Text);
            decimal Databdmontant = decimal.Parse(txtmontant.Text);
            string DatabdnomCategorie = txtCategorieChbre.Text;

            getdata gdat = new getdata();
            DateTime currentDate = DateTime.Now;

            string datetoday = currentDate.ToString();
            gdat.bdNom = DatabdNom;
            gdat.bdPostNom = DatabdPostNom;
            gdat.bdPrenom = DatabdPrenom;
            gdat.bdtel = Databdtel;
            gdat.bdsexe = txtsexe.Text;
            gdat.bdDatePrevu = DatabdDatePrevu;
            gdat.bdNombreJours = DatabdNombreJours;
            gdat.bdTypeChambre = DatabdTypeChambre;
            gdat.bdNumChambre = DatabdNumChambre;
            gdat.bdmontant = Databdmontant;
            gdat.bdnomCategorie = DatabdnomCategorie;
            gdat.bdDatePayement = datetoday;


            err1.Text = gdat.bdNom;
            err2.Text = gdat.bdPostNom;


            insertInDb isrData = new insertInDb();
            isrData.dataInsert();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
