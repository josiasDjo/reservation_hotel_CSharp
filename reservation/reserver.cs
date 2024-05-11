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
            checkData();
        }
        public void checkData()
        {
            getdata getDo = new getdata();
            sendDonnee sd = new sendDonnee();
            DateTime dat = DateTime.Now;
            string DateR = dat.ToString("dddd, dd MMMM yyyy HH:mm:ss");

            string nom = txtnom.Text;
            string postNom = txtpostnom.Text;
            string prenom = txtprenom.Text;
            string sexe = txtsexe.Text;
            string phone = txtphone.Text;
            int bdnumChambre = int.Parse(txtNumChbre.Text);
            string bdtypeChambre = txtTypeChambre.Text;
            string bdNomCategorie = txtCategorieChbre.Text;
            string bddatePrevu = dateTimePicker1.Text;
            int bdnobreJours = int.Parse(txtNbreJrs.Text);
            decimal bdmontant = decimal.Parse(txtmontant.Text);
            string bddatePaye = DateR;


            if (getDo.nom == "")
            {
                MessageBox.Show("Le nom est null");
            }
            else
            {
                MessageBox.Show("Le nom  est : " + nom + postNom + prenom + sexe + phone);
                connxion_bd sqlconn = new connxion_bd();

                sqlconn.sendConn();

                try
                {

                    string querryInsert1 = "INSERT INTO [dbo].[tClient] (nom, postNom, prenom, sexe, tel) VALUES (@Nom, @PostNom, @Prenom, @Sexe, @Tel) ";

                    SqlCommand command1 = new SqlCommand(querryInsert1, sqlconn.reqSql);

                    command1.Parameters.AddWithValue("@Nom", nom);
                    command1.Parameters.AddWithValue("@PostNom", postNom);
                    command1.Parameters.AddWithValue("@Prenom", prenom);
                    command1.Parameters.AddWithValue("@Sexe", sexe);
                    command1.Parameters.AddWithValue("@Tel", phone);

                    command1.ExecuteNonQuery();


                    string querryInsert2 = "INSERT INTO [dbo].[tChambre] (numChambre, typeChambre) VALUES (@numChambre, @typeChambre) ";

                    SqlCommand command2 = new SqlCommand(querryInsert2, sqlconn.reqSql);
                    command2.Parameters.AddWithValue("@numChambre", bdnumChambre);
                    command2.Parameters.AddWithValue("@typeChambre", bdtypeChambre);
                                   
                    command2.ExecuteNonQuery();


                    string querryInsert3 = "INSERT INTO [dbo].[tCategorieCh] (nomCategorie) VALUES (@nomCategorie) ";

                    SqlCommand command3 = new SqlCommand(querryInsert3, sqlconn.reqSql);
                    command3.Parameters.AddWithValue("@nomCategorie", bdNomCategorie);

                    command3.ExecuteNonQuery();


                    string querryInsert4 = "INSERT INTO [dbo].[tPayement] (montant, datePayement) VALUES (@montant, @datePayement) ";

                    SqlCommand command4 = new SqlCommand(querryInsert4, sqlconn.reqSql);
                    command4.Parameters.AddWithValue("@montant", bdmontant);
                    command4.Parameters.AddWithValue("@datePayement", bddatePaye);

                    command4.ExecuteNonQuery();


                    string querryInsert5 = "INSERT INTO [dbo].[tReservation] (datePrevu, nombreJours) VALUES (@datePrevu, @nombreJours) ";

                    SqlCommand command5 = new SqlCommand(querryInsert5, sqlconn.reqSql);
                    command5.Parameters.AddWithValue("@datePrevu", bddatePrevu);
                    command5.Parameters.AddWithValue("@nombreJours", bdnobreJours);

                    command5.ExecuteNonQuery();



                    MessageBox.Show("Enregistrement réussi !! ");
                    sqlconn.reqSql.Close();

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Une erreur est survenue ! " + exc);
                }
                finally
                {
                    if (sqlconn.reqSql != null && sqlconn.reqSql.State == ConnectionState.Open)
                    {
                        sqlconn.reqSql.Close();
                    }
                }
            }
        }
        public class sendDonnee
        {
            
            public string nom { get; set; }
            public string postNom { get; set; }
            public string prenom { get; set; }
            public string sexe { get; set; }
            public string phone { get; set; }

            public void afficher()
            {
                MessageBox.Show("Nom encapsuler  :   " + nom + postNom + prenom + sexe + phone);
                
            }
        }
     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }




}
