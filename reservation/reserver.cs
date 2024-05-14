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

                    string querryInsert = @"INSERT INTO[dbo].[tCategorieCh] (nomCategorie) VALUES(@nomCategorie);
                                            INSERT INTO[dbo].[tChambre] (numChambre, typeChambre) VALUES(@numChambre, @typeChambre);
                                            INSERT INTO [dbo].[tPayement] (montant, datePayement) VALUES(@montant, @datePayement);
                                            INSERT INTO [dbo].[tclient] (nom, postNom, prenom, sexe, tel) VALUES (@Nom, @PostNom, @Prenom, @Sexe, @Tel);  
                                            INSERT INTO [dbo].[tReservation] (datePrevu, nombreJours) VALUES (@datePrevu, @nombreJours) ";


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
            DataDisplayer afficherData = new DataDisplayer();
            //afficherData.DisplayData();
            connxion_bd sqlconn = new connxion_bd();
            sqlconn.sendConn();
            try
            {
                string reqSelect1 = "SELECT * FROM [dbo].[tclient]";
                string reqSelect2 = "SELECT * FROM[dbo].[tChambre]";
                string reqSelect3 = "SELECT * FROM[dbo].[tCategorieCh]";
                string reqSelect4 = "SELECT * FROM[dbo].[tPayement]";
                string reqSelect5 = "SELECT * FROM[dbo].[tReservation]";

                SqlCommand cmdOne = new SqlCommand(reqSelect1, sqlconn.reqSql);

                SqlDataReader readLigne = cmdOne.ExecuteNonQuery()
                int indexNouvelleLigne = dataGridView1.Rows.Add();

                using (SqlCommand cmd = new SqlCommand(reqSelect1, sqlconn.reqSql))
                {
                    //from tclient
                    using (SqlDataReader readDonnee = cmd.ExecuteReader())
                    {
                        while (readDonnee.Read())
                        {
                            string nombd = readDonnee["nom"].ToString();
                            string postNombd = readDonnee["postNom"].ToString();
                            string prenombd = readDonnee["prenom"].ToString();
                            string sexebd = readDonnee["sexe"].ToString();
                            string telbd = readDonnee["tel"].ToString();

                            // Accéder à la nouvelle ligne ajoutée
                            DataGridViewRow nouvelleLigne = dataGridView1.Rows[indexNouvelleLigne];

                            // Définir les valeurs pour chaque cellule de la nouvelle ligne
                            nouvelleLigne.Cells["colNom"].Value = nombd;
                            nouvelleLigne.Cells["colPostNom"].Value = postNombd;
                            nouvelleLigne.Cells["colPrenom"].Value = prenombd;
                            nouvelleLigne.Cells["ColSexe"].Value = sexebd;
                            nouvelleLigne.Cells["ColPhone"].Value = telbd;

                        }
                        readDonnee.Close();
                        readDonnee.Dispose();
                        cmd.Dispose();
                    }





                    using (SqlCommand cmd2 = new SqlCommand(reqSelect2, sqlconn.reqSql))
                    {
                        //from tchambre
                        using (SqlDataReader readDonnee = cmd2.ExecuteReader())
                        {
                            while (readDonnee.Read())
                            {
                                string typeChambrebd = readDonnee["typeChambre"].ToString();
                                string numChambrebd = readDonnee["numChambre"].ToString();

                                //int indexNouvelleLigne = dataGridView1.Rows.Add();

                                // Accéder à la nouvelle ligne ajoutée
                                DataGridViewRow nouvelleLigne = dataGridView1.Rows[indexNouvelleLigne];

                                // Définir les valeurs pour chaque cellule de la nouvelle ligne
                                nouvelleLigne.Cells["ColTypeChambre"].Value = typeChambrebd;
                                nouvelleLigne.Cells["NumChambre"].Value = numChambrebd;

                            }
                            readDonnee.Close();
                            readDonnee.Dispose();
                            cmd2.Dispose();
                        }
                    }
                    using (SqlCommand cmd3 = new SqlCommand(reqSelect3, sqlconn.reqSql))
                    {
                        //from tcategorieCh
                        using (SqlDataReader readDonnee = cmd3.ExecuteReader())
                        {
                            while (readDonnee.Read())
                            {
                                string categorieChbrebd = readDonnee["nomCategorie"].ToString();


                                //int indexNouvelleLigne = dataGridView1.Rows.Add();

                                // Accéder à la nouvelle ligne ajoutée
                                DataGridViewRow nouvelleLigne = dataGridView1.Rows[indexNouvelleLigne];

                                // Définir les valeurs pour chaque cellule de la nouvelle ligne
                                nouvelleLigne.Cells["ColCategorieChbre"].Value = categorieChbrebd;

                            }
                            readDonnee.Close();
                            readDonnee.Dispose();
                            cmd3.Dispose();
                        }
                    }
                    using (SqlCommand cmd4 = new SqlCommand(reqSelect4, sqlconn.reqSql))
                    {
                        //form tPayement
                        using (SqlDataReader readDonnee = cmd4.ExecuteReader())
                        {
                            while (readDonnee.Read())
                            {
                                string montantPayebd = readDonnee["montant"].ToString();


                                //int indexNouvelleLigne = dataGridView1.Rows.Add();

                                // Accéder à la nouvelle ligne ajoutée
                                DataGridViewRow nouvelleLigne = dataGridView1.Rows[indexNouvelleLigne];

                                // Définir les valeurs pour chaque cellule de la nouvelle ligne
                                nouvelleLigne.Cells["ColMontant"].Value = montantPayebd;

                            }
                            readDonnee.Close();
                            readDonnee.Dispose();
                            cmd4.Dispose();
                        }
                    }
                    using (SqlCommand cmd5 = new SqlCommand(reqSelect5, sqlconn.reqSql))
                    {
                        //from tReservation
                        using (SqlDataReader readDonnee = cmd5.ExecuteReader())
                        {
                            while (readDonnee.Read())
                            {
                                string datedb = readDonnee["datePrevu"].ToString();
                                string nbreJourdb = readDonnee["nombreJours"].ToString();

                                //int indexNouvelleLigne = dataGridView1.Rows.Add();

                                // Accéder à la nouvelle ligne ajoutée
                                DataGridViewRow nouvelleLigne = dataGridView1.Rows[indexNouvelleLigne];

                                // Définir les valeurs pour chaque cellule de la nouvelle ligne
                                nouvelleLigne.Cells["ColDate"].Value = datedb;
                                nouvelleLigne.Cells["ColNbreJrs"].Value = nbreJourdb;

                            }
                            readDonnee.Close();
                            readDonnee.Dispose();
                            cmd5.Dispose();
                        }
                    }
                }
                indexNouvelleLigne++;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Echec !! " + ex.Message);
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
        public DataGridView DataGridViewInstance
        {
            get { return dataGridView1; }
        }
        public void AfficherDonneesDansDataGridView(DataTable dataTable)
        {
            dataGridView1.DataSource = dataTable;
        }
    }




}
