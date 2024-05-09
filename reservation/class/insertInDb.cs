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
                rsv.sendEntree();

                string querryInsert = "INSERT INTO [dbo].[tClient] (nom, postNom, prenom, tel) VALUES (@Nom, @PostNom, @Prenom, @Tel) ";

                using (SqlCommand command = new SqlCommand(querryInsert, sqlconn.reqSql))
                {
                    command.Parameters.AddWithValue("@Nom", gdat.bdNom);
                    command.Parameters.AddWithValue("@PostNom", gdat.bdPostNom);
                    command.Parameters.AddWithValue("@Prenom", gdat.bdPrenom);
                    command.Parameters.AddWithValue("@Tel", gdat.bdtel);


                    command.ExecuteNonQuery();
                }

                //table   

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
