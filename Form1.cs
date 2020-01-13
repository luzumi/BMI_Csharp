using System;
using System.Windows.Forms;


namespace BMI_Csharp
{
    public partial class Form1 : Form
    {
        double alter = 0.5, gross = 0.5, gewicht = 0.5;
        double summe;
                

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rB_mann_CheckedChanged(object sender, EventArgs e)
        {
            mtxtB_alter.Visible = true; mtxtB_gross.Visible = true; 
            mtxtB_gewicht.Visible = true;
            mtxtB_alter.Focus();

        }

        private void rB_frau_CheckedChanged(object sender, EventArgs e)
        {
            mtxtB_alter.Visible = true;mtxtB_gross.Visible = true;
            mtxtB_gewicht.Visible = true;
            mtxtB_alter.Focus();
        }

        private void mtxtB_alter_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
            
        }

        private void mtxtB_alter_MouseClick(object sender, MouseEventArgs e)
        {
            mtxtB_alter.Select(0, 0);
            
        }

        private void mtxtB_gross_MouseClick(object sender, MouseEventArgs e)
        {
            mtxtB_gross.Select(0, 0);
        }

        private void mtxtB_gewicht_MouseClick(object sender, MouseEventArgs e)
        {
            mtxtB_gewicht.Select(0, 0);
        }

