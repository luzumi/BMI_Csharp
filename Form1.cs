using System;
using System.Windows.Forms;

namespace BMI_Csharp
{
    public partial class Form1 : Form
    {
        int alter = 0, gross = 0, gewicht;
        int summe;

        

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
            alter = Int32.Parse(mtxtB_alter.Text);
        }

        private void mtxtB_gross_TextChanged(object sender, EventArgs e)
        {
            lbl_test2.Text = mtxtB_gross.Text;
            gross = Int32.Parse(mtxtB_gross.Text);
        }

        private void lbl_summe_Click(object sender, EventArgs e)
        {
            
        }


        private void mtxtB_gewicht_TextChanged(object sender, EventArgs e)
        {
            lbl_test3.Text = mtxtB_gewicht.Text;
            gewicht = Int32.Parse(mtxtB_gewicht.Text);
        }

        private void btn_bmi_Click(object sender, EventArgs e)
        {
            summe = gewicht / ((gross / 100) + (gross / 100));
            lbl_summe.Text = summe.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
