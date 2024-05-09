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
            connxion_bd sqlconn = new connxion_bd();
            getdata gdat = new getdata();

            try
            {
                sqlconn.sendConn();
    
                string querryInsert1 = "INSERT INTO [dbo].[tClient] (nom, postNom, prenom, sexe, tel) VALUES (@Nomh, @PostNomh, @Prenomh, @sexeh, @Telh) ";

                using (SqlCommand command = new SqlCommand(querryInsert1, sqlconn.reqSql))
                {
                    command.Parameters.AddWithValue("@Nomh", gdat.bdNom);
                    command.Parameters.AddWithValue("@PostNomh", gdat.bdPostNom);
                    command.Parameters.AddWithValue("@Prenomh", gdat.bdPrenom);
                    command.Parameters.AddWithValue("@sexeh", gdat.bdPrenom);
                    command.Parameters.AddWithValue("@Telh", gdat.bdtel);


                    command.ExecuteNonQuery();
                }

                string querryInsert2 = "INSERT INTO [dbo].[tChambre] (numChambre, typeChambre) VALUES (@numChambre, @typeChambre) ";

                using (SqlCommand command = new SqlCommand(querryInsert2, sqlconn.reqSql))
                {
                    command.Parameters.AddWithValue("@Nom", gdat.bdNumChambre);
                    command.Parameters.AddWithValue("@PostNom", gdat.bdTypeChambre);               

                    command.ExecuteNonQuery();
                }

                string querryInsert3 = "INSERT INTO [dbo].[tCategorieCh] (nomCategorie) VALUES (@nomCategorie) ";

                using (SqlCommand command = new SqlCommand(querryInsert3, sqlconn.reqSql))
                {
                    command.Parameters.AddWithValue("@nomCategorie", gdat.bdnomCategorie);

                    command.ExecuteNonQuery();
                }

                string querryInsert4 = "INSERT INTO [dbo].[tPayement] (montant, datePayement) VALUES (@Nom, @PostNom, @Prenom, @Tel) ";

                using (SqlCommand command = new SqlCommand(querryInsert4, sqlconn.reqSql))
                {
                    command.Parameters.AddWithValue("@Nom", gdat.bdmontant);
                    command.Parameters.AddWithValue("@PostNom", gdat.bdDatePayement);

                    command.ExecuteNonQuery();
                }

                string querryInsert5 = "INSERT INTO [dbo].[tReservation] (datePrevu, nombreJours) VALUES (@Nom, @PostNom, @Prenom, @Tel) ";

                using (SqlCommand command = new SqlCommand(querryInsert5, sqlconn.reqSql))
                {
                    command.Parameters.AddWithValue("@Nom", gdat.bdDatePrevu);
                    command.Parameters.AddWithValue("@PostNom", gdat.bdNombreJours);

                    command.ExecuteNonQuery();
                }



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

}
