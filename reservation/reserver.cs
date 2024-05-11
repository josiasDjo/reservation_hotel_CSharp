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

        }
        public void checkData()
        {
            getdata getDo = new getdata();
            insertInDb isr = new insertInDb();
            sendDonnee sd = new sendDonnee();

            string nomR = txtnom.Text;
            string postNomR = txtpostnom.Text;
            string prenomR = txtprenom.Text;
            string sexeR = txtsexe.Text;
            string phoneR = txtphone.Text;

            if (getDo.nom == "")
            {
                MessageBox.Show("Le nom est null");
            }
            else
            {
                MessageBox.Show("Le nom  est : " + nomR);
                sd.send();
                //isr.dataInsert();
            }
        }
        partial class sendDonnee
        {
            public void send()
            {
                reserver rsv = new reserver();
                rsv.checkData();
                string nom = rsv.nomR;
                string postNom = rsv.txtpostnom.Text;
                string prenom = rsv.txtprenom.Text;
                string sexe = rsv.txtsexe.Text;
                string phone = rsv.txtphone.Text;

                MessageBox.Show("Données entrée : " + nom + postNom + prenom + sexe + phone);
            }
        }
                  
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }

}
