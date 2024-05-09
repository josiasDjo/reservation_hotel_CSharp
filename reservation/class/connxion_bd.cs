using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace connexionDB
{
    class connxion_bd
    {
        public SqlConnection reqSql;
        public void sendConn()
        {
            string connexion = "Data Source=DJODEV;Initial Catalog=db_reservaton;Integrated Security=True";
            try
            {
                reqSql = new SqlConnection(connexion);
                reqSql.Open();
                //MessageBox.Show("Connexion réussie ! ");
                
            } catch(SqlException exc)
            {
                MessageBox.Show("Erreur : " + exc.Message);
            }
        }
    }
}
