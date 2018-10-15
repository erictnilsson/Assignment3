namespace Assignment3
{
    partial class Form1
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
            this.LabelKmLit = new System.Windows.Forms.Label();
            this.LabelLitKm = new System.Windows.Forms.Label();
            this.LabelLitMi = new System.Windows.Forms.Label();
            this.LabelLitSweMil = new System.Windows.Forms.Label();
            this.LabelCostKm = new System.Windows.Forms.Label();
            this.textBoxKmLit = new System.Windows.Forms.TextBox();
            this.textBoxLitKm = new System.Windows.Forms.TextBox();
            this.textBoxLitMi = new System.Windows.Forms.TextBox();
            this.textBoxLitSweMil = new System.Windows.Forms.TextBox();
            this.textBoxCostKm = new System.Windows.Forms.TextBox();
            this.groupBoxFuel.SuspendLayout();
            this.GroupBoxResult.SuspendLayout();
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
            this.groupBoxFuel.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFuel.Name = "groupBoxFuel";
            this.groupBoxFuel.Size = new System.Drawing.Size(704, 400);
            this.groupBoxFuel.TabIndex = 0;
            this.groupBoxFuel.TabStop = false;
            this.groupBoxFuel.Text = "Fuel";
            this.groupBoxFuel.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // buttonCalcFuel
            // 
            this.buttonCalcFuel.Location = new System.Drawing.Point(12, 278);
            this.buttonCalcFuel.Name = "buttonCalcFuel";
            this.buttonCalcFuel.Size = new System.Drawing.Size(660, 73);
            this.buttonCalcFuel.TabIndex = 8;
            this.buttonCalcFuel.Text = "Calculate";
            this.buttonCalcFuel.UseVisualStyleBackColor = true;
            this.buttonCalcFuel.Click += new System.EventHandler(this.ButtonCalcFuel_Click);
            // 
            // textBoxLiterPriceInput
            // 
            this.textBoxLiterPriceInput.Location = new System.Drawing.Point(434, 214);
            this.textBoxLiterPriceInput.Name = "textBoxLiterPriceInput";
            this.textBoxLiterPriceInput.Size = new System.Drawing.Size(238, 31);
            this.textBoxLiterPriceInput.TabIndex = 7;
            // 
            // textBoxFuelInput
            // 
            this.textBoxFuelInput.Location = new System.Drawing.Point(434, 154);
            this.textBoxFuelInput.Name = "textBoxFuelInput";
            this.textBoxFuelInput.Size = new System.Drawing.Size(238, 31);
            this.textBoxFuelInput.TabIndex = 6;
            // 
            // textBoxPrevOdoRead
            // 
            this.textBoxPrevOdoRead.Location = new System.Drawing.Point(434, 94);
            this.textBoxPrevOdoRead.Name = "textBoxPrevOdoRead";
            this.textBoxPrevOdoRead.Size = new System.Drawing.Size(238, 31);
            this.textBoxPrevOdoRead.TabIndex = 5;
            // 
            // textBoxCurrOdoRead
            // 
            this.textBoxCurrOdoRead.Location = new System.Drawing.Point(434, 30);
            this.textBoxCurrOdoRead.Name = "textBoxCurrOdoRead";
            this.textBoxCurrOdoRead.Size = new System.Drawing.Size(238, 31);
            this.textBoxCurrOdoRead.TabIndex = 4;
            // 
            // labelLiterPriceInput
            // 
            this.labelLiterPriceInput.AutoSize = true;
            this.labelLiterPriceInput.Location = new System.Drawing.Point(7, 220);
            this.labelLiterPriceInput.Name = "labelLiterPriceInput";
            this.labelLiterPriceInput.Size = new System.Drawing.Size(201, 25);
            this.labelLiterPriceInput.TabIndex = 3;
            this.labelLiterPriceInput.Text = "Price per liter (SEK)";
            // 
            // labelFuelInput
            // 
            this.labelFuelInput.AutoSize = true;
            this.labelFuelInput.Location = new System.Drawing.Point(7, 160);
            this.labelFuelInput.Name = "labelFuelInput";
            this.labelFuelInput.Size = new System.Drawing.Size(362, 25);
            this.labelFuelInput.TabIndex = 2;
            this.labelFuelInput.Text = "Current amount of fuel tanked (liters)";
            // 
            // labelPrevOdoRead
            // 
            this.labelPrevOdoRead.AutoSize = true;
            this.labelPrevOdoRead.Location = new System.Drawing.Point(7, 100);
            this.labelPrevOdoRead.Name = "labelPrevOdoRead";
            this.labelPrevOdoRead.Size = new System.Drawing.Size(322, 25);
            this.labelPrevOdoRead.TabIndex = 1;
            this.labelPrevOdoRead.Text = "Previous Odometer reading (km)";
            // 
            // labelCurrOdoRead
            // 
            this.labelCurrOdoRead.AutoSize = true;
            this.labelCurrOdoRead.Location = new System.Drawing.Point(7, 40);
            this.labelCurrOdoRead.Name = "labelCurrOdoRead";
            this.labelCurrOdoRead.Size = new System.Drawing.Size(309, 25);
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
            this.GroupBoxResult.Location = new System.Drawing.Point(12, 419);
            this.GroupBoxResult.Name = "GroupBoxResult";
            this.GroupBoxResult.Size = new System.Drawing.Size(704, 375);
            this.GroupBoxResult.TabIndex = 1;
            this.GroupBoxResult.TabStop = false;
            this.GroupBoxResult.Text = "Result";
            this.GroupBoxResult.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // LabelKmLit
            // 
            this.LabelKmLit.AutoSize = true;
            this.LabelKmLit.Location = new System.Drawing.Point(12, 40);
            this.LabelKmLit.Name = "LabelKmLit";
            this.LabelKmLit.Size = new System.Drawing.Size(256, 25);
            this.LabelKmLit.TabIndex = 0;
            this.LabelKmLit.Text = "Fuel Consumption (km/lit)";
            // 
            // LabelLitKm
            // 
            this.LabelLitKm.AutoSize = true;
            this.LabelLitKm.Location = new System.Drawing.Point(12, 100);
            this.LabelLitKm.Name = "LabelLitKm";
            this.LabelLitKm.Size = new System.Drawing.Size(256, 25);
            this.LabelLitKm.TabIndex = 1;
            this.LabelLitKm.Text = "Fuel Consumption (lit/km)";
            // 
            // LabelLitMi
            // 
            this.LabelLitMi.AutoSize = true;
            this.LabelLitMi.Location = new System.Drawing.Point(12, 160);
            this.LabelLitMi.Name = "LabelLitMi";
            this.LabelLitMi.Size = new System.Drawing.Size(250, 25);
            this.LabelLitMi.TabIndex = 2;
            this.LabelLitMi.Text = "Fuel Consumption (lit/mi)";
            this.LabelLitMi.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabelLitSweMil
            // 
            this.LabelLitSweMil.AutoSize = true;
            this.LabelLitSweMil.Location = new System.Drawing.Point(18, 220);
            this.LabelLitSweMil.Name = "LabelLitSweMil";
            this.LabelLitSweMil.Size = new System.Drawing.Size(255, 25);
            this.LabelLitSweMil.TabIndex = 3;
            this.LabelLitSweMil.Text = "Fuel Consumption (lit/mil)";
            // 
            // LabelCostKm
            // 
            this.LabelCostKm.AutoSize = true;
            this.LabelCostKm.Location = new System.Drawing.Point(18, 280);
            this.LabelCostKm.Name = "LabelCostKm";
            this.LabelCostKm.Size = new System.Drawing.Size(251, 25);
            this.LabelCostKm.TabIndex = 4;
            this.LabelCostKm.Text = "Cost per Kilometer (SEK)";
            // 
            // textBoxKmLit
            // 
            this.textBoxKmLit.Location = new System.Drawing.Point(434, 34);
            this.textBoxKmLit.Name = "textBoxKmLit";
            this.textBoxKmLit.ReadOnly = true;
            this.textBoxKmLit.Size = new System.Drawing.Size(238, 31);
            this.textBoxKmLit.TabIndex = 5;
            // 
            // textBoxLitKm
            // 
            this.textBoxLitKm.Location = new System.Drawing.Point(434, 94);
            this.textBoxLitKm.Name = "textBoxLitKm";
            this.textBoxLitKm.ReadOnly = true;
            this.textBoxLitKm.Size = new System.Drawing.Size(238, 31);
            this.textBoxLitKm.TabIndex = 6;
            // 
            // textBoxLitMi
            // 
            this.textBoxLitMi.Location = new System.Drawing.Point(434, 154);
            this.textBoxLitMi.Name = "textBoxLitMi";
            this.textBoxLitMi.ReadOnly = true;
            this.textBoxLitMi.Size = new System.Drawing.Size(238, 31);
            this.textBoxLitMi.TabIndex = 7;
            // 
            // textBoxLitSweMil
            // 
            this.textBoxLitSweMil.Location = new System.Drawing.Point(434, 214);
            this.textBoxLitSweMil.Name = "textBoxLitSweMil";
            this.textBoxLitSweMil.ReadOnly = true;
            this.textBoxLitSweMil.Size = new System.Drawing.Size(238, 31);
            this.textBoxLitSweMil.TabIndex = 8;
            // 
            // textBoxCostKm
            // 
            this.textBoxCostKm.Location = new System.Drawing.Point(434, 274);
            this.textBoxCostKm.Name = "textBoxCostKm";
            this.textBoxCostKm.ReadOnly = true;
            this.textBoxCostKm.Size = new System.Drawing.Size(238, 31);
            this.textBoxCostKm.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2428, 1249);
            this.Controls.Add(this.GroupBoxResult);
            this.Controls.Add(this.groupBoxFuel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxFuel.ResumeLayout(false);
            this.groupBoxFuel.PerformLayout();
            this.GroupBoxResult.ResumeLayout(false);
            this.GroupBoxResult.PerformLayout();
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
    }
}

