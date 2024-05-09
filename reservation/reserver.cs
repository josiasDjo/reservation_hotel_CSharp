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

namespace reservation
{

    public partial class reserver : Form
    {
        public reserver()
        {

            InitializeComponent();

            //afficherData();
        }


        private void reserver_Load(object sender, EventArgs e)
        {
            
        }
        
        
        public void afficherData()
        {
            connxion_bd sqlconn = new connxion_bd();
            try
            {
                sqlconn.sendConn();
                sqlconn.reqSql.Open();
                string reqSelect = "SELECT * FROM tclients";

                using (SqlCommand cmd = new SqlCommand(reqSelect, sqlconn.reqSql))
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
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Echec !! " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Finaly!! ");
                if (sqlconn.reqSql != null)
                {
                    sqlconn.reqSql.Close();
                }               
            }
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
            connxion_bd sqlconn = new connxion_bd();

            try
            {

                string bdNom = txtnom.Text;
                string bdPostNom = txtpostnom.Text;
                string bdPrenom = txtprenom.Text;
                string bdtel = txtphone.Text;
                string bdDate = dateTimePicker1.Text;
                string bdTypeChambre = txtTypeChambre.Text;
                string bdmontant = txtmontant.Text;
                string bdnumChambre = txtnumChambre.Text;

                string querryInsert = "INSERT INTO [dbo].[tClient] (nom, postNom, prenom, tel) VALUES (@Nom, @PostNom, @Prenom, @Tel) ";

                sqlconn.sendConn();
                sqlconn.reqSql.Open();
                using (SqlCommand command = new SqlCommand(querryInsert, sqlconn.reqSql))
                {
                    command.Parameters.AddWithValue("@Nom", bdNom);
                    command.Parameters.AddWithValue("@PostNom", bdPostNom);
                    command.Parameters.AddWithValue("@Prenom", bdPrenom);
                    command.Parameters.AddWithValue("@Tel", bdtel);

                        
                    command.ExecuteNonQuery();
                }               
           
                MessageBox.Show("Enregistrement réussi !! ");
                sqlconn.reqSql.Close();
            } catch (Exception exc)
            {
                MessageBox.Show("Une erreur est survenue ! " + exc);
            }
            finally
            {
                //             
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
