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
            string valeur_combo = txtTypeChambre.Text;


            if (valeur_combo == "Chambre single")
            {
                txtmontant.Text = "30$"; 
            } else if (valeur_combo == "Chambre double")
            {
                txtmontant.Text = "40$";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            sendEntree();           
        }

        public void sendEntree()
        {
            getdata gdat = new getdata();
            DateTime currentDate = DateTime.Now;

            string datetoday = currentDate.ToString();
            gdat.bdNom = txtnom.Text;
            gdat.bdPostNom = txtpostnom.Text;
            gdat.bdPrenom = txtprenom.Text;
            gdat.bdtel = txtphone.Text;
            gdat.bdsexe = txtsexe.Text;
            gdat.bdDatePrevu = dateTimePicker1.Text;
            gdat.bdNombreJours = txtNbreJrs.Text;
            gdat.bdTypeChambre = txtTypeChambre.Text;
            gdat.bdNumChambre = txtNumChbre.Text;
            gdat.bdmontant = txtmontant.Text;
            gdat.bdNumChambre = txtNbreJrs.Text;
            gdat.bdDatePayement = datetoday;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
