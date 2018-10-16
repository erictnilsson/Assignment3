namespace Assignment3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxFuel = new System.Windows.Forms.GroupBox();
            this.buttonCalcFuel = new System.Windows.Forms.Button();
            this.textBoxLiterPriceInput = new System.Windows.Forms.TextBox();
            this.textBoxFuelInput = new System.Windows.Forms.TextBox();
            this.textBoxPrevOdoRead = new System.Windows.Forms.TextBox();
            this.textBoxCurrOdoRead = new System.Windows.Forms.TextBox();
            this.labelLiterPriceInput = new System.Windows.Forms.Label();
            this.labelFuelInput = new System.Windows.Forms.Label();
            this.labelPrevOdoRead = new System.Windows.Forms.Label();
            this.labelCurrOdoRead = new System.Windows.Forms.Label();
            this.GroupBoxResult = new System.Windows.Forms.GroupBox();
            this.textBoxCostKm = new System.Windows.Forms.TextBox();
            this.textBoxLitSweMil = new System.Windows.Forms.TextBox();
            this.textBoxLitMi = new System.Windows.Forms.TextBox();
            this.textBoxLitKm = new System.Windows.Forms.TextBox();
            this.textBoxKmLit = new System.Windows.Forms.TextBox();
            this.LabelCostKm = new System.Windows.Forms.Label();
            this.LabelLitSweMil = new System.Windows.Forms.Label();
            this.LabelLitMi = new System.Windows.Forms.Label();
            this.LabelLitKm = new System.Windows.Forms.Label();
            this.LabelKmLit = new System.Windows.Forms.Label();
            this.groupBoxBMI = new System.Windows.Forms.GroupBox();
            this.groupBoxResultBMI = new System.Windows.Forms.GroupBox();
            this.labelBmiName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelBmiHeight = new System.Windows.Forms.Label();
            this.textBoxBmiHeight = new System.Windows.Forms.TextBox();
            this.labelBmiWeight = new System.Windows.Forms.Label();
            this.textBoxBmiWeight = new System.Windows.Forms.TextBox();
            this.buttonCalcBmi = new System.Windows.Forms.Button();
            this.radioButtonBmiMetric = new System.Windows.Forms.RadioButton();
            this.radioButtonBmiImperial = new System.Windows.Forms.RadioButton();
            this.groupBoxFuel.SuspendLayout();
            this.GroupBoxResult.SuspendLayout();
            this.groupBoxBMI.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFuel
            // 
            this.groupBoxFuel.Controls.Add(this.buttonCalcFuel);
            this.groupBoxFuel.Controls.Add(this.textBoxLiterPriceInput);
            this.groupBoxFuel.Controls.Add(this.textBoxFuelInput);
            this.groupBoxFuel.Controls.Add(this.textBoxPrevOdoRead);
            this.groupBoxFuel.Controls.Add(this.textBoxCurrOdoRead);
            this.groupBoxFuel.Controls.Add(this.labelLiterPriceInput);
            this.groupBoxFuel.Controls.Add(this.labelFuelInput);
            this.groupBoxFuel.Controls.Add(this.labelPrevOdoRead);
            this.groupBoxFuel.Controls.Add(this.labelCurrOdoRead);
            this.groupBoxFuel.Location = new System.Drawing.Point(6, 6);
            this.groupBoxFuel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFuel.Name = "groupBoxFuel";
            this.groupBoxFuel.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFuel.Size = new System.Drawing.Size(352, 208);
            this.groupBoxFuel.TabIndex = 0;
            this.groupBoxFuel.TabStop = false;
            this.groupBoxFuel.Text = "Fuel";
            this.groupBoxFuel.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // buttonCalcFuel
            // 
            this.buttonCalcFuel.Location = new System.Drawing.Point(6, 145);
            this.buttonCalcFuel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCalcFuel.Name = "buttonCalcFuel";
            this.buttonCalcFuel.Size = new System.Drawing.Size(330, 38);
            this.buttonCalcFuel.TabIndex = 8;
            this.buttonCalcFuel.Text = "Calculate";
            this.buttonCalcFuel.UseVisualStyleBackColor = true;
            this.buttonCalcFuel.Click += new System.EventHandler(this.ButtonCalcFuel_Click);
            // 
            // textBoxLiterPriceInput
            // 
            this.textBoxLiterPriceInput.Location = new System.Drawing.Point(227, 111);
            this.textBoxLiterPriceInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLiterPriceInput.Name = "textBoxLiterPriceInput";
            this.textBoxLiterPriceInput.Size = new System.Drawing.Size(121, 20);
            this.textBoxLiterPriceInput.TabIndex = 7;
            // 
            // textBoxFuelInput
            // 
            this.textBoxFuelInput.Location = new System.Drawing.Point(227, 80);
            this.textBoxFuelInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFuelInput.Name = "textBoxFuelInput";
            this.textBoxFuelInput.Size = new System.Drawing.Size(121, 20);
            this.textBoxFuelInput.TabIndex = 6;
            // 
            // textBoxPrevOdoRead
            // 
            this.textBoxPrevOdoRead.Location = new System.Drawing.Point(227, 49);
            this.textBoxPrevOdoRead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPrevOdoRead.Name = "textBoxPrevOdoRead";
            this.textBoxPrevOdoRead.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrevOdoRead.TabIndex = 5;
            // 
            // textBoxCurrOdoRead
            // 
            this.textBoxCurrOdoRead.Location = new System.Drawing.Point(227, 14);
            this.textBoxCurrOdoRead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCurrOdoRead.Name = "textBoxCurrOdoRead";
            this.textBoxCurrOdoRead.Size = new System.Drawing.Size(121, 20);
            this.textBoxCurrOdoRead.TabIndex = 4;
            // 
            // labelLiterPriceInput
            // 
            this.labelLiterPriceInput.AutoSize = true;
            this.labelLiterPriceInput.Location = new System.Drawing.Point(4, 114);
            this.labelLiterPriceInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLiterPriceInput.Name = "labelLiterPriceInput";
            this.labelLiterPriceInput.Size = new System.Drawing.Size(98, 13);
            this.labelLiterPriceInput.TabIndex = 3;
            this.labelLiterPriceInput.Text = "Price per liter (SEK)";
            // 
            // labelFuelInput
            // 
            this.labelFuelInput.AutoSize = true;
            this.labelFuelInput.Location = new System.Drawing.Point(4, 83);
            this.labelFuelInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFuelInput.Name = "labelFuelInput";
            this.labelFuelInput.Size = new System.Drawing.Size(177, 13);
            this.labelFuelInput.TabIndex = 2;
            this.labelFuelInput.Text = "Current amount of fuel tanked (liters)";
            // 
            // labelPrevOdoRead
            // 
            this.labelPrevOdoRead.AutoSize = true;
            this.labelPrevOdoRead.Location = new System.Drawing.Point(4, 52);
            this.labelPrevOdoRead.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrevOdoRead.Name = "labelPrevOdoRead";
            this.labelPrevOdoRead.Size = new System.Drawing.Size(158, 13);
            this.labelPrevOdoRead.TabIndex = 1;
            this.labelPrevOdoRead.Text = "Previous Odometer reading (km)";
            // 
            // labelCurrOdoRead
            // 
            this.labelCurrOdoRead.AutoSize = true;
            this.labelCurrOdoRead.Location = new System.Drawing.Point(4, 21);
            this.labelCurrOdoRead.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrOdoRead.Name = "labelCurrOdoRead";
            this.labelCurrOdoRead.Size = new System.Drawing.Size(151, 13);
            this.labelCurrOdoRead.TabIndex = 0;
            this.labelCurrOdoRead.Text = "Current Odometer reading (km)";
            this.labelCurrOdoRead.Click += new System.EventHandler(this.Label1_Click);
            // 
            // GroupBoxResult
            // 
            this.GroupBoxResult.Controls.Add(this.textBoxCostKm);
            this.GroupBoxResult.Controls.Add(this.textBoxLitSweMil);
            this.GroupBoxResult.Controls.Add(this.textBoxLitMi);
            this.GroupBoxResult.Controls.Add(this.textBoxLitKm);
            this.GroupBoxResult.Controls.Add(this.textBoxKmLit);
            this.GroupBoxResult.Controls.Add(this.LabelCostKm);
            this.GroupBoxResult.Controls.Add(this.LabelLitSweMil);
            this.GroupBoxResult.Controls.Add(this.LabelLitMi);
            this.GroupBoxResult.Controls.Add(this.LabelLitKm);
            this.GroupBoxResult.Controls.Add(this.LabelKmLit);
            this.GroupBoxResult.Location = new System.Drawing.Point(6, 218);
            this.GroupBoxResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxResult.Name = "GroupBoxResult";
            this.GroupBoxResult.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxResult.Size = new System.Drawing.Size(352, 195);
            this.GroupBoxResult.TabIndex = 1;
            this.GroupBoxResult.TabStop = false;
            this.GroupBoxResult.Text = "Result";
            this.GroupBoxResult.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // textBoxCostKm
            // 
            this.textBoxCostKm.Location = new System.Drawing.Point(227, 142);
            this.textBoxCostKm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCostKm.Name = "textBoxCostKm";
            this.textBoxCostKm.ReadOnly = true;
            this.textBoxCostKm.Size = new System.Drawing.Size(121, 20);
            this.textBoxCostKm.TabIndex = 9;
            // 
            // textBoxLitSweMil
            // 
            this.textBoxLitSweMil.Location = new System.Drawing.Point(227, 111);
            this.textBoxLitSweMil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLitSweMil.Name = "textBoxLitSweMil";
            this.textBoxLitSweMil.ReadOnly = true;
            this.textBoxLitSweMil.Size = new System.Drawing.Size(121, 20);
            this.textBoxLitSweMil.TabIndex = 8;
            // 
            // textBoxLitMi
            // 
            this.textBoxLitMi.Location = new System.Drawing.Point(227, 80);
            this.textBoxLitMi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLitMi.Name = "textBoxLitMi";
            this.textBoxLitMi.ReadOnly = true;
            this.textBoxLitMi.Size = new System.Drawing.Size(121, 20);
            this.textBoxLitMi.TabIndex = 7;
            // 
            // textBoxLitKm
            // 
            this.textBoxLitKm.Location = new System.Drawing.Point(227, 49);
            this.textBoxLitKm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLitKm.Name = "textBoxLitKm";
            this.textBoxLitKm.ReadOnly = true;
            this.textBoxLitKm.Size = new System.Drawing.Size(121, 20);
            this.textBoxLitKm.TabIndex = 6;
            // 
            // textBoxKmLit
            // 
            this.textBoxKmLit.Location = new System.Drawing.Point(227, 18);
            this.textBoxKmLit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKmLit.Name = "textBoxKmLit";
            this.textBoxKmLit.ReadOnly = true;
            this.textBoxKmLit.Size = new System.Drawing.Size(121, 20);
            this.textBoxKmLit.TabIndex = 5;
            // 
            // LabelCostKm
            // 
            this.LabelCostKm.AutoSize = true;
            this.LabelCostKm.Location = new System.Drawing.Point(9, 146);
            this.LabelCostKm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCostKm.Name = "LabelCostKm";
            this.LabelCostKm.Size = new System.Drawing.Size(122, 13);
            this.LabelCostKm.TabIndex = 4;
            this.LabelCostKm.Text = "Cost per Kilometer (SEK)";
            // 
            // LabelLitSweMil
            // 
            this.LabelLitSweMil.AutoSize = true;
            this.LabelLitSweMil.Location = new System.Drawing.Point(9, 114);
            this.LabelLitSweMil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelLitSweMil.Name = "LabelLitSweMil";
            this.LabelLitSweMil.Size = new System.Drawing.Size(124, 13);
            this.LabelLitSweMil.TabIndex = 3;
            this.LabelLitSweMil.Text = "Fuel Consumption (lit/mil)";
            // 
            // LabelLitMi
            // 
            this.LabelLitMi.AutoSize = true;
            this.LabelLitMi.Location = new System.Drawing.Point(6, 83);
            this.LabelLitMi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelLitMi.Name = "LabelLitMi";
            this.LabelLitMi.Size = new System.Drawing.Size(122, 13);
            this.LabelLitMi.TabIndex = 2;
            this.LabelLitMi.Text = "Fuel Consumption (lit/mi)";
            this.LabelLitMi.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabelLitKm
            // 
            this.LabelLitKm.AutoSize = true;
            this.LabelLitKm.Location = new System.Drawing.Point(6, 52);
            this.LabelLitKm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelLitKm.Name = "LabelLitKm";
            this.LabelLitKm.Size = new System.Drawing.Size(126, 13);
            this.LabelLitKm.TabIndex = 1;
            this.LabelLitKm.Text = "Fuel Consumption (lit/km)";
            // 
            // LabelKmLit
            // 
            this.LabelKmLit.AutoSize = true;
            this.LabelKmLit.Location = new System.Drawing.Point(6, 21);
            this.LabelKmLit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelKmLit.Name = "LabelKmLit";
            this.LabelKmLit.Size = new System.Drawing.Size(126, 13);
            this.LabelKmLit.TabIndex = 0;
            this.LabelKmLit.Text = "Fuel Consumption (km/lit)";
            // 
            // groupBoxBMI
            // 
            this.groupBoxBMI.Controls.Add(this.radioButtonBmiImperial);
            this.groupBoxBMI.Controls.Add(this.radioButtonBmiMetric);
            this.groupBoxBMI.Controls.Add(this.buttonCalcBmi);
            this.groupBoxBMI.Controls.Add(this.textBoxBmiWeight);
            this.groupBoxBMI.Controls.Add(this.labelBmiWeight);
            this.groupBoxBMI.Controls.Add(this.textBoxBmiHeight);
            this.groupBoxBMI.Controls.Add(this.labelBmiHeight);
            this.groupBoxBMI.Controls.Add(this.textBox1);
            this.groupBoxBMI.Controls.Add(this.labelBmiName);
            this.groupBoxBMI.Location = new System.Drawing.Point(364, 6);
            this.groupBoxBMI.Name = "groupBoxBMI";
            this.groupBoxBMI.Size = new System.Drawing.Size(352, 208);
            this.groupBoxBMI.TabIndex = 2;
            this.groupBoxBMI.TabStop = false;
            this.groupBoxBMI.Text = "BMI";
            // 
            // groupBoxResultBMI
            // 
            this.groupBoxResultBMI.Location = new System.Drawing.Point(364, 218);
            this.groupBoxResultBMI.Name = "groupBoxResultBMI";
            this.groupBoxResultBMI.Size = new System.Drawing.Size(352, 194);
            this.groupBoxResultBMI.TabIndex = 3;
            this.groupBoxResultBMI.TabStop = false;
            this.groupBoxResultBMI.Text = "Result";
            // 
            // labelBmiName
            // 
            this.labelBmiName.AutoSize = true;
            this.labelBmiName.Location = new System.Drawing.Point(5, 21);
            this.labelBmiName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBmiName.Name = "labelBmiName";
            this.labelBmiName.Size = new System.Drawing.Size(66, 13);
            this.labelBmiName.TabIndex = 1;
            this.labelBmiName.Text = "Your Name: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 9;
            // 
            // labelBmiHeight
            // 
            this.labelBmiHeight.AutoSize = true;
            this.labelBmiHeight.Location = new System.Drawing.Point(5, 52);
            this.labelBmiHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBmiHeight.Name = "labelBmiHeight";
            this.labelBmiHeight.Size = new System.Drawing.Size(69, 13);
            this.labelBmiHeight.TabIndex = 10;
            this.labelBmiHeight.Text = "Your Height: ";
            // 
            // textBoxBmiHeight
            // 
            this.textBoxBmiHeight.Location = new System.Drawing.Point(134, 45);
            this.textBoxBmiHeight.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBmiHeight.Name = "textBoxBmiHeight";
            this.textBoxBmiHeight.Size = new System.Drawing.Size(62, 20);
            this.textBoxBmiHeight.TabIndex = 9;
            // 
            // labelBmiWeight
            // 
            this.labelBmiWeight.AutoSize = true;
            this.labelBmiWeight.Location = new System.Drawing.Point(5, 83);
            this.labelBmiWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBmiWeight.Name = "labelBmiWeight";
            this.labelBmiWeight.Size = new System.Drawing.Size(72, 13);
            this.labelBmiWeight.TabIndex = 11;
            this.labelBmiWeight.Text = "Your Weight: ";
            // 
            // textBoxBmiWeight
            // 
            this.textBoxBmiWeight.Location = new System.Drawing.Point(134, 73);
            this.textBoxBmiWeight.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBmiWeight.Name = "textBoxBmiWeight";
            this.textBoxBmiWeight.Size = new System.Drawing.Size(62, 20);
            this.textBoxBmiWeight.TabIndex = 12;
            // 
            // buttonCalcBmi
            // 
            this.buttonCalcBmi.Location = new System.Drawing.Point(8, 145);
            this.buttonCalcBmi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCalcBmi.Name = "buttonCalcBmi";
            this.buttonCalcBmi.Size = new System.Drawing.Size(330, 38);
            this.buttonCalcBmi.TabIndex = 9;
            this.buttonCalcBmi.Text = "Calculate";
            this.buttonCalcBmi.UseVisualStyleBackColor = true;
            this.buttonCalcBmi.Click += new System.EventHandler(this.buttonCalcBmi_Click);
            // 
            // radioButtonBmiMetric
            // 
            this.radioButtonBmiMetric.AutoSize = true;
            this.radioButtonBmiMetric.Location = new System.Drawing.Point(284, 48);
            this.radioButtonBmiMetric.Name = "radioButtonBmiMetric";
            this.radioButtonBmiMetric.Size = new System.Drawing.Size(54, 17);
            this.radioButtonBmiMetric.TabIndex = 13;
            this.radioButtonBmiMetric.TabStop = true;
            this.radioButtonBmiMetric.Text = "Metric";
            this.radioButtonBmiMetric.UseVisualStyleBackColor = true;
            this.radioButtonBmiMetric.CheckedChanged += new System.EventHandler(this.radioButtonBmiMetric_CheckedChanged);
            // 
            // radioButtonBmiImperial
            // 
            this.radioButtonBmiImperial.AutoSize = true;
            this.radioButtonBmiImperial.Location = new System.Drawing.Point(284, 76);
            this.radioButtonBmiImperial.Name = "radioButtonBmiImperial";
            this.radioButtonBmiImperial.Size = new System.Drawing.Size(61, 17);
            this.radioButtonBmiImperial.TabIndex = 14;
            this.radioButtonBmiImperial.TabStop = true;
            this.radioButtonBmiImperial.Text = "Imperial";
            this.radioButtonBmiImperial.UseVisualStyleBackColor = true;
            this.radioButtonBmiImperial.CheckedChanged += new System.EventHandler(this.radioButtonBmiUs_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 424);
            this.Controls.Add(this.groupBoxResultBMI);
            this.Controls.Add(this.groupBoxBMI);
            this.Controls.Add(this.GroupBoxResult);
            this.Controls.Add(this.groupBoxFuel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxFuel.ResumeLayout(false);
            this.groupBoxFuel.PerformLayout();
            this.GroupBoxResult.ResumeLayout(false);
            this.GroupBoxResult.PerformLayout();
            this.groupBoxBMI.ResumeLayout(false);
            this.groupBoxBMI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFuel;
        private System.Windows.Forms.Label labelCurrOdoRead;
        private System.Windows.Forms.Button buttonCalcFuel;
        private System.Windows.Forms.TextBox textBoxLiterPriceInput;
        private System.Windows.Forms.TextBox textBoxFuelInput;
        private System.Windows.Forms.TextBox textBoxPrevOdoRead;
        private System.Windows.Forms.TextBox textBoxCurrOdoRead;
        private System.Windows.Forms.Label labelLiterPriceInput;
        private System.Windows.Forms.Label labelFuelInput;
        private System.Windows.Forms.Label labelPrevOdoRead;
        private System.Windows.Forms.GroupBox GroupBoxResult;
        private System.Windows.Forms.Label LabelLitMi;
        private System.Windows.Forms.Label LabelLitKm;
        private System.Windows.Forms.Label LabelKmLit;
        private System.Windows.Forms.Label LabelCostKm;
        private System.Windows.Forms.Label LabelLitSweMil;
        private System.Windows.Forms.TextBox textBoxCostKm;
        private System.Windows.Forms.TextBox textBoxLitSweMil;
        private System.Windows.Forms.TextBox textBoxLitMi;
        private System.Windows.Forms.TextBox textBoxLitKm;
        private System.Windows.Forms.TextBox textBoxKmLit;
        private System.Windows.Forms.GroupBox groupBoxBMI;
        private System.Windows.Forms.GroupBox groupBoxResultBMI;
        private System.Windows.Forms.RadioButton radioButtonBmiImperial;
        private System.Windows.Forms.RadioButton radioButtonBmiMetric;
        private System.Windows.Forms.Button buttonCalcBmi;
        private System.Windows.Forms.TextBox textBoxBmiWeight;
        private System.Windows.Forms.Label labelBmiWeight;
        private System.Windows.Forms.TextBox textBoxBmiHeight;
        private System.Windows.Forms.Label labelBmiHeight;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelBmiName;
    }
}