        private void mtxtB_alter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mtxtB_gross.Focus();
            }
        }

        private void mtxtB_gross_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxtB_gross_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mtxtB_gewicht.Focus();
            }
        }

        private void mtxtB_alter_TextChanged(object sender, EventArgs e)
        {
            lbl_test.Text = mtxtB_alter.Text;
            alter = double.Parse(mtxtB_alter.Text);
        }

        private void mtxtB_gross_TextChanged(object sender, EventArgs e)
        {
            lbl_test2.Text = mtxtB_gross.Text;
            gross = double.Parse(mtxtB_gross.Text);
        }

        private void lbl_summe_Click(object sender, EventArgs e)
        {
            
        }

        private void mtxtB_gewicht_TextChanged(object sender, EventArgs e)
        {
            lbl_test3.Text = mtxtB_gewicht.Text;
            gewicht = double.Parse(mtxtB_gewicht.Text);
        }

        private void btn_bmi_Click(object sender, EventArgs e)
        {
            summe = gewicht / ((gross / 100) * (gross / 100));
            summe = Math.Round(summe, 2);
            //Zurodnung des BMI(summe)
            if (rB_mann.Visible == true)
            {
                if (alter <= 18)
                { 
                    //Ausgabe BMI_Junge.jpg in neue Form 
                }           //Abfrage für Tabellenausgabe - Ausgabe Tabelle Kind
                else if (alter > 18)
                {
                    //Ausgabe BMI_Mann.jpg in neue Form
                }       //Abfrage für Tabellenausgabe - Ausgabe Tabelle Mann

                if (alter < 8)
                    {
                        if (summe < 14.2)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 14.2 && summe < 16.4)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 16.4 && summe < 19.3)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 19.3 && summe < 22.6)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 22.6)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                }             //Kind Junge
                else if (alter == 9)
                    {
                        if (summe < 13.7)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 13.7 && summe < 17.1)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 17.1 && summe < 19.4)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 19.4 && summe < 21.6)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 21.6)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                    }       //Kind Junge
                else if (alter == 10)
                    {
                        if (summe < 14.6)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 14.6 && summe < 17.1)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 17.1 && summe < 21.4)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 21.4 && summe < 25)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 25)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                    }      //Kind Junge
                else if (alter == 11)
                    {
                        if (summe < 14.3)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 14.3 && summe < 17.8)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 17.8 && summe < 21.2)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 21.2 && summe < 23.1)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 23.1)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                    }      //Kind Junge
                else if (alter == 12)
                    {
                        if (summe < 14.8)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 14.8 && summe < 18.4)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 18.4 && summe < 22)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 22 && summe < 24.8)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 24.8)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                    }      //Kind Junge
                else if (alter == 13)
                    {
                        if (summe < 14.3)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 14.3 && summe < 17.8)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 17.8 && summe < 21.2)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 21.2 && summe < 23.1)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 23.1)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                    }      //Kind Junge
                else if (alter == 14)
                    {
                        if (summe < 16.7)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 16.7 && summe < 19.8)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 19.8 && summe < 22.6)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 22.6 && summe < 25.7)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 25.7)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                    }      //Kind Junge
                else if (alter == 15)
                    {
                        if (summe < 17.8)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 17.8 && summe < 20.2)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 20.2 && summe < 23.1)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 23.1 && summe < 25.9)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 25.9)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                    }      //Kind Junge
                else if (alter == 16)
                    {
                        if (summe < 18.5)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 18.5 && summe < 21)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 21 && summe < 23.7)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 23.7 && summe < 26)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 26)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                    }      //Kind Junge
                else if (alter == 17)
                    {
                        if (summe < 18.6)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 18.6 && summe < 21.6)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 21.6 && summe < 23.7)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 23.7 && summe < 25.8)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 25.8)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                    }      //Kind Junge
                else if (alter == 18)
                    {
                        if (summe < 18.6)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 18.6 && summe < 21.8)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 21.8 && summe < 24)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 24 && summe < 26.8)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 26.8)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                    }      //Kind Junge
                else if (alter > 18 && alter < 25)
                { //Ausgabe BMI_Mann.jpg in neue Form }
                    if (summe < 19)
                    {
                        lbl_summe.Text = "Untergewicht";
                    }
                    else if (summe >= 19 && summe <= 24)
                    {
                        lbl_summe.Text = "Normalgewicht";
                    }
                    else if (summe > 24 && summe <= 28)
                    {
                        lbl_summe.Text = "Übergewicht";
                    }
                    else if (summe > 28)
                    {
                        lbl_summe.Text = "starkes Übergewicht";
                    }
                }
                else if (alter >= 25 && alter < 35)
                { //Ausgabe BMI_Mann.jpg in neue Form }
                    if (summe < 19)
                    {
                        lbl_summe.Text = "Untergewicht";
                    }
                    else if (summe >= 19 && summe <= 25)
                    {
                        lbl_summe.Text = "Normalgewicht";
                    }
                    else if (summe > 25 && summe <= 29)
                    {
                        lbl_summe.Text = "Übergewicht";
                    }
                    else if (summe > 29)
                    {
                        lbl_summe.Text = "starkes Übergewicht";
                    }
                }
                else if (alter >= 35 && alter < 44)
                { //Ausgabe BMI_Mann.jpg in neue Form }
                    if (summe < 20)
                    {
                        lbl_summe.Text = "Untergewicht";
                    }
                    else if (summe >= 20 && summe <= 26)
                    {
                        lbl_summe.Text = "Normalgewicht";
                    }
                    else if (summe > 26 && summe <= 30)
                    {
                        lbl_summe.Text = "Übergewicht";
                    }
                    else if (summe > 30)
                    {
                        lbl_summe.Text = "starkes Übergewicht";
                    }
                }
                else if (alter >= 44 && alter < 55)
                { //Ausgabe BMI_Mann.jpg in neue Form }
                    if (summe < 21)
                    {
                        lbl_summe.Text = "Untergewicht";
                    }
                    else if (summe >= 21 && summe <= 27)
                    {
                        lbl_summe.Text = "Normalgewicht";
                    }
                    else if (summe > 27 && summe <= 31)
                    {
                        lbl_summe.Text = "Übergewicht";
                    }
                    else if (summe > 31)
                    {
                        lbl_summe.Text = "starkes Übergewicht";
                    }
                }
                else if (alter >= 55 && alter < 65)
                { //Ausgabe BMI_Mann.jpg in neue Form }
                    if (summe < 22)
                    {
                        lbl_summe.Text = "Untergewicht";
                    }
                    else if (summe >= 22 && summe <= 28)
                    {
                        lbl_summe.Text = "Normalgewicht";
                    }
                    else if (summe > 28 && summe <= 32)
                    {
                        lbl_summe.Text = "Übergewicht";
                    }
                    else if (summe > 32)
                    {
                        lbl_summe.Text = "starkes Übergewicht";
                    }
                }
                else if (alter >= 65)
                { //Ausgabe BMI_Mann.jpg in neue Form }
                    if (summe < 23)
                    {
                        lbl_summe.Text = "Untergewicht";
                    }
                    else if (summe >= 23 && summe <= 29)
                    {
                        lbl_summe.Text = "Normalgewicht";
                    }
                    else if (summe > 29 && summe <= 32)
                    {
                        lbl_summe.Text = "Übergewicht";
                    }
                    else if (summe > 32)
                    {
                        lbl_summe.Text = "starkes Übergewicht";
                    }
                }
            }
            if (rB_frau.Visible == true)
            {
                if (alter <= 18)
                { 
                    //Ausgabe BMI_madel.jpg in neue Form 
                }           //Abfrage für Tabellenausgabe - Ausgabe Tabelle Kind
                else if (alter > 18)
                {
                    //Ausgabe BMI_Frau.jpg in neue Form
                }       //Abfrage für Tabellenausgabe - Ausgabe Tabelle Mann
                if (alter < 8)
                    {
                        if (summe < 13.2)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 13.2 && summe < 15.9)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 15.9 && summe < 18.8)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 18.8 && summe < 22.3)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 22.3)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                }             //Kind madel
                else if (alter == 9)
                    {
                        if (summe < 13.7)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 13.7 && summe < 16.4)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 16.4 && summe < 19.8)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 19.8 && summe < 23.4)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 23.4)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                    }       //Kind madel
                else if (alter == 10)
                    {
                        if (summe < 14.2)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 14.2 && summe < 16.9)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 16.9 && summe < 20.7)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 20.7 && summe < 23.4)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 23.4)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                    }      //Kind madel
                else if (alter == 11)
                    {
                        if (summe < 24.6)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 14.6 && summe < 17.7)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 17.7 && summe < 20.8)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 20.8 && summe < 22.9)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 22.9)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                    }      //Kind madel
                else if (alter == 12)
                    {
                        if (summe < 16)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 16 && summe < 18.4)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 18.4 && summe < 21.5)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 21.5 && summe < 23.4)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 23.4)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                    }      //Kind madel
                else if (alter == 13)
                    {
                        if (summe < 15.6)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 15.6 && summe < 18.9)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 18.9 && summe < 22.1)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 22.1 && summe < 24.4)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 24.4)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                    }      //Kind madel
                else if (alter == 14)
                    {
                        if (summe < 17)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 17 && summe < 19.4)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 19.4 && summe < 23.2)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 23.2 && summe < 26)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 26)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                    }      //Kind madel
                else if (alter == 15)
                    {
                        if (summe < 17.6)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 17.6 && summe < 20.2)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 20.2 && summe < 23.2)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 23.2 && summe < 16)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 26)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                    }      //Kind madel
                else if (alter == 16)
                    {
                        if (summe < 17.8)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 17.8 && summe < 20.3)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 30.3 && summe < 22.8)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 22.8 && summe < 24.2)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 24.2)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                    }      //Kind madel
                else if (alter == 17)
                    {
                        if (summe < 17.8)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 17.8 && summe < 20.3)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 20.3 && summe < 22.8)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 22.8 && summe < 24.2)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 24.2)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                    }      //Kind madel
                else if (alter == 18)
                    {
                        if (summe < 18.3)
                        {
                            lbl_summe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 18.3 && summe < 20.6)
                        {
                            lbl_summe.Text = "Untergewicht";
                        }
                        else if (summe >= 20.6 && summe < 23.5)
                        {
                            lbl_summe.Text = "Normalgewicht";
                        }
                        else if (summe >= 23.5 && summe < 25)
                        {
                            lbl_summe.Text = "Übergewicht";
                        }
                        else if (summe >= 25)
                        {
                            lbl_summe.Text = "starkes Übergewicht";
                        }
                    }      //Kind madel
                else if (alter > 18 && alter < 25)
                { 
                    if (summe < 20)
                    {
                        lbl_summe.Text = "Untergewicht";
                    }
                    else if (summe >= 20 && summe <= 25)
                    {
                        lbl_summe.Text = "Normalgewicht";
                    }
                    else if (summe > 25 && summe <= 29)
                    {
                        lbl_summe.Text = "Übergewicht";
                    }
                    else if (summe > 29)
                    {
                        lbl_summe.Text = "starkes Übergewicht";
                    }
                }
                else if (alter >= 25 && alter < 35)
                { 
                    if (summe < 21)
                    {
                        lbl_summe.Text = "Untergewicht";
                    }
                    else if (summe >= 21 && summe <= 26)
                    {
                        lbl_summe.Text = "Normalgewicht";
                    }
                    else if (summe > 26 && summe <= 30)
                    {
                        lbl_summe.Text = "Übergewicht";
                    }
                    else if (summe > 30)
                    {
                        lbl_summe.Text = "starkes Übergewicht";
                    }
                }
                else if (alter >= 35 && alter < 44)
                { 
                    if (summe < 22)
                    {
                        lbl_summe.Text = "Untergewicht";
                    }
                    else if (summe >= 22 && summe <= 27)
                    {
                        lbl_summe.Text = "Normalgewicht";
                    }
                    else if (summe > 27 && summe <= 31)
                    {
                        lbl_summe.Text = "Übergewicht";
                    }
                    else if (summe > 31)
                    {
                        lbl_summe.Text = "starkes Übergewicht";
                    }
                }
                else if (alter >= 44 && alter < 55)
                { 
                    if (summe < 23)
                    {
                        lbl_summe.Text = "Untergewicht";
                    }
                    else if (summe >= 23 && summe <= 28)
                    {
                        lbl_summe.Text = "Normalgewicht";
                    }
                    else if (summe > 28 && summe <= 32)
                    {
                        lbl_summe.Text = "Übergewicht";
                    }
                    else if (summe > 32)
                    {
                        lbl_summe.Text = "starkes Übergewicht";
                    }
                }
                if (alter >= 55 && alter < 65)
                {
                    if (summe < 24)
                    {
                        lbl_summe.Text = "Untergewicht";
                    }
                    else if (summe >= 24 && summe <= 29)
                    {
                        lbl_summe.Text = "Normalgewicht";
                    }
                    else if (summe > 29 && summe <= 33)
                    {
                        lbl_summe.Text = "Übergewicht";
                    }
                    else if (summe > 33)
                    {
                        lbl_summe.Text = "starkes Übergewicht";
                    }
                }
                if (alter >= 65)
                {
                    if (summe < 25)
                    {
                        lbl_summe.Text = "Untergewicht";
                    }
                    else if (summe >= 25 && summe <= 30)
                    {
                        lbl_summe.Text = "Normalgewicht";
                    }
                    else if (summe > 30 && summe <= 34)
                    {
                        lbl_summe.Text = "Übergewicht";
                    }
                    else if (summe > 34)
                    {
                        lbl_summe.Text = "starkes Übergewicht";
                    }
                }
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
