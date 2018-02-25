namespace RentVsBuy
{
    partial class frmMain
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.grpRent = new System.Windows.Forms.GroupBox();
            this.lblRentalPaymentFrequency = new System.Windows.Forms.Label();
            this.cmbRentalPaymentFrequency = new System.Windows.Forms.ComboBox();
            this.txtCurrentRent = new System.Windows.Forms.TextBox();
            this.lblCurrentRent = new System.Windows.Forms.Label();
            this.grpBuy = new System.Windows.Forms.GroupBox();
            this.txtAnnualCosts = new System.Windows.Forms.TextBox();
            this.lblAnnualCosts = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.lblPurhcasePrice = new System.Windows.Forms.Label();
            this.grpBank = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.cmbMortgageTerm = new System.Windows.Forms.ComboBox();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblMortgageTerm = new System.Windows.Forms.Label();
            this.txtMortgageRate = new System.Windows.Forms.TextBox();
            this.lblMortgageRate = new System.Windows.Forms.Label();
            this.txtInterestOnSavings = new System.Windows.Forms.TextBox();
            this.lblInterestOnSavings = new System.Windows.Forms.Label();
            this.txtSavings = new System.Windows.Forms.TextBox();
            this.lblSavings = new System.Windows.Forms.Label();
            this.grpIncome = new System.Windows.Forms.GroupBox();
            this.txtAnnualExpenses = new System.Windows.Forms.TextBox();
            this.lblAnnualExpenses = new System.Windows.Forms.Label();
            this.txtAfterTaxIncome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.rtxResult = new System.Windows.Forms.RichTextBox();
            this.grpRent.SuspendLayout();
            this.grpBuy.SuspendLayout();
            this.grpBank.SuspendLayout();
            this.grpIncome.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(13, 13);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(124, 24);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Rent Vs Buy";
            // 
            // grpRent
            // 
            this.grpRent.Controls.Add(this.lblRentalPaymentFrequency);
            this.grpRent.Controls.Add(this.cmbRentalPaymentFrequency);
            this.grpRent.Controls.Add(this.txtCurrentRent);
            this.grpRent.Controls.Add(this.lblCurrentRent);
            this.grpRent.Location = new System.Drawing.Point(17, 41);
            this.grpRent.Name = "grpRent";
            this.grpRent.Size = new System.Drawing.Size(195, 84);
            this.grpRent.TabIndex = 0;
            this.grpRent.TabStop = false;
            this.grpRent.Text = "Rent";
            // 
            // lblRentalPaymentFrequency
            // 
            this.lblRentalPaymentFrequency.AutoSize = true;
            this.lblRentalPaymentFrequency.Location = new System.Drawing.Point(10, 52);
            this.lblRentalPaymentFrequency.Name = "lblRentalPaymentFrequency";
            this.lblRentalPaymentFrequency.Size = new System.Drawing.Size(57, 13);
            this.lblRentalPaymentFrequency.TabIndex = 2;
            this.lblRentalPaymentFrequency.Text = "Frequency";
            // 
            // cmbRentalPaymentFrequency
            // 
            this.cmbRentalPaymentFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRentalPaymentFrequency.FormattingEnabled = true;
            this.cmbRentalPaymentFrequency.Items.AddRange(new object[] {
            "Weekly",
            "Fortnightly",
            "Monthly",
            "Annually"});
            this.cmbRentalPaymentFrequency.Location = new System.Drawing.Point(94, 46);
            this.cmbRentalPaymentFrequency.Name = "cmbRentalPaymentFrequency";
            this.cmbRentalPaymentFrequency.Size = new System.Drawing.Size(91, 21);
            this.cmbRentalPaymentFrequency.TabIndex = 1;
            // 
            // txtCurrentRent
            // 
            this.txtCurrentRent.Location = new System.Drawing.Point(94, 17);
            this.txtCurrentRent.Name = "txtCurrentRent";
            this.txtCurrentRent.Size = new System.Drawing.Size(91, 20);
            this.txtCurrentRent.TabIndex = 0;
            this.txtCurrentRent.Leave += new System.EventHandler(this.txtCurrentRent_Leave);
            // 
            // lblCurrentRent
            // 
            this.lblCurrentRent.AutoSize = true;
            this.lblCurrentRent.Location = new System.Drawing.Point(7, 20);
            this.lblCurrentRent.Name = "lblCurrentRent";
            this.lblCurrentRent.Size = new System.Drawing.Size(70, 13);
            this.lblCurrentRent.TabIndex = 0;
            this.lblCurrentRent.Text = "Current Rent:";
            // 
            // grpBuy
            // 
            this.grpBuy.Controls.Add(this.txtAnnualCosts);
            this.grpBuy.Controls.Add(this.lblAnnualCosts);
            this.grpBuy.Controls.Add(this.txtPurchasePrice);
            this.grpBuy.Controls.Add(this.lblPurhcasePrice);
            this.grpBuy.Location = new System.Drawing.Point(17, 131);
            this.grpBuy.Name = "grpBuy";
            this.grpBuy.Size = new System.Drawing.Size(195, 84);
            this.grpBuy.TabIndex = 1;
            this.grpBuy.TabStop = false;
            this.grpBuy.Text = "Buy";
            // 
            // txtAnnualCosts
            // 
            this.txtAnnualCosts.Location = new System.Drawing.Point(94, 46);
            this.txtAnnualCosts.Name = "txtAnnualCosts";
            this.txtAnnualCosts.Size = new System.Drawing.Size(91, 20);
            this.txtAnnualCosts.TabIndex = 1;
            this.txtAnnualCosts.Leave += new System.EventHandler(this.txtAnnualCosts_Leave);
            // 
            // lblAnnualCosts
            // 
            this.lblAnnualCosts.AutoSize = true;
            this.lblAnnualCosts.Location = new System.Drawing.Point(6, 49);
            this.lblAnnualCosts.Name = "lblAnnualCosts";
            this.lblAnnualCosts.Size = new System.Drawing.Size(72, 13);
            this.lblAnnualCosts.TabIndex = 4;
            this.lblAnnualCosts.Text = "Annual Costs:";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(94, 20);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(91, 20);
            this.txtPurchasePrice.TabIndex = 0;
            this.txtPurchasePrice.Leave += new System.EventHandler(this.txtPurchasePrice_Leave);
            // 
            // lblPurhcasePrice
            // 
            this.lblPurhcasePrice.AutoSize = true;
            this.lblPurhcasePrice.Location = new System.Drawing.Point(6, 23);
            this.lblPurhcasePrice.Name = "lblPurhcasePrice";
            this.lblPurhcasePrice.Size = new System.Drawing.Size(82, 13);
            this.lblPurhcasePrice.TabIndex = 2;
            this.lblPurhcasePrice.Text = "Purchase Price:";
            // 
            // grpBank
            // 
            this.grpBank.Controls.Add(this.btnCalculate);
            this.grpBank.Controls.Add(this.cmbMortgageTerm);
            this.grpBank.Controls.Add(this.lblYears);
            this.grpBank.Controls.Add(this.lblMortgageTerm);
            this.grpBank.Controls.Add(this.txtMortgageRate);
            this.grpBank.Controls.Add(this.lblMortgageRate);
            this.grpBank.Controls.Add(this.txtInterestOnSavings);
            this.grpBank.Controls.Add(this.lblInterestOnSavings);
            this.grpBank.Controls.Add(this.txtSavings);
            this.grpBank.Controls.Add(this.lblSavings);
            this.grpBank.Location = new System.Drawing.Point(218, 41);
            this.grpBank.Name = "grpBank";
            this.grpBank.Size = new System.Drawing.Size(261, 264);
            this.grpBank.TabIndex = 3;
            this.grpBank.TabStop = false;
            this.grpBank.Text = "Bank";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(108, 235);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(147, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // cmbMortgageTerm
            // 
            this.cmbMortgageTerm.FormattingEnabled = true;
            this.cmbMortgageTerm.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cmbMortgageTerm.Location = new System.Drawing.Point(108, 99);
            this.cmbMortgageTerm.Name = "cmbMortgageTerm";
            this.cmbMortgageTerm.Size = new System.Drawing.Size(84, 21);
            this.cmbMortgageTerm.TabIndex = 3;
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(198, 101);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(32, 13);
            this.lblYears.TabIndex = 10;
            this.lblYears.Text = "years";
            // 
            // lblMortgageTerm
            // 
            this.lblMortgageTerm.AutoSize = true;
            this.lblMortgageTerm.Location = new System.Drawing.Point(6, 101);
            this.lblMortgageTerm.Name = "lblMortgageTerm";
            this.lblMortgageTerm.Size = new System.Drawing.Size(82, 13);
            this.lblMortgageTerm.TabIndex = 8;
            this.lblMortgageTerm.Text = "Mortgage Term:";
            // 
            // txtMortgageRate
            // 
            this.txtMortgageRate.Location = new System.Drawing.Point(108, 72);
            this.txtMortgageRate.Name = "txtMortgageRate";
            this.txtMortgageRate.Size = new System.Drawing.Size(147, 20);
            this.txtMortgageRate.TabIndex = 2;
            this.txtMortgageRate.Leave += new System.EventHandler(this.txtMortgageRate_Leave);
            // 
            // lblMortgageRate
            // 
            this.lblMortgageRate.AutoSize = true;
            this.lblMortgageRate.Location = new System.Drawing.Point(6, 75);
            this.lblMortgageRate.Name = "lblMortgageRate";
            this.lblMortgageRate.Size = new System.Drawing.Size(81, 13);
            this.lblMortgageRate.TabIndex = 6;
            this.lblMortgageRate.Text = "Mortgage Rate:";
            // 
            // txtInterestOnSavings
            // 
            this.txtInterestOnSavings.Location = new System.Drawing.Point(108, 46);
            this.txtInterestOnSavings.Name = "txtInterestOnSavings";
            this.txtInterestOnSavings.Size = new System.Drawing.Size(147, 20);
            this.txtInterestOnSavings.TabIndex = 1;
            this.txtInterestOnSavings.Leave += new System.EventHandler(this.txtInterestOnSavings_Leave);
            // 
            // lblInterestOnSavings
            // 
            this.lblInterestOnSavings.AutoSize = true;
            this.lblInterestOnSavings.Location = new System.Drawing.Point(6, 49);
            this.lblInterestOnSavings.Name = "lblInterestOnSavings";
            this.lblInterestOnSavings.Size = new System.Drawing.Size(101, 13);
            this.lblInterestOnSavings.TabIndex = 4;
            this.lblInterestOnSavings.Text = "Interest on Savings:";
            // 
            // txtSavings
            // 
            this.txtSavings.Location = new System.Drawing.Point(108, 20);
            this.txtSavings.Name = "txtSavings";
            this.txtSavings.Size = new System.Drawing.Size(147, 20);
            this.txtSavings.TabIndex = 0;
            this.txtSavings.Leave += new System.EventHandler(this.txtSavings_Leave);
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.Location = new System.Drawing.Point(6, 23);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(48, 13);
            this.lblSavings.TabIndex = 2;
            this.lblSavings.Text = "Savings:";
            // 
            // grpIncome
            // 
            this.grpIncome.Controls.Add(this.txtAnnualExpenses);
            this.grpIncome.Controls.Add(this.lblAnnualExpenses);
            this.grpIncome.Controls.Add(this.txtAfterTaxIncome);
            this.grpIncome.Controls.Add(this.label1);
            this.grpIncome.Location = new System.Drawing.Point(17, 221);
            this.grpIncome.Name = "grpIncome";
            this.grpIncome.Size = new System.Drawing.Size(195, 84);
            this.grpIncome.TabIndex = 2;
            this.grpIncome.TabStop = false;
            this.grpIncome.Text = "Income";
            // 
            // txtAnnualExpenses
            // 
            this.txtAnnualExpenses.Location = new System.Drawing.Point(94, 43);
            this.txtAnnualExpenses.Name = "txtAnnualExpenses";
            this.txtAnnualExpenses.Size = new System.Drawing.Size(91, 20);
            this.txtAnnualExpenses.TabIndex = 1;
            this.txtAnnualExpenses.Leave += new System.EventHandler(this.txtAnnualExpenses_Leave);
            // 
            // lblAnnualExpenses
            // 
            this.lblAnnualExpenses.AutoSize = true;
            this.lblAnnualExpenses.Location = new System.Drawing.Point(7, 46);
            this.lblAnnualExpenses.Name = "lblAnnualExpenses";
            this.lblAnnualExpenses.Size = new System.Drawing.Size(92, 13);
            this.lblAnnualExpenses.TabIndex = 2;
            this.lblAnnualExpenses.Text = "Annual Expenses:";
            // 
            // txtAfterTaxIncome
            // 
            this.txtAfterTaxIncome.Location = new System.Drawing.Point(94, 17);
            this.txtAfterTaxIncome.Name = "txtAfterTaxIncome";
            this.txtAfterTaxIncome.Size = new System.Drawing.Size(91, 20);
            this.txtAfterTaxIncome.TabIndex = 0;
            this.txtAfterTaxIncome.Leave += new System.EventHandler(this.txtAfterTaxIncome_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AfterTax Income:";
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.rtxResult);
            this.grpResult.Location = new System.Drawing.Point(486, 41);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(289, 376);
            this.grpResult.TabIndex = 7;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Result";
            // 
            // rtxResult
            // 
            this.rtxResult.Location = new System.Drawing.Point(7, 19);
            this.rtxResult.Name = "rtxResult";
            this.rtxResult.Size = new System.Drawing.Size(269, 351);
            this.rtxResult.TabIndex = 1;
            this.rtxResult.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 429);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpIncome);
            this.Controls.Add(this.grpBank);
            this.Controls.Add(this.grpBuy);
            this.Controls.Add(this.grpRent);
            this.Controls.Add(this.lblHeading);
            this.Name = "frmMain";
            this.Text = "Main";
            this.grpRent.ResumeLayout(false);
            this.grpRent.PerformLayout();
            this.grpBuy.ResumeLayout(false);
            this.grpBuy.PerformLayout();
            this.grpBank.ResumeLayout(false);
            this.grpBank.PerformLayout();
            this.grpIncome.ResumeLayout(false);
            this.grpIncome.PerformLayout();
            this.grpResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox grpRent;
        private System.Windows.Forms.TextBox txtCurrentRent;
        private System.Windows.Forms.Label lblCurrentRent;
        private System.Windows.Forms.GroupBox grpBuy;
        private System.Windows.Forms.TextBox txtAnnualCosts;
        private System.Windows.Forms.Label lblAnnualCosts;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label lblPurhcasePrice;
        private System.Windows.Forms.GroupBox grpBank;
        private System.Windows.Forms.ComboBox cmbMortgageTerm;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblMortgageTerm;
        private System.Windows.Forms.TextBox txtMortgageRate;
        private System.Windows.Forms.Label lblMortgageRate;
        private System.Windows.Forms.TextBox txtInterestOnSavings;
        private System.Windows.Forms.Label lblInterestOnSavings;
        private System.Windows.Forms.TextBox txtSavings;
        private System.Windows.Forms.Label lblSavings;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpIncome;
        private System.Windows.Forms.TextBox txtAfterTaxIncome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.ComboBox cmbRentalPaymentFrequency;
        private System.Windows.Forms.Label lblRentalPaymentFrequency;
        private System.Windows.Forms.TextBox txtAnnualExpenses;
        private System.Windows.Forms.Label lblAnnualExpenses;
        private System.Windows.Forms.RichTextBox rtxResult;
    }
}

