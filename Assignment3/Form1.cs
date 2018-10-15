using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCalcFuel_Click(object sender, EventArgs e)
        {
            // error handle this
            double odoCurr = double.Parse(textBoxCurrOdoRead.Text);
            double odoPrev = double.Parse(textBoxPrevOdoRead.Text);
            double fuel = double.Parse(textBoxFuelInput.Text);
            double literPrice = double.Parse(textBoxLiterPriceInput.Text); 

            FuelCalculatorController fcc = new FuelCalculatorController(odoCurr, odoPrev, fuel, literPrice);

            double literPerKm = fcc.GetLiterPerKm();
            double kmPerLiter = fcc.GetKmPerLiter();
            double literPerMetricMile = fcc.GetLiterPerMetricMile();
            double literPerSwedishMile = fcc.GetLiterPerSwedishMile();
            double costPerKm = fcc.GetCostPerKm();

            textBoxLitKm.Text = literPerKm.ToString();
            textBoxKmLit.Text = kmPerLiter.ToString();
            textBoxLitMi.Text = literPerMetricMile.ToString();
            textBoxLitSweMil.Text = literPerSwedishMile.ToString();
            textBoxCostKm.Text = costPerKm.ToString(); 
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
