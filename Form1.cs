using System;
using System.Drawing;
using System.Windows.Forms;



namespace BMI_Csharp
{
    public partial class Form1 : Form
    {
        double alter = 0.5, gross = 0.5, gewicht = 0.5;
        double summe;
        bool mann, frau;
        FormJunge tabelle = new FormJunge();

        //Variable für Form Tabellen.cs
        class Tabelle {
            public int tabellenauswahl;
            
            private int Tabellenauswahl
            {
                get { return tabellenauswahl; } 
                set { tabellenauswahl = value; }
        }
    }

        public Form1()
        {
            InitializeComponent();
        }

        private void rB_mann_CheckedChanged(object sender, EventArgs e)
        {
            mtxtB_alter.Visible = true; mtxtB_gross.Visible = true; 
            mtxtB_gewicht.Visible = true;
            mtxtB_alter.Focus();
            mann = true;
            frau = false;
    }

        private void rB_frau_CheckedChanged(object sender, EventArgs e)
        {
            mtxtB_alter.Visible = true;mtxtB_gross.Visible = true;
            mtxtB_gewicht.Visible = true;
            mtxtB_alter.Focus();
            mann = false;
            frau = true;
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
 
        private void mtxtB_gross_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mtxtB_gewicht.Focus();
            }
            if( e.KeyCode == Keys.Back)
            {

            }
        }

        private void mtxtB_gross_TextChanged(object sender, EventArgs e)
        {
            //gross = double.Parse(mtxtB_gross.Text);
        }

