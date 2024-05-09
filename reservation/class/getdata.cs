using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reservation;

namespace reservation
{
    class getdata
    {
        reserver rsver = new reserver();
        public void sendEntree()
        {
            string bdNom = txtnom.Text;
            string bdPostNom = txtpostnom.Text;
            string bdPrenom = txtprenom.Text;
            string bdtel = txtphone.Text;
            string bdsexe = txtsexe.Text;
            string bdDate = dateTimePicker1.Text;
            string bdTypeChambre = txtTypeChambre.Text;
            string bdmontant = txtmontant.Text;
            string bdnumChambre = txtnumChambre.Text;
        }
    }
}
