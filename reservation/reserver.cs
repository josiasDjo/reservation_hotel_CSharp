﻿using System;
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
using insererDonnee;
using getdataNames;

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
            connxion_bd sqlconn = new connxion_bd();
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
                            string nombd = readDonnee["nom"].ToString();
                            string postNombd = readDonnee["postNom"].ToString();
                            string prenombd = readDonnee["prenom"].ToString();
                            string sexebd = readDonnee["sexe"].ToString();
                            string telbd = readDonnee["tel"].ToString();
                            string datedb = readDonnee["datePrevu"].ToString();
                            string nbreJoursbd = readDonnee["nombreJours"].ToString();
                            string typeChambrebd = readDonnee["typeChambre"].ToString();
                            string categorieChbrebd = readDonnee["nomCategorie"].ToString();
                            string numChambrebd = readDonnee["numChambre"].ToString();
                            string montantPayebd = readDonnee["montant"].ToString();

                            dataGridView1.Rows.Add(nombd, postNombd, prenombd, sexebd, telbd, datedb, nbreJoursbd, typeChambrebd, categorieChbrebd, numChambrebd, montantPayebd);
                        }
                        readDonnee.Close();
                        readDonnee.Dispose();
                        cmd.Dispose();

                    }
                }
               
            }
            catch(Exception ex)
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
            sendEntree();           
        }

        public void sendEntree()
        {
            getdata gdat = new getdata();
            DateTime currentDate = DateTime.Now;

            string datetoday = currentDate.ToString();
            gdat.bdNom = txtnom.Text;
            gdat.bdPostNom = txtpostnom.Text;
            gdat.bdPrenom = txtprenom.Text;
            gdat.bdtel = txtphone.Text;
            gdat.bdsexe = txtsexe.Text;
            gdat.bdDatePrevu = dateTimePicker1.Text;
            gdat.bdNombreJours = txtNbreJrs.Text;
            gdat.bdTypeChambre = txtTypeChambre.Text;
            gdat.bdNumChambre = txtNumChbre.Text;
            gdat.bdmontant = txtmontant.Text;
            gdat.bdNumChambre = txtNbreJrs.Text;
            gdat.bdDatePayement = datetoday;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