        private void lbl_summe_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_bmi_Click(object sender, EventArgs e)
        {
            if (mtxtB_alter.Text != null || mtxtB_gewicht.Text != null || mtxtB_gross.Text != null) 
            { 
                alter = double.Parse(mtxtB_alter.Text);
                gewicht = double.Parse(mtxtB_gewicht.Text);
                gross = Convert.ToDouble(mtxtB_gross.Text);
                summe = gewicht / (gross / 100 * (gross / 100));
                summe = Math.Round(summe, 2);
                label6.Text = summe.ToString();
                label6.Visible = true;
                lbl_gruppe.Visible = true;

                if (mann == true)
            {
                if (alter <= 18 && mann == true)
                {
                    tabelle.Text = "BMI für Jungs";
                    tabelle.Show();
                    tabelle.pictureBox1.Image = new Bitmap("C:/Users/corat/Source/Repos/BMI_Csharp/BMI Junge.JPG");
                }
                       //Abfrage für Tabellenausgabe - Ausgabe Tabelle Kind
                else if (alter > 18 && mann == true)          //Abfrage für Tabellenausgabe - Ausgabe Tabelle Mann
                {
                    tabelle.Text = "BMI für Männer";
                    tabelle.Show();
                    tabelle.pictureBox1.Image = new Bitmap("C:/Users/corat/Source/Repos/BMI_Csharp/BMI Mann.JPG");
                }       
            }
                {
                if (alter < 8 && mann == true)
                    {
                        if (summe < 14.2)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 14.2 && summe < 16.4)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 16.4 && summe < 19.3)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 19.3 && summe < 22.6)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 22.6)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }             //Kind Junge
                else if (alter == 9 && mann == true)
                    {
                        if (summe < 13.7)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 13.7 && summe < 17.1)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 17.1 && summe < 19.4)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 19.4 && summe < 21.6)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 21.6)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }       //Kind Junge
                else if (alter == 10 && mann == true)
                    {
                        if (summe < 14.6)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 14.6 && summe < 17.1)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 17.1 && summe < 21.4)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 21.4 && summe < 25)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 25)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }      //Kind Junge
                else if (alter == 11 && mann == true)
                    {
                        if (summe < 14.3)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 14.3 && summe < 17.8)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 17.8 && summe < 21.2)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 21.2 && summe < 23.1)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 23.1)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }      //Kind Junge
                else if (alter == 12 && mann == true)
                    {
                        if (summe < 14.8)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 14.8 && summe < 18.4)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 18.4 && summe < 22)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 22 && summe < 24.8)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 24.8)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }      //Kind Junge
                else if (alter == 13 && mann == true)
                    {
                        if (summe < 14.3)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 14.3 && summe < 17.8)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 17.8 && summe < 21.2)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 21.2 && summe < 23.1)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 23.1)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }      //Kind Junge
                else if (alter == 14 && mann == true)
                    {
                        if (summe < 16.7)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 16.7 && summe < 19.8)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 19.8 && summe < 22.6)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 22.6 && summe < 25.7)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 25.7)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }      //Kind Junge
                else if (alter == 15 && mann == true)
                    {
                        if (summe < 17.8)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 17.8 && summe < 20.2)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 20.2 && summe < 23.1)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 23.1 && summe < 25.9)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 25.9)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }      //Kind Junge
                else if (alter == 16 && mann == true)
                    {
                        if (summe < 18.5)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 18.5 && summe < 21)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 21 && summe < 23.7)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 23.7 && summe < 26)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 26)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }      //Kind Junge
                else if (alter == 17 && mann == true)
                    {
                        if (summe < 18.6)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 18.6 && summe < 21.6)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 21.6 && summe < 23.7)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 23.7 && summe < 25.8)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 25.8)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }      //Kind Junge
                else if (alter == 18 && mann == true)
                    {
                        if (summe < 18.6)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 18.6 && summe < 21.8)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 21.8 && summe < 24)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 24 && summe < 26.8)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 26.8)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }      //Kind Junge
                else if (alter > 18 && alter < 25 && mann == true)
                    {
                        if (summe < 19)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 19 && summe <= 24)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe > 24 && summe <= 28)
                        {
                            lbl_gruppe.Text = "leichtes Übergewicht";
                        }
                        else if (summe > 28)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                    }
                else if (alter >= 25 && alter < 35 && mann == true)
                    {
                        if (summe < 19)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 19 && summe <= 25)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe > 25 && summe <= 29)
                        {
                            lbl_gruppe.Text = "leichtes Übergewicht";
                        }
                        else if (summe > 29)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                    }
                else if (alter >= 35 && alter < 44 && mann == true)
                    {
                        if (summe < 20)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 20 && summe <= 26)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe > 26 && summe <= 30)
                        {
                            lbl_gruppe.Text = "leichtes Übergewicht";
                        }
                        else if (summe > 30)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                    }
                else if (alter >= 44 && alter < 55 && mann == true)
                    {
                        if (summe < 21)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 21 && summe <= 27)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe > 27 && summe <= 31)
                        {
                            lbl_gruppe.Text = "leichtes Übergewicht";
                        }
                        else if (summe > 31)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                    }
                else if (alter >= 55 && alter < 65 && mann == true)
                    {
                        if (summe < 22)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 22 && summe <= 28)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe > 28 && summe <= 32)
                        {
                            lbl_gruppe.Text = "leichtes Übergewicht";
                        }
                        else if (summe > 32)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                    }
                else if (alter >= 65 && mann == true)
                    {
                        if (summe < 23)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 23 && summe <= 29)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe > 29 && summe <= 32)
                        {
                            lbl_gruppe.Text = "leichtes Übergewicht";
                        }
                        else if (summe > 32)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                    }
            }
                if (frau == true)
            {
                if (alter <= 18 && frau == true)
                {
                    tabelle.Text = "BMI für Mädchen";
                    tabelle.Show();
                    tabelle.pictureBox1.Image = new Bitmap("C:/Users/corat/Source/Repos/BMI_Csharp/BMI Madel.JPG");
                }           //Abfrage für Tabellenausgabe - Ausgabe Tabelle Kind
                else if (alter > 18 && frau == true)
                {
                    tabelle.Text = "BMI für Frauen";
                    tabelle.Show();
                    tabelle.pictureBox1.Image = new Bitmap("C:/Users/corat/Source/Repos/BMI_Csharp/BMI Frau.JPG");
                }       //Abfrage für Tabellenausgabe - Ausgabe Tabelle Mann
                
                if (alter < 8 && frau == true)
                    {
                        if (summe < 13.2)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 13.2 && summe < 15.9)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 15.9 && summe < 18.8)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 18.8 && summe < 22.3)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 22.3)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                }             //Kind madel
                else if (alter == 9 && frau == true)
                    {
                        if (summe < 13.7)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 13.7 && summe < 16.4)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 16.4 && summe < 19.8)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 19.8 && summe < 23.4)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 23.4)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }       //Kind madel
                else if (alter == 10 && frau == true)
                    {
                        if (summe < 14.2)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 14.2 && summe < 16.9)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 16.9 && summe < 20.7)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 20.7 && summe < 23.4)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 23.4)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }      //Kind madel
                else if (alter == 11 && frau == true)
                    {
                        if (summe < 24.6)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 14.6 && summe < 17.7)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 17.7 && summe < 20.8)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 20.8 && summe < 22.9)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 22.9)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }      //Kind madel
                else if (alter == 12 && frau == true)
                    {
                        if (summe < 16)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 16 && summe < 18.4)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 18.4 && summe < 21.5)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 21.5 && summe < 23.4)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 23.4)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }      //Kind madel
                else if (alter == 13 && frau == true)
                    {
                        if (summe < 15.6)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 15.6 && summe < 18.9)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 18.9 && summe < 22.1)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 22.1 && summe < 24.4)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 24.4)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }      //Kind madel
                else if (alter == 14 && frau == true)
                    {
                        if (summe < 17)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 17 && summe < 19.4)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 19.4 && summe < 23.2)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 23.2 && summe < 26)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 26)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }      //Kind madel
                else if (alter == 15 && frau == true)
                    {
                        if (summe < 17.6)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 17.6 && summe < 20.2)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 20.2 && summe < 23.2)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 23.2 && summe < 16)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 26)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }      //Kind madel
                else if (alter == 16 && frau == true)
                    {
                        if (summe < 17.8)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 17.8 && summe < 20.3)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 30.3 && summe < 22.8)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 22.8 && summe < 24.2)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 24.2)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }      //Kind madel
                else if (alter == 17 && frau == true)
                    {
                        if (summe < 17.8)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 17.8 && summe < 20.3)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 20.3 && summe < 22.8)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 22.8 && summe < 24.2)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 24.2)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }      //Kind madel
                else if (alter == 18 && frau == true)
                    {
                        if (summe < 18.3)
                        {
                            lbl_gruppe.Text = "starkes Untergewicht";
                        }
                        else if (summe >= 18.3 && summe < 20.6)
                        {
                            lbl_gruppe.Text = "Untergewicht";
                        }
                        else if (summe >= 20.6 && summe < 23.5)
                        {
                            lbl_gruppe.Text = "Normalgewicht";
                        }
                        else if (summe >= 23.5 && summe < 25)
                        {
                            lbl_gruppe.Text = "Übergewicht";
                        }
                        else if (summe >= 25)
                        {
                            lbl_gruppe.Text = "starkes Übergewicht";
                        }
                    }      //Kind madel
                else if (alter > 18 && alter < 25 && frau == true)
                { 
                    if (summe < 20)
                    {
                        lbl_gruppe.Text = "Untergewicht";
                    }
                    else if (summe >= 20 && summe <= 25)
                    {
                        lbl_gruppe.Text = "Normalgewicht";
                    }
                    else if (summe > 25 && summe <= 29)
                    {
                        lbl_gruppe.Text = "leichtes Übergewicht";
                    }
                    else if (summe > 29)
                    {
                        lbl_gruppe.Text = "Übergewicht";
                    }
                }
                else if (alter >= 25 && alter < 35 && frau == true)
                { 
                    if (summe < 21)
                    {
                        lbl_gruppe.Text = "Untergewicht";
                    }
                    else if (summe >= 21 && summe <= 26)
                    {
                        lbl_gruppe.Text = "Normalgewicht";
                    }
                    else if (summe > 26 && summe <= 30)
                    {
                        lbl_gruppe.Text = "leichtes Übergewicht";
                    }
                    else if (summe > 30)
                    {
                        lbl_gruppe.Text = "Übergewicht";
                    }
                }
                else if (alter >= 35 && alter < 44 && frau == true)
                { 
                    if (summe < 22)
                    {
                        lbl_gruppe.Text = "Untergewicht";
                    }
                    else if (summe >= 22 && summe <= 27)
                    {
                        lbl_gruppe.Text = "Normalgewicht";
                    }
                    else if (summe > 27 && summe <= 31)
                    {
                        lbl_gruppe.Text = "leichtes Übergewicht";
                    }
                    else if (summe > 31)
                    {
                        lbl_gruppe.Text = "Übergewicht";
                    }
                }
                else if (alter >= 44 && alter < 55 && frau == true)
                { 
                    if (summe < 23)
                    {
                        lbl_gruppe.Text = "Untergewicht";
                    }
                    else if (summe >= 23 && summe <= 28)
                    {
                        lbl_gruppe.Text = "Normalgewicht";
                    }
                    else if (summe > 28 && summe <= 32)
                    {
                        lbl_gruppe.Text = "leichtes Übergewicht";
                    }
                    else if (summe > 32)
                    {
                        lbl_gruppe.Text = "Übergewicht";
                    }
                }
                if (alter >= 55 && alter < 65 && frau == true)
                {
                    if (summe < 24)
                    {
                        lbl_gruppe.Text = "Untergewicht";
                    }
                    else if (summe >= 24 && summe <= 29)
                    {
                        lbl_gruppe.Text = "Normalgewicht";
                    }
                    else if (summe > 29 && summe <= 33)
                    {
                        lbl_gruppe.Text = "leichtes Übergewicht";
                    }
                    else if (summe > 33)
                    {
                        lbl_gruppe.Text = "Übergewicht";
                    }
                }
                if (alter >= 65 && frau == true)
                {
                    if (summe < 25)
                    {
                        lbl_gruppe.Text = "Untergewicht";
                    }
                    else if (summe >= 25 && summe <= 30)
                    {
                        lbl_gruppe.Text = "Normalgewicht";
                    }
                    else if (summe > 30 && summe <= 34)
                    {
                        lbl_gruppe.Text = "leichtes Übergewicht";
                    }
                    else if (summe > 34)
                    {
                        lbl_gruppe.Text = "Übergewicht";
                    }
                }
            }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
