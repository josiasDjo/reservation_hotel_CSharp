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
            string connexion = "Data Source=DJODEV;Initial Catalog=db_reservaton;Integrated Security=True";

            try
            {
            SqlConnection sqlconn = new SqlConnection(connexion);


            sqlconn.Open();

            string reqSelect = "SELECT * FROM tclients";


                using (SqlCommand cmd = new SqlCommand(reqSelect, sqlconn))
                {
                    using (SqlDataReader readDonnee = cmd.ExecuteReader())
                    {
                        while (readDonnee.Read())
                        {
                            string nombd = readDonnee["nom"].ToString();
                            string postNombd = readDonnee["postNom"].ToString();
                            string prenombd = readDonnee["prenom"].ToString();
                            string telbd = readDonnee["tel"].ToString();
                            string emailbd = readDonnee["email"].ToString();
                            string datebd = readDonnee["date"].ToString();
                            string typeChambrebd = readDonnee["typeChamnbre"].ToString();
                            string numChambre = readDonnee["numChambre"].ToString();
                            string montant = readDonnee["montant"].ToString();

                            dataGridView1.Rows.Add(nombd, postNombd, prenombd, telbd, emailbd, datebd, typeChambrebd, numChambre, montant);
                        }
                        readDonnee.Close();
                        readDonnee.Dispose();
                        cmd.Dispose();

                    }
                }

                MessageBox.Show("Réussi !! ");

                sqlconn.Close();
            }
            catch
            {
                MessageBox.Show("Echec !! ");
            }
            finally
            {
                MessageBox.Show("Finaly!! ");
            }
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
            string connexion = "Data Source=DJODEV;Initial Catalog=db_reservaton;Integrated Security=True";
            try
            {

                SqlConnection sqlconn = new SqlConnection(connexion);

                sqlconn.Open();

                string bdNom = txtnom.Text;
                string bdPostNom = txtpostnom.Text;
                string bdPrenom = txtprenom.Text;
                string bdtel = txtphone.Text;
                string bdEmail = txtemail.Text;
                string bdDate = dateTimePicker1.Text;
                string bdTypeChambre = txtTypeChambre.Text;
                string bdmontant = txtmontant.Text;
                string bdnumChambre = txtnumChambre.Text;

                string querryInsert = "INSERT INTO tclient (nom, postNom, prenom, tel, email) VALUES ('" + bdNom + "', '" + bdPostNom + "', '"+ bdPrenom+"', '"+ bdtel +"', '"+ bdEmail+"') ";

                string querryInsert2 = "INSERT INTO tChambre (numChambre, numEtage, typeChambre) ";

                string querryInsert3 = "INSERT INTO tReservation (etat, date)";

                string querryInsert4 = "INSERT INTO tPayement (methodePaye, montant, datePaye)";

                SqlCommand cmd = new SqlCommand(querryInsert,sqlconn);
                SqlCommand cmd2 = new SqlCommand(querryInsert2, sqlconn);
                SqlCommand cmd3 = new SqlCommand(querryInsert3, sqlconn);
                SqlCommand cmd4 = new SqlCommand(querryInsert4, sqlconn);

                sqlconn.Close();
                MessageBox.Show("Enregistrement réussi !! ");
            } catch (Exception exc)
            {
                MessageBox.Show("Une erreur est survenue ! ");
            }
            finally
            {
                //sqlConn.Close(); 
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
