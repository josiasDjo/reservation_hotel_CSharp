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
using reservation;



namespace reservation
{

    public partial class reserver : Form
    {
        public reserver()
        {

            InitializeComponent();
            afficherDonnee();
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
            }
            else if (TypeChambre == "Chambre à lit simple" && CategorieChbre == "VIP")
            {
                int montantTotal = NbreJrs * 50;
                txtmontant.Text = montantTotal.ToString();
            }
            else if (TypeChambre == "Chambre à lit double" && CategorieChbre == "Standard")
            {
                int montantTotal = NbreJrs * 40;
                txtmontant.Text = montantTotal.ToString();
            }
            else if (TypeChambre == "Chambre à lit double" && CategorieChbre == "VIP")
            {
                int montantTotal = NbreJrs * 70;
                txtmontant.Text = montantTotal.ToString();
            }
            else
            {
                txtmontant.Text = "Valeur incorrecte ! ";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //
        }
        public void checkData()
        {
            getdata getDo = new getdata();
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


            if (nom == "" || postNom == "" || prenom == "")
            {
                MessageBox.Show("Tous les champs sont réquis ! ");
            }
            else
            {
                //MessageBox.Show("Le nom  est : " + nom + postNom + prenom + sexe + phone);
                connxion_bd sqlconn = new connxion_bd();

                sqlconn.sendConn();

                try
                {

                    string querryInsert = "INSERT INTO[dbo].[tReserver] (nom, postNom, prenom, sexe, tel,nomCategorie, numChambre, typeChambre, montant, datePayement, datePrevu, nombreJours) VALUES(@nom, @postNom, @prenom, @sexe, @tel,@nomCategorie, @numChambre, @typeChambre, @montant, @datePayement, @datePrevu, @nombreJours)";


                    SqlCommand command = new SqlCommand(querryInsert, sqlconn.reqSql);

                    command.Parameters.AddWithValue("@nomCategorie", bdNomCategorie);

                    command.Parameters.AddWithValue("@numChambre", bdnumChambre);
                    command.Parameters.AddWithValue("@typeChambre", bdtypeChambre);

                    command.Parameters.AddWithValue("@montant", bdmontant);
                    command.Parameters.AddWithValue("@datePayement", bddatePaye);

                    command.Parameters.AddWithValue("@Nom", nom);
                    command.Parameters.AddWithValue("@PostNom", postNom);
                    command.Parameters.AddWithValue("@Prenom", prenom);
                    command.Parameters.AddWithValue("@Sexe", sexe);
                    command.Parameters.AddWithValue("@Tel", phone);

                    command.Parameters.AddWithValue("@datePrevu", bddatePrevu);
                    command.Parameters.AddWithValue("@nombreJours", bdnobreJours);


                    command.ExecuteNonQuery();


                    MessageBox.Show("Enregistrement réussi !! ");
                    sqlconn.reqSql.Close();
                    command.Dispose();
                    afficherDonnee();

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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void afficherDonnee()
        {
                connxion_bd sqlconn = new connxion_bd();
                sqlconn.sendConn();
                try
                {
                string req = "SELECT * FROM tReserver";

                using (SqlCommand command = new SqlCommand(req, sqlconn.reqSql))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string idReserverbd = reader["idReserver"].ToString();
                            string nombd = reader["nom"].ToString();
                            string postNombd = reader["postNom"].ToString();
                            string prenombd = reader["prenom"].ToString();
                            string sexebd = reader["sexe"].ToString();
                            string telbd = reader["tel"].ToString();

                            string nomCategoriebd = reader["nomCategorie"].ToString();

                            string numChambrebd = reader["numChambre"].ToString();
                            string typeChambrebd = reader["typeChambre"].ToString();

                            string montantbd = reader["montant"].ToString();
                            //string datePayementbd = reader["datePayement"].ToString();

                            string datePrevubd = reader["datePrevu"].ToString();
                            string nombreJoursbd = reader["nombreJours"].ToString();

                            dataGridView1.Rows.Add(idReserverbd, nombd, postNombd, prenombd, sexebd, telbd, nomCategoriebd, numChambrebd, typeChambrebd, montantbd, datePrevubd, nombreJoursbd);

                        }
                    }
                }
                
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Echec !! " + ex.Message);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Erreur : " + exc);
                }
                finally
                {
                    if (sqlconn.reqSql != null && sqlconn.reqSql.State == ConnectionState.Open)
                    {
                        sqlconn.reqSql.Close();
                    }
                }
            }



        private void button1_Click_1(object sender, EventArgs e)
        {
            checkData();
        }

        //Afficher les données dans l" tableau ! 
        public DataGridView getDataTble
        {
            get { return dataGridView1; }
        }
        public void AfficherDonneesDansDataGridView(DataTable dataTable)
        {
            dataGridView1.DataSource = dataTable;
        }
    }
}
