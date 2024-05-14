// DataDisplayer.cs
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using connexionDB;

namespace reservation
{
    public class DataDisplayer
    {
        public  void DisplayData()
        {
            //dataGridView.DataSource = dataTable;

            connxion_bd sqlconn = new connxion_bd();
            reserver rsv = new reserver();
            DataGridView dtg = new DataGridView();

            //DataTable MesDonnes = ();

            sqlconn.sendConn();
            try
            {
                string reqSelect1 = "SELECT * FROM [dbo].[tclient]";
                string reqSelect2 = "SELECT * FROM[dbo].[tChambre]";
                string reqSelect3 = "SELECT * FROM[dbo].[tCategorieCh]";
                string reqSelect4 = "SELECT * FROM[dbo].[tPayement]";
                string reqSelect5 = "SELECT * FROM[dbo].[tReservation]";

                int indexNouvelleLigne = dtg.Rows.Add();
                //rsv.AfficherDonneesDansDataGridView(indexNouvelleLigne);

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
                            DataGridViewRow nouvelleLigne = dtg.Rows[indexNouvelleLigne];

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
                                DataGridViewRow nouvelleLigne = dtg.Rows[indexNouvelleLigne];

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
                                DataGridViewRow nouvelleLigne = dtg.Rows[indexNouvelleLigne];

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
                                DataGridViewRow nouvelleLigne = dtg.Rows[indexNouvelleLigne];

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
                                DataGridViewRow nouvelleLigne = dtg.Rows[indexNouvelleLigne];

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
                //MessageBox.Show("Finaly!! ");
                if (sqlconn.reqSql != null && sqlconn.reqSql.State == ConnectionState.Open)
                {
                    sqlconn.reqSql.Close();
                }
            }
        }
    }
}


