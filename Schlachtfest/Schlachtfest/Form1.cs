using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Schlachtfest
{
    public partial class Form1 : Form
    {
        double Rechnung;
        double Weizen_Betrag = 0, Weizen_Gesamt, Weizen_Insgesamt,Weizen_pay = 2;
        double Pils_Betrag = 0, Pils_Gesamt, Pils_Insgemsamt;
        double Wein_Glas_Betrag = 0, Wein_Glas_Gesamt, Wein_Glas_Insgesamt;
        double Wein_Flasche_Betrag = 0, Wein_Flasche_Gesamt, Wein_Flasche_Insgesamt;
        double Softdrink_Betrag = 0, Softdrink_Gesamt, Softdrink_Insgesamt;
        double Weinschorle_Betrag = 0, Weinschorle_Gesamt, Weinschorle_Insgesamt;
        double Wasser_Betrag = 0, Wasser_Gesamt, Wasser_Insgemsamt;
        double Apfelschorle_Betrag = 0, Apfelschorle_Gesamt, Apfelschorle_Insgesamt;
        double Schnapps_Betrag = 0, Schnapps_Gesamt, Schnapps_Insgesamt;
        double Schlachtplatte_Betrag = 0, Schlachtplatte_Gesamt, Schlachtplatte_Insgemsamt;
        double Wellfleisch_Betrag = 0, Wellfleisch_Gesamt, Wellfleisch_Insgemsamt;
        double Bratwürste_Betrag = 0, Bratwürste_Gesamt, Bratwürste_Insgemsamt;
        double Hausmacher_Betrag = 0, Hausmacher_Gesamt, Hausmacher_Insgemsamt;
        double Kraut_Betrag = 0, Kraut_Gesamt, Kraut_Insgemsamt;
        double Metzelsuppe_Betrag = 0, Metzelsuppe_Gesamt, Metzelsuppe_Insgemsamt;
        double Kuchen_Betrag = 0, Kuchen_Gesamt, Kuchen_Insgemsamt;
        double Torte_Betrag = 0, Torte_Gesamt, Torte_Insgemsamt;
        double Schlachtplatte_ZM_Betrag = 0, Schlachtplatte_ZM_Gesamt, Schlachtplatte_ZM_Insgemsamt;
        double Kraut_ZM_Betrag, Kraut_ZM_Gesamt, Kraut_ZM_Insgemsamt;
        double Wellfleisch_ZM_Betrag = 0, Wellfleisch_ZM_Gesamt, Wellfleisch_ZM_Insgemsamt;
        double Bratwürste_ZM_Betrag = 0, Bratwürste_ZM_Gesamt, Bratwürste_ZM_Insgemsamt;
        double Hausmacher_ZM_Betrag = 0, Hausmacher_ZM_Gesamt, Hausmacher_ZM_Insgemsamt;
        double weg;
        string sys;



        public Form1()
        {
            InitializeComponent();
        }

        



        string klick(double betrag, double gesamt, double pay)
        {
            string ausgabe;
            gesamt = betrag * pay;
            ausgabe = betrag + "€ * " + pay + "€ = " + gesamt + "€";
            return ausgabe;
        }
        

        double klas()
        {
            double ruekgabe;
            ruekgabe = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = ruekgabe + "€";
            return ruekgabe;
        }




        //Weizen
        //Weizen
        //Weizen
        //Weizen + 


        private void btn_Weizen_Click(object sender, EventArgs e)
        {
            Weizen_Betrag++;
            sys = klick(Weizen_Betrag, Weizen_Gesamt, Weizen_pay);
            Weizen_Gesamt = Weizen_Betrag * Weizen_pay;
            lbl_Weizen.Text = sys;
            weg = klas();
        }

        private void btn_Weizen_2_Click(object sender, EventArgs e)
        {
            Weizen_Betrag --;
            sys = klick(Weizen_Betrag, Weizen_Gesamt, Weizen_pay);
            lbl_Weizen.Text = sys;
            Weizen_Gesamt = Weizen_Betrag * Weizen_pay;
            weg = klas();
        }

        /*
        private void btn_Weizen_Click(object sender, EventArgs e)
        {

            Weizen_Betrag ++;
            Weizen_Gesamt = Weizen_Betrag * 2;
            lbl_Weizen.Text = Weizen_Betrag + "* 2.00€ = " + Weizen_Gesamt + ".00€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }
        

        //Weizen -
        private void btn_Weizen_2_Click(object sender, EventArgs e)
        {
            Weizen_Betrag --;
            Weizen_Gesamt = Weizen_Betrag * 2;
            lbl_Weizen.Text = Weizen_Betrag + "* 2.00€ = " + Weizen_Gesamt + ".00€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

    */
        //Pils
        //Pils +
        private void btn_Pils_Click(object sender, EventArgs e)
        {
            Pils_Betrag ++;
            Pils_Gesamt = Pils_Betrag * 1.5;
            lbl_Pils.Text = Pils_Betrag + "* 1.50€ = " + Pils_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Pils -
        private void btn_Pils2_Click_1(object sender, EventArgs e)
        {
            Pils_Betrag --;
            Pils_Gesamt = Pils_Betrag * 1.5;
            lbl_Pils.Text = Pils_Betrag + "* 1.50€ = " + Pils_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Wein(Glas)
        //Wein +
        private void btn_Wein_Glas_Click(object sender, EventArgs e)
        {
            Wein_Glas_Betrag ++;
            Wein_Glas_Gesamt = Wein_Glas_Betrag * 2.5;
            lbl_Wein_Glas.Text = Wein_Glas_Betrag + "* 2.5€ = " + Wein_Glas_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Wein -
        private void btn_Wein_Glas2_Click_1(object sender, EventArgs e)
        {
            Wein_Glas_Betrag --;
            Wein_Glas_Gesamt = Wein_Glas_Betrag * 2.5;
            lbl_Wein_Glas.Text = Wein_Glas_Betrag + "* 2.5€ = " + Wein_Glas_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Wein(Flasche)
        //Wein +
        private void btn_Wein_Flasche_Click(object sender, EventArgs e)
        {
            Wein_Flasche_Betrag ++;
            Wein_Flasche_Gesamt = Wein_Flasche_Betrag * 10;
            lbl_Wein_Flasche.Text = Wein_Flasche_Betrag + "* 10.0€ = " + Wein_Flasche_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Wein -
        private void btn_Wein_Flasche2_Click(object sender, EventArgs e)
        {
            Wein_Flasche_Betrag --;
            Wein_Flasche_Gesamt = Wein_Flasche_Betrag * 10;
            lbl_Wein_Flasche.Text = Wein_Flasche_Betrag + "* 10.0€ = " + Wein_Flasche_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Softdrink
        //Softdrink +
        private void btn_Softdrink_Click(object sender, EventArgs e)
        {
            Softdrink_Betrag ++;
            Softdrink_Gesamt = Softdrink_Betrag * 1.8;
            lbl_Softdrink.Text = Softdrink_Betrag + "* 1.80€ = " + Softdrink_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Softdrink -
        private void btn_Softdrink2_Click(object sender, EventArgs e)
        {
            Softdrink_Betrag --;
            Softdrink_Gesamt = Softdrink_Betrag * 1.8;
            lbl_Softdrink.Text = Softdrink_Betrag + "* 1.80€ = " + Softdrink_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }


        //Weinschorle
        //Weinschorle +
        private void btn_Weinschorle_Click(object sender, EventArgs e)
        {
            Weinschorle_Betrag ++;
            Weinschorle_Gesamt = Weinschorle_Betrag * 2;
            lbl_Weinschorle.Text = Weinschorle_Betrag + "* 2.00€ = " + Weinschorle_Gesamt + ".00€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Weinschorle -
        private void btn_Weinschorle2_Click(object sender, EventArgs e)
        {
            Weinschorle_Betrag --;
            Weinschorle_Gesamt = Weinschorle_Betrag * 2;
            lbl_Weinschorle.Text = Weinschorle_Betrag + "* 2.00€ = " + Weinschorle_Gesamt + ".00€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Wasser
        //Wasser +
        private void btn_Wasser_Click(object sender, EventArgs e)
        {
            Wasser_Betrag ++;
            Wasser_Gesamt = Wasser_Betrag * 1.5;
            lbl_Wasser.Text = Wasser_Betrag + "* 1.50€ = " + Wasser_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Wasser -
        private void btn_Wasser2_Click(object sender, EventArgs e)
        {
            Wasser_Betrag --;
            Wasser_Gesamt = Wasser_Betrag * 1.5;
            lbl_Wasser.Text = Wasser_Betrag + "* 1.50€ = " + Wasser_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Apfelschorle
        //Apfelschorle +
        private void btn_Apfelschorle_Click(object sender, EventArgs e)
        {
            Apfelschorle_Betrag ++;
            Apfelschorle_Gesamt = Apfelschorle_Betrag * 2;
            lbl_Apfelschorle.Text = Apfelschorle_Betrag + "* 2.00€ = " + Apfelschorle_Gesamt + ".00€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Apfelschorle -
        private void btn_Apfelschorle2_Click(object sender, EventArgs e)
        {
            Apfelschorle_Betrag --;
            Apfelschorle_Gesamt = Apfelschorle_Betrag * 2;
            lbl_Apfelschorle.Text = Apfelschorle_Betrag + "* 2.00€ = " + Apfelschorle_Gesamt + ".00€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Schnaps
        //Schnaps +
        private void btn_Schnaps_Click(object sender, EventArgs e)
        {
            Schnapps_Betrag ++;
            Schnapps_Gesamt = Schnapps_Betrag * 1;
            lbl_Schnaps.Text = Schnapps_Betrag + "* 1.00€ = " + Schnapps_Gesamt + ".00€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Schnaps -
        private void btn_Schnaps2_Click(object sender, EventArgs e)
        {
            Schnapps_Betrag --;
            Schnapps_Gesamt = Schnapps_Betrag * 1;
            lbl_Schnaps.Text = Schnapps_Betrag + "* 1.00€ = " + Schnapps_Gesamt + ".00€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }



        //Essen
        //Schlachtplatte
        //Schlachtplatte +
        private void btn_Schlachtplatte_Click(object sender, EventArgs e)
        {
            Schlachtplatte_Betrag ++;
            Schlachtplatte_Gesamt = Schlachtplatte_Betrag * 5;
            lbl_Schlachtplatte.Text = Schlachtplatte_Betrag + "* 5.00€ = " + Schlachtplatte_Gesamt + ".00€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Schlachtplatte -
        private void btn_Schlachtplatte2_Click(object sender, EventArgs e)
        {
            Schlachtplatte_Betrag --;
            Schlachtplatte_Gesamt = Schlachtplatte_Betrag * 5;
            lbl_Schlachtplatte.Text = Schlachtplatte_Betrag + "* 5.00€ = " + Schlachtplatte_Gesamt + ".00€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Wellfleisch
        //Wellfleisch +
        private void btn_Wellfleisch_Click(object sender, EventArgs e)
        {
            Wellfleisch_Betrag ++;
            Wellfleisch_Gesamt = Wellfleisch_Betrag * 4;
            lbl_Wellfleisch.Text = Wellfleisch_Betrag + "* 4.00€ = " + Wellfleisch_Gesamt + ".00€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Wellfleisch -
        private void btn_Wellfleisch2_Click(object sender, EventArgs e)
        {
            Wellfleisch_Betrag --;
            Wellfleisch_Gesamt = Wellfleisch_Betrag * 4;
            lbl_Wellfleisch.Text = Wellfleisch_Betrag + "* 4.00€ = " + Wellfleisch_Gesamt + ".00€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Bratwürste
        //Bratwürste +
        private void btn_Bratwürste_Click(object sender, EventArgs e)
        {
            Bratwürste_Betrag ++;
            Bratwürste_Gesamt = Bratwürste_Betrag * 3.5;
            lbl_Bratwürste.Text = Bratwürste_Betrag + "* 3.50€ = " + Bratwürste_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Bratwürste -
        private void btn_Bratwürste2_Click(object sender, EventArgs e)
        {
            Bratwürste_Betrag --;
            Bratwürste_Gesamt = Bratwürste_Betrag * 3.5;
            lbl_Bratwürste.Text = Bratwürste_Betrag + "* 3.50€ = " + Bratwürste_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Hausmacher
        //Hausmacher +
        private void btn_Hausmacher_Click(object sender, EventArgs e)
        {
            Hausmacher_Betrag ++;
            Hausmacher_Gesamt = Hausmacher_Betrag * 2.5;
            lbl_Hausmacher.Text = Hausmacher_Betrag + "* 2.50€ = " + Hausmacher_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Hausmacher -
        private void btn_Hausmacher2_Click(object sender, EventArgs e)
        {
            Hausmacher_Betrag --;
            Hausmacher_Gesamt = Hausmacher_Betrag * 2.5;
            lbl_Hausmacher.Text = Hausmacher_Betrag + "* 2.50€ = " + Hausmacher_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Kraut
        //Kraut +
        private void btn_Kraut_Click(object sender, EventArgs e)
        {
            Kraut_Betrag ++;
            Kraut_Gesamt = Kraut_Betrag * 0.5;
            lbl_Kraut.Text = Kraut_Betrag + "* 0.50€ = " + Kraut_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Kraut -
        private void btn_Kraut2_Click(object sender, EventArgs e)
        {
            Kraut_Betrag --;
            Kraut_Gesamt = Kraut_Betrag * 0.5;
            lbl_Kraut.Text = Kraut_Betrag + "* 0.50€ = " + Kraut_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }


        //Metzelsuppe
        //Metzelsuppe +
        private void btn_Metzelsuppe_Click(object sender, EventArgs e)
        {
            Metzelsuppe_Betrag ++;
            Metzelsuppe_Gesamt = Metzelsuppe_Betrag * 1.5;
            lbl_Metzelsuppe.Text = Metzelsuppe_Betrag + "* 1.50€ = " + Metzelsuppe_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Metzelsuppe -
        private void btn_Metzelsuppe2_Click(object sender, EventArgs e)
        {
            Metzelsuppe_Betrag --;
            Metzelsuppe_Gesamt = Metzelsuppe_Betrag * 1.5;
            lbl_Metzelsuppe.Text = Metzelsuppe_Betrag + "* 1.50€ = " + Metzelsuppe_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Kuchen
        //Kuchen +
        private void btn_Kuchen_Click(object sender, EventArgs e)
        {
            Kuchen_Betrag ++;
            Kuchen_Gesamt = Kuchen_Betrag * 1;
            lbl_Kuchen.Text = Kuchen_Betrag + "* 1.00€ = " + Kuchen_Gesamt + ".00€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Kuchen -
        private void btn_Kuchen2_Click(object sender, EventArgs e)
        {
            Kuchen_Betrag --;
            Kuchen_Gesamt = Kuchen_Betrag * 1;
            lbl_Kuchen.Text = Kuchen_Betrag + "* 1.00€ = " + Kuchen_Gesamt + ".00€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";

        }

        //Torte
        //Torte +
        private void btn_Torte_Click(object sender, EventArgs e)
        {
            Torte_Betrag ++;
            Torte_Gesamt = Torte_Betrag * 1.5;
            lbl_Torte.Text = Torte_Betrag + "* 1.50€ = " + Torte_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Torte -
        private void btn_Torte2_Click(object sender, EventArgs e)
        {
            Torte_Betrag --;
            Torte_Gesamt = Torte_Betrag * 1.5;
            lbl_Torte.Text = Torte_Betrag + "* 1.50€ = " + Torte_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }


        //Zum Mitnehmen
        //Schlachtplatte
        //Schlachtplatte +
        private void btn_Schlachtfest_ZM_Click(object sender, EventArgs e)
        {
            Schlachtplatte_ZM_Betrag ++;
            Schlachtplatte_ZM_Gesamt = Schlachtplatte_ZM_Betrag * 4.5;
            lbl_Schlachtplatte_ZM.Text = Schlachtplatte_ZM_Betrag + " * 4.50€ = " + Schlachtplatte_ZM_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Schlachtplatte -
        private void btn_Schlachtfest_ZM2_Click(object sender, EventArgs e)
        {
            Schlachtplatte_ZM_Betrag --;
            Schlachtplatte_ZM_Gesamt = Schlachtplatte_ZM_Betrag * 4.5;
            lbl_Schlachtplatte_ZM.Text = Schlachtplatte_ZM_Betrag + " * 4.50€ = " + Schlachtplatte_ZM_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Kraut
        //Kraut +
        private void btn_Kraut_ZM_Click(object sender, EventArgs e)
        {
            Kraut_ZM_Betrag ++;
            Kraut_ZM_Gesamt = Kraut_ZM_Betrag * 1;
            lbl_Kraut_ZM.Text = Kraut_ZM_Betrag + "* 1.00€ = " + Kraut_ZM_Gesamt + ".00€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Kraut -
        private void btn__Click(object sender, EventArgs e)
        {
            Kraut_ZM_Betrag --;
            Kraut_ZM_Gesamt = Kraut_ZM_Betrag * 1;
            lbl_Kraut_ZM.Text = Kraut_ZM_Betrag + "* 1.00€ = " + Kraut_ZM_Gesamt + ".00€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Wellfleisch
        //Wellfleisch +
        private void btn_Wellfleisch_ZM_Click(object sender, EventArgs e)
        {
            Wellfleisch_ZM_Betrag ++;
            Wellfleisch_ZM_Gesamt = Wellfleisch_ZM_Betrag * 3.5;
            lbl_Wellfleisch_ZM.Text = Wellfleisch_ZM_Betrag + "* 3.50€ = " + Wellfleisch_ZM_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Wellfleisch -
        private void btn_Wellfleisch_ZM2_Click(object sender, EventArgs e)
        {
            Wellfleisch_ZM_Betrag --;
            Wellfleisch_ZM_Gesamt = Wellfleisch_ZM_Betrag * 3.5;
            lbl_Wellfleisch_ZM.Text = Wellfleisch_ZM_Betrag + "* 3.50€ = " + Wellfleisch_ZM_Gesamt + "€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Bratuurst
        //Bratwurst +
        private void btn_Bratwurst_ZM_Click(object sender, EventArgs e)
        {
            Bratwürste_ZM_Betrag ++;
            Bratwürste_ZM_Gesamt = Bratwürste_ZM_Betrag * 3;
            lbl_Bratwurst_ZM.Text = Bratwürste_ZM_Betrag + "* 3.00€ = " + Bratwürste_ZM_Gesamt + ".00€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Bratwurst -
        private void btn_Bratwurst_ZM2_Click(object sender, EventArgs e)
        {
            Bratwürste_ZM_Betrag --;
            Bratwürste_ZM_Gesamt = Bratwürste_ZM_Betrag * 3;
            lbl_Bratwurst_ZM.Text = Bratwürste_ZM_Betrag + "* 3.00€ = " + Bratwürste_ZM_Gesamt + ".00€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Hausmacher
        //Hausmacher +
        private void btn_Hausmacher_ZM_Click(object sender, EventArgs e)
        {
            Hausmacher_ZM_Betrag ++;
            Hausmacher_ZM_Gesamt = Hausmacher_ZM_Betrag * 2;
            lbl_Hausmacher_ZM.Text = Hausmacher_ZM_Betrag + "* 2.00€ = " + Hausmacher_ZM_Gesamt + ".00€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }

        //Hausmacher -
        private void btn_Hausmacher_ZM2_Click(object sender, EventArgs e)
        {
            Hausmacher_ZM_Betrag --;
            Hausmacher_ZM_Gesamt = Hausmacher_ZM_Betrag * 2;
            lbl_Hausmacher_ZM.Text = Hausmacher_ZM_Betrag + "* 2.00€ = " + Hausmacher_ZM_Gesamt + ".00€";

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";
        }



        //abrechnen
        private void btn_Abrechnen_Click(object sender, EventArgs e)
        {
            //Weizen
            Weizen_Insgesamt = Weizen_Insgesamt + Weizen_Betrag;

            //Pils
            Pils_Insgemsamt = Pils_Insgemsamt + Pils_Betrag;

            //Wein(Glas)
            Wein_Glas_Insgesamt = Wein_Glas_Insgesamt + Wein_Glas_Betrag;

            //Wein(Flasche)
            Wein_Flasche_Insgesamt = Wein_Flasche_Insgesamt + Wein_Flasche_Betrag;

            //Weinschorle
            Weinschorle_Insgesamt = Weinschorle_Insgesamt + Weinschorle_Betrag;

            //Softdrink
            Softdrink_Insgesamt = Softdrink_Insgesamt + Softdrink_Betrag;

            //Wasser
            Wasser_Insgemsamt = Wasser_Insgemsamt + Wasser_Betrag;

            //Apfelschorle
            Apfelschorle_Insgesamt = Apfelschorle_Insgesamt + Apfelschorle_Betrag;

            //Schnapps
            Schnapps_Insgesamt = Schnapps_Insgesamt + Schnapps_Betrag;

            //Essen
            //Schlachtplatte
            Schlachtplatte_Insgemsamt = Schlachtplatte_Insgemsamt + Schlachtplatte_Betrag;

            //Wellfleisch
            Wellfleisch_Insgemsamt = Wellfleisch_Insgemsamt + Wellfleisch_Betrag;

            //Bratwürste
            Bratwürste_Insgemsamt = Bratwürste_Insgemsamt + Bratwürste_Betrag;

            //Hausmacher
            Hausmacher_Insgemsamt = Hausmacher_Insgemsamt + Hausmacher_Betrag;

            //Kraut
            Kraut_Insgemsamt = Kraut_Insgemsamt + Kraut_Betrag;

            //Metzelsuppe
            Metzelsuppe_Insgemsamt = Metzelsuppe_Insgemsamt + Metzelsuppe_Betrag;

            //Kuchen
            Kuchen_Insgemsamt = Kuchen_Insgemsamt + Kuchen_Betrag;

            //Torte
            Torte_Insgemsamt = Torte_Insgemsamt + Torte_Betrag;

            //Zum Mitnehmen
            //Schlachtplatte
            Schlachtplatte_ZM_Insgemsamt = Schlachtplatte_ZM_Insgemsamt + Schlachtplatte_ZM_Betrag;

            //Kraut
            Kraut_ZM_Insgemsamt = Kraut_ZM_Insgemsamt + Kraut_ZM_Betrag;

            //Wellfleisch
            Wellfleisch_ZM_Insgemsamt = Wellfleisch_ZM_Insgemsamt + Wellfleisch_ZM_Betrag;

            //Bratwurst
            Bratwürste_ZM_Insgemsamt = Bratwürste_ZM_Insgemsamt + Bratwürste_ZM_Betrag;

            //Hausmacher
            Hausmacher_ZM_Insgemsamt = Hausmacher_ZM_Insgemsamt + Hausmacher_ZM_Betrag;

            //Rechnung
            Rechnung = Weizen_Gesamt + Pils_Gesamt + Wein_Glas_Gesamt + Wein_Flasche_Gesamt + Weinschorle_Gesamt + Softdrink_Gesamt + Wasser_Gesamt + Apfelschorle_Gesamt + Schnapps_Gesamt + Schlachtplatte_Gesamt + Wellfleisch_Gesamt + Bratwürste_Gesamt + Hausmacher_Gesamt + Kraut_Gesamt + Metzelsuppe_Gesamt + Kuchen_Gesamt + Torte_Gesamt + Schlachtplatte_ZM_Gesamt + Kraut_ZM_Gesamt + Wellfleisch_ZM_Gesamt + Bratwürste_ZM_Gesamt + Hausmacher_ZM_Gesamt;
            lbl_Rechnung.Text = Rechnung + "€";

            lbl_abgerechnet.Text = "<<Abgerechnet>>";
        }

        //zurücksetzung Daten            
        private void btn_zurücksetzen_Click(object sender, EventArgs e)
        {
            //Weizen
            Weizen_Betrag = 0;
            Weizen_Gesamt = 0;
            lbl_Weizen.Text = "0 * 2.00€ = 0€";

            //Pils
            Pils_Betrag = 0;
            Pils_Gesamt = 0;
            lbl_Pils.Text = "0 * 1.50€ = 0€";

            //Wein(Glas)
            Wein_Glas_Betrag = 0;
            Wein_Glas_Gesamt = 0;
            lbl_Wein_Glas.Text = "0 * 2.5€ = 0€";

            //Wein(Flasche)
            Wein_Flasche_Betrag = 0;
            Wein_Flasche_Gesamt = 0;
            lbl_Wein_Flasche.Text = "0 * 10.00€ = 0€";

            //Softdrink
            Softdrink_Betrag = 0;
            Softdrink_Gesamt = 0;
            lbl_Softdrink.Text = "0 * 1.80€ = 0€";

            //Weinschorle
            Weinschorle_Betrag = 0;
            Weinschorle_Gesamt = 0;
            lbl_Weinschorle.Text = "0 * 2.00€ = 0€";

            //Wasser
            Wasser_Betrag = 0;
            Wasser_Gesamt = 0;
            lbl_Wasser.Text = "0 * 1.50€ = 0€";

            //Apfelschorle
            Apfelschorle_Betrag = 0;
            Apfelschorle_Gesamt = 0;
            lbl_Apfelschorle.Text = "0 * 2.00€ = 0€";

            //Schnapps
            Schnapps_Betrag = 0;
            Schnapps_Gesamt = 0;
            lbl_Schnaps.Text = "0 * 1.00€ = 0€";

            //Essen
            //Schlachtplatte
            Schlachtplatte_Betrag = 0;
            Schlachtplatte_Gesamt = 0;
            lbl_Schlachtplatte.Text = "0 * 5.00€ = 0€";

            //Wellfleisch
            Wellfleisch_Betrag = 0;
            Wellfleisch_Gesamt = 0;
            lbl_Wellfleisch.Text = "0 * 4.00€ = 0€";

            //Bratwürste
            Bratwürste_Betrag = 0;
            Bratwürste_Gesamt = 0;
            lbl_Bratwürste.Text = "0 * 3.50€ = 0€";

            //Hausmacher
            Hausmacher_Betrag = 0;
            Hausmacher_Gesamt = 0;
            lbl_Hausmacher.Text = "0 * 2.50€ = 0€";

            //Kraut
            Kraut_Betrag = 0;
            Kraut_Gesamt = 0;
            lbl_Kraut.Text = "0 * 0€ = 0€";

            //Metzelsuppe
            Metzelsuppe_Betrag = 0;
            Metzelsuppe_Gesamt = 0;
            lbl_Metzelsuppe.Text = "0 * 0€ = 0€";

            //Kuchen
            Kuchen_Betrag = 0;
            Kuchen_Gesamt = 0;
            lbl_Kuchen.Text = "0 * 1.00€ = 0€";

            //Torte
            Torte_Betrag = 0;
            Torte_Gesamt = 0;
            lbl_Torte.Text = "0 * 1.50€ = 0€";

            //Zum Mitnehmen
            //Schlachtplatte
            Schlachtplatte_ZM_Betrag = 0;
            Schlachtplatte_ZM_Gesamt = 0;
            lbl_Schlachtplatte_ZM.Text = "0 * 4.50€ = 0€";

            //Kraut
            Kraut_ZM_Betrag = 0;
            Kraut_ZM_Gesamt = 0;
            lbl_Kraut_ZM.Text = "0 * 0€ = 0€";

            //Wellfleisch
            Wellfleisch_ZM_Betrag = 0;
            Wellfleisch_ZM_Gesamt = 0;
            lbl_Wellfleisch_ZM.Text = "0 * 3.50€ = 0€";

            //Bratwurst
            Bratwürste_ZM_Betrag = 0;
            Bratwürste_ZM_Gesamt = 0;
            lbl_Bratwurst_ZM.Text = "0 * 3.50€ = 0€";

            //Hausmacher
            Hausmacher_ZM_Betrag = 0;
            Hausmacher_ZM_Gesamt = 0;
            lbl_Hausmacher_ZM.Text = "0 * 2.00€ = 0€";

            lbl_Rechnung.Text = "0€";
            lbl_abgerechnet.Text = "";
        }

    }
}
