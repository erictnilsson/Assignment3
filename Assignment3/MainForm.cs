using Assignment3.Calculators;
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
    public partial class MainForm : Form
    {

        private FuelCalculator fuelCalculator = new FuelCalculator();
        private BMICalculator bmiCalculator = new BMICalculator();
        private string errorMsg;
        private string name;

        public MainForm()
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

            if (!ReadInputFuel())
            {
                MessageBox.Show(errorMsg);
                //ResetFuelInput();
            }
            else
            {
                UpdateGUIFuel();
            }
        }

        private void ResetFuelInput()
        {
            textBoxCurrOdoRead.Text = null;
            textBoxPrevOdoRead.Text = null;
            textBoxFuelInput.Text = null;
            textBoxLiterPriceInput.Text = null;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateFuelInput()
        {
            // check if null
            if (textBoxCurrOdoRead.Text == null || textBoxPrevOdoRead.Text == null || textBoxFuelInput.Text == null || textBoxLiterPriceInput.Text == null)
            {
                errorMsg = "Make sure to fill out all fields.";
                return false;
            }
            // check if numerical doubles *DOES NOT WORK*
            else if ((!double.TryParse(textBoxCurrOdoRead.Text, out double val) || !double.TryParse(textBoxPrevOdoRead.Text, out val) || !double.TryParse(textBoxFuelInput.Text, out val) || !double.TryParse(textBoxLiterPriceInput.Text, out val)))
            {
                errorMsg = "Make sure to only enter valid numerals.";
                return false;
            }
            return true;
        }

        private bool ReadInputFuel()
        {
            if (ValidateFuelInput())
            {
                var currReading = double.Parse(textBoxCurrOdoRead.Text);
                var prevReading = double.Parse(textBoxPrevOdoRead.Text);
                var fuelAmount = double.Parse(textBoxFuelInput.Text);
                var unitPrice = double.Parse(textBoxLiterPriceInput.Text);

                // check if positive number
                if (currReading < 0 || prevReading < 0 || fuelAmount < 0 || unitPrice < 0)
                {
                    errorMsg = "Make sure that all numerals are positive.";
                    return false;

                }
                // check if currReading > prevReading
                else if (currReading < prevReading)
                {
                    errorMsg = "The current odometer reading must be larger than the previous odometer reading.";
                    return false;
                }
                else
                {
                    fuelCalculator = new FuelCalculator(currReading, fuelAmount, prevReading, unitPrice);
                    return true;
                }
            }
            return false;
        }

        private bool ValidateBmiInput()
        {
            // check if numerical floats
            if ((!float.TryParse(textBoxBmiHeight.Text, out float val) || !float.TryParse(textBoxBmiWeight.Text, out val)))
            {
                errorMsg = "Make sure to only enter valid numerals";
                return false;
            }
            return true;
        }

        private bool ReadInputBmi()
        {
            if (!SetName(textBoxBmiName.Text))
                MessageBox.Show(errorMsg); 

            if (ValidateBmiInput())
            {

                var height = float.Parse(textBoxBmiHeight.Text);
                var weight = float.Parse(textBoxBmiWeight.Text);
                var metric = false;

                if (radioButtonBmiMetric.Checked)
                    metric = true;

                else if (radioButtonBmiImperial.Checked)
                    metric = false;

                var result = bmiCalculator.CalcBMI(metric, height, weight);
                return true;
            }
            return false; 
            
        }

        private void UpdateGUIBmi()
        {
            groupBoxResultBMI.Text = "Result for " + name + ":"; 
        }

        private void UpdateGUIFuel()
        {
            textBoxKmLit.Text = fuelCalculator.CalcConsumptionKmPerLiter().ToString("0.00");
            textBoxLitKm.Text = fuelCalculator.CalcFuelConsumptionPerKm().ToString("0.00");
            textBoxLitMi.Text = fuelCalculator.CalcFuelConsumptionperMetricMile().ToString("0.00");
            textBoxLitSweMil.Text = fuelCalculator.CalcFuelConsumptionPerSweMil().ToString("0.00");
            textBoxCostKm.Text = fuelCalculator.CalcCostPerKm().ToString("0.00");
        }

        private void buttonCalcBmi_Click(object sender, EventArgs e)
        {
            if (!ReadInputBmi())
                MessageBox.Show(errorMsg); 
            else
            {
                UpdateGUIBmi(); 
            }
        }

        private bool SetName(string name)
        {
            if (name == null || name.Length < 1)
            {
                errorMsg = "Please enter a valid name.";
                return false; 
            } else
            {
                this.name = name;
                return true; 
            }

        }

        private void radioButtonBmiMetric_CheckedChanged(object sender, EventArgs e)
        {
            labelBmiHeight.Text = "Your Height (in meters):";
            labelBmiWeight.Text = "Your Weight (in kg):";
        }

        private void radioButtonBmiUs_CheckedChanged(object sender, EventArgs e)
        {
            labelBmiHeight.Text = "Your Height (in inches):";
            labelBmiWeight.Text = "Your Weight (in lbs):";
        }
    }
}
