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


namespace reservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //

            InitializeComponent();
        }

        private void reserverClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*reserver reserverShow = new reserver();
            reserverShow.Show();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reserver reserverShow = new reserver();
            reserverShow.Show();
        }
    }
}
