using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            decimal pierwsza = numericUpDown1.Value;
            decimal druga = numericUpDown2.Value;
            decimal wynik = pierwsza + druga;
            Wynik.Text = wynik.ToString();
        }

        private void Odejmnij_Click(object sender, EventArgs e)
        {
            decimal pierwsza = numericUpDown1.Value;
            decimal druga = numericUpDown2.Value;
            decimal wynik = pierwsza - druga;
            Wynik.Text = wynik.ToString();
        }

        private void Pomnóż_Click(object sender, EventArgs e)
        {
            decimal pierwsza = numericUpDown1.Value;
            decimal druga = numericUpDown2.Value;
            decimal wynik = pierwsza * druga;
            Wynik.Text = wynik.ToString();
        }

        private void Podziel_Click(object sender, EventArgs e)
        {
            decimal pierwsza = numericUpDown1.Value;
            decimal druga = numericUpDown2.Value;

            try
            {
                decimal wynik = pierwsza / druga;
            }catch(DivideByZeroException)
            {
                MessageBox.Show("BŁĄD");
            }
            //if(druga!= 0)
            //{
            //    decimal wynik = pierwsza / druga;
            //    Wynik.Text = wynik.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("BŁĄD");
            //}

        }

        private void Potega_Click(object sender, EventArgs e)
        {
            try
            {
                decimal pierwsza = numericUpDown1.Value;
                decimal druga = numericUpDown2.Value;
                decimal wynik = 1;
                for (int i = 0; i < druga; i++)
                {
                    wynik = wynik * pierwsza;
                }
                Wynik.Text = wynik.ToString();
            }
            catch
            {
                MessageBox.Show("BŁĄD");
            }
        }
    }
}
