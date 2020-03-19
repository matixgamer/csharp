using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObliczanieSredniej
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void PrzeliczButton_Click(object sender, EventArgs e)
        {
            decimal ocena1 = decimal.Parse(MatematykaBox.Text);
            decimal ocena2 = decimal.Parse(InformatykaBox.Text);
            decimal ocena3 = decimal.Parse(AngielskiBox.Text);
            decimal ocena4 = decimal.Parse(PolskiBox.Text);
            decimal ocena5 = decimal.Parse(PolskiBox.Text);
            decimal srednia = (ocena1 + ocena2 + ocena3 + ocena4 + ocena5) / 5;
            SredniaBox.Text = srednia.ToString();
        }
        private void SredniaBox_TextChanged(object sender, EventArgs e)
        {
            //Text.ToString(MatematykaBox + InformatykaBox + AngielskiBox + PolskiBox + DeutschBox);
        }

        private void MatematykaBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
