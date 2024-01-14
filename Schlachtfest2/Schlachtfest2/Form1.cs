using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schlachtfest2
{
    public partial class Form1 : Form
    {
        double Weizen_Betrag, Weizen_Gesamt, Weizen_Insgesamt, Weizen_pay;
        string sys;



        public Form1()
        {
            InitializeComponent();

            Weizen_pay = 1.50;
        }




        string lick(double betrag, double gesamt, double pay)
        {
            string ausgabe;
            gesamt = betrag * pay;
            ausgabe = betrag + "€ * " + pay + "€ = " + gesamt + "€";
            return ausgabe;
        }

        double Rechnung()
        {
            Weizen_pay = Weizen_Insgesamt + Weizen_Betrag;
            Weizen_Betrag = Weizen_Betrag + "";
            lbl_Pils.Text = Weizen_Betrag;
        }
        
            
        


        private void btn_Pils_Click(object sender, EventArgs e)
        {

            Weizen_Betrag ++;
            sys = lick(Weizen_Betrag, Weizen_Gesamt, Weizen_pay);
            lbl_Pils.Text = sys;
        }
    }
}
