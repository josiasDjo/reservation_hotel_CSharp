using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using connexionDB;
using System.Data.SqlClient;
using reservation;
using System.Windows.Forms;
using getdataNames;
using System.Data;

namespace insererDonnee
{
    class insertInDb
    {
        public void dataInsert()
        {
            reserver rsv = new reserver();
            //rsv.send();

            connxion_bd sqlconn = new connxion_bd();
            getdata gdat = new getdata();

            string dbNom = gdat.nom;
            string dbPostNom = gdat.postNom;
            string dbPrenom = gdat.prenom;
            string dbsexe = gdat.sexe;
            string dbtel = gdat.phone;

            if (dbNom == "")
            {
                MessageBox.Show("La valeur d'entrée est vide  !");
            } else
            {
                MessageBox.Show("Données à insérer : " + dbNom);
            }           

            try
            {
                sqlconn.sendConn();

                /*string querryInsert1 = "INSERT INTO [dbo].[tClient] (nom, postNom, prenom, sexe, tel) VALUES (@Nom, @PostNom, @Prenom, @Sexe, @Tel) ";

                SqlCommand command1 = new SqlCommand(querryInsert1, sqlconn.reqSql);

                command1.Parameters.AddWithValue("@Nom", );
                command1.Parameters.AddWithValue("@PostNom", );
                command1.Parameters.AddWithValue("@Prenom", );
                command1.Parameters.AddWithValue("@Sexe", );
                command1.Parameters.AddWithValue("@Tel", );

                command1.ExecuteNonQuery();*/


                /*string querryInsert2 = "INSERT INTO [dbo].[tChambre] (numChambre, typeChambre) VALUES ('" + gdat.bdNumChambre+ "', '" + gdat.bdTypeChambre+ "') ";

                SqlCommand command2 = new SqlCommand(querryInsert2, sqlconn.reqSql);                
                command2.ExecuteNonQuery();
              

                string querryInsert3 = "INSERT INTO [dbo].[tCategorieCh] (nomCategorie) VALUES ('" + gdat.bdnomCategorie+ "') ";

                SqlCommand command3 = new SqlCommand(querryInsert3, sqlconn.reqSql);
                command3.ExecuteNonQuery();
              

                string querryInsert4 = "INSERT INTO [dbo].[tPayement] (montant, datePayement) VALUES ('" + gdat.bdmontant+ "', '" + gdat.bdDatePayement+ "') ";

                SqlCommand command4 = new SqlCommand(querryInsert4, sqlconn.reqSql);
                command4.ExecuteNonQuery();


                string querryInsert5 = "INSERT INTO [dbo].[tReservation] (datePrevu, nombreJours) VALUES ('" + gdat.bdDatePrevu+ "', '" + gdat.bdNombreJours+ "') ";

                SqlCommand command5 = new SqlCommand(querryInsert5, sqlconn.reqSql);
                command5.ExecuteNonQuery();*/



                //MessageBox.Show("Enregistrement réussi !! ");
                sqlconn.reqSql.Close();

            }
            catch (Exception exc)
            {
                //MessageBox.Show("Une erreur est survenue ! " + exc);
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

}
