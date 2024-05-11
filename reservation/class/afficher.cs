using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reservation;
using System.Data.SqlClient;
using connexionDB;
using System.Windows.Forms;
using getdataNames;
using System.Data;

namespace affichageDonnee
{
    class afficher
    {
        public void afficheDonnee()
        {
            connxion_bd sqlconn = new connxion_bd();
            reserver rsv = new reserver();
            showDatadb shwData = new showDatadb();

            try
            {
                sqlconn.sendConn();
                string reqSelect = "SELECT * FROM [dbo].[tClient]";

                using (SqlCommand cmd = new SqlCommand(reqSelect, sqlconn.reqSql))
                {
                    using (SqlDataReader readDonnee = cmd.ExecuteReader())
                    {
                        while (readDonnee.Read())
                        {
                            shwData.nombd = readDonnee["nom"].ToString();
                            shwData.postNombd = readDonnee["postNom"].ToString();
                            shwData.prenombd = readDonnee["prenom"].ToString();
                            shwData.sexebd = readDonnee["sexe"].ToString();
                            shwData.telbd = readDonnee["tel"].ToString();
                            shwData.datedb = readDonnee["datePrevu"].ToString();
                            shwData.nbreJoursbd = readDonnee["nombreJours"].ToString();
                            shwData.typeChambrebd = readDonnee["typeChambre"].ToString();
                            shwData.categorieChbrebd = readDonnee["nomCategorie"].ToString();
                            shwData.numChambrebd = readDonnee["numChambre"].ToString();
                            shwData.montantPayebd = readDonnee["montant"].ToString();

                            //dataGridView1.Rows.Add(nombd, postNombd, prenombd, sexebd, telbd, datedb, nbreJoursbd, typeChambrebd, categorieChbrebd, numChambrebd, montantPayebd);

                        }
                        readDonnee.Close();
                        readDonnee.Dispose();
                        cmd.Dispose();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec !! " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Finaly!! ");
                if (sqlconn.reqSql != null && sqlconn.reqSql.State == ConnectionState.Open)
                {
                    sqlconn.reqSql.Close();
                }
            }
        }
    }
}
