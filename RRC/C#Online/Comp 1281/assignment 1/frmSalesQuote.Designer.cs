namespace assignment_1
{
    partial class frmSalesQuote
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
            this.components = new System.ComponentModel.Container();
            this.GRPA = new System.Windows.Forms.GroupBox();
            this.chkComputer = new System.Windows.Forms.CheckBox();
            this.chkLeather = new System.Windows.Forms.CheckBox();
            this.chkStereo = new System.Windows.Forms.CheckBox();
            this.VehicleSalePrice = new System.Windows.Forms.TextBox();
            this.VehPrice = new System.Windows.Forms.Label();
            this.TradeInValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExtFinish = new System.Windows.Forms.GroupBox();
            this.ExtCustom = new System.Windows.Forms.RadioButton();
            this.ExtPearlized = new System.Windows.Forms.RadioButton();
            this.ExtStandard = new System.Windows.Forms.RadioButton();
            this.Summary = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountDue = new System.Windows.Forms.TextBox();
            this.TradeIn = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.SalesTax = new System.Windows.Forms.TextBox();
            this.Subtotal = new System.Windows.Forms.TextBox();
            this.Options = new System.Windows.Forms.TextBox();
            this.VehicleSalePriceRead = new System.Windows.Forms.TextBox();
            this.Finance = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MonthlyPayment = new System.Windows.Forms.TextBox();
            this.AnnualIntrest = new System.Windows.Forms.Label();
            this.years = new System.Windows.Forms.Label();
            this.annualInterest = new System.Windows.Forms.NumericUpDown();
            this.numberYears = new System.Windows.Forms.NumericUpDown();
            this.Reset = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GRPA.SuspendLayout();
            this.ExtFinish.SuspendLayout();
            this.Summary.SuspendLayout();
            this.Finance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.annualInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // GRPA
            // 
            this.GRPA.Controls.Add(this.chkComputer);
            this.GRPA.Controls.Add(this.chkLeather);
            this.GRPA.Controls.Add(this.chkStereo);
            this.GRPA.Location = new System.Drawing.Point(48, 102);
            this.GRPA.Name = "GRPA";
            this.GRPA.Size = new System.Drawing.Size(237, 153);
            this.GRPA.TabIndex = 2;
            this.GRPA.TabStop = false;
            this.GRPA.Text = "Accessories";
            // 
            // chkComputer
            // 
            this.chkComputer.AutoSize = true;
            this.chkComputer.Location = new System.Drawing.Point(16, 91);
            this.chkComputer.Name = "chkComputer";
            this.chkComputer.Size = new System.Drawing.Size(125, 17);
            this.chkComputer.TabIndex = 2;
            this.chkComputer.Text = "Computer Navigation";
            this.chkComputer.UseVisualStyleBackColor = true;
            // 
            // chkLeather
            // 
            this.chkLeather.AutoSize = true;
            this.chkLeather.Location = new System.Drawing.Point(16, 68);
            this.chkLeather.Name = "chkLeather";
            this.chkLeather.Size = new System.Drawing.Size(97, 17);
            this.chkLeather.TabIndex = 1;
            this.chkLeather.Text = "Leather Interior";
            this.chkLeather.UseVisualStyleBackColor = true;
            // 
            // chkStereo
            // 
            this.chkStereo.AutoSize = true;
            this.chkStereo.Location = new System.Drawing.Point(16, 45);
            this.chkStereo.Name = "chkStereo";
            this.chkStereo.Size = new System.Drawing.Size(94, 17);
            this.chkStereo.TabIndex = 0;
            this.chkStereo.Text = "Stereo System";
            this.chkStereo.UseVisualStyleBackColor = true;
            // 
            // VehicleSalePrice
            // 
            this.errorProvider.SetIconPadding(this.VehicleSalePrice, 3);
            this.VehicleSalePrice.Location = new System.Drawing.Point(151, 26);
            this.VehicleSalePrice.Name = "VehicleSalePrice";
            this.VehicleSalePrice.Size = new System.Drawing.Size(134, 20);
            this.VehicleSalePrice.TabIndex = 0;
            this.VehicleSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // VehPrice
            // 
            this.VehPrice.AutoSize = true;
            this.VehPrice.Location = new System.Drawing.Point(45, 29);
            this.VehPrice.Name = "VehPrice";
            this.VehPrice.Size = new System.Drawing.Size(100, 13);
            this.VehPrice.TabIndex = 2;
            this.VehPrice.Text = "Vehicle\'s Sale Price";
            // 
            // TradeInValue
            // 
            this.TradeInValue.Location = new System.Drawing.Point(151, 65);
            this.TradeInValue.Name = "TradeInValue";
            this.TradeInValue.Size = new System.Drawing.Size(134, 20);
            this.TradeInValue.TabIndex = 1;
            this.TradeInValue.Text = "0";
            this.TradeInValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trade-in Value";
            // 
            // ExtFinish
            // 
            this.ExtFinish.Controls.Add(this.ExtCustom);
            this.ExtFinish.Controls.Add(this.ExtPearlized);
            this.ExtFinish.Controls.Add(this.ExtStandard);
            this.ExtFinish.Location = new System.Drawing.Point(48, 273);
            this.ExtFinish.Name = "ExtFinish";
            this.ExtFinish.Size = new System.Drawing.Size(237, 147);
            this.ExtFinish.TabIndex = 3;
            this.ExtFinish.TabStop = false;
            this.ExtFinish.Text = "Exterior Finish";
            // 
            // ExtCustom
            // 
            this.ExtCustom.AutoSize = true;
            this.ExtCustom.Location = new System.Drawing.Point(29, 83);
            this.ExtCustom.Name = "ExtCustom";
            this.ExtCustom.Size = new System.Drawing.Size(123, 17);
            this.ExtCustom.TabIndex = 2;
            this.ExtCustom.TabStop = true;
            this.ExtCustom.Text = "Customized Detailing";
            this.ExtCustom.UseVisualStyleBackColor = true;
            // 
            // ExtPearlized
            // 
            this.ExtPearlized.AutoSize = true;
            this.ExtPearlized.Location = new System.Drawing.Point(28, 60);
            this.ExtPearlized.Name = "ExtPearlized";
            this.ExtPearlized.Size = new System.Drawing.Size(68, 17);
            this.ExtPearlized.TabIndex = 1;
            this.ExtPearlized.TabStop = true;
            this.ExtPearlized.Text = "Pearlized";
            this.ExtPearlized.UseVisualStyleBackColor = true;
            // 
            // ExtStandard
            // 
            this.ExtStandard.AutoSize = true;
            this.ExtStandard.Checked = true;
            this.ExtStandard.Location = new System.Drawing.Point(28, 37);
            this.ExtStandard.Name = "ExtStandard";
            this.ExtStandard.Size = new System.Drawing.Size(68, 17);
            this.ExtStandard.TabIndex = 0;
            this.ExtStandard.TabStop = true;
            this.ExtStandard.Text = "Standard";
            this.ExtStandard.UseVisualStyleBackColor = true;
            // 
            // Summary
            // 
            this.Summary.Controls.Add(this.label8);
            this.Summary.Controls.Add(this.label7);
            this.Summary.Controls.Add(this.label6);
            this.Summary.Controls.Add(this.label5);
            this.Summary.Controls.Add(this.label4);
            this.Summary.Controls.Add(this.label3);
            this.Summary.Controls.Add(this.label1);
            this.Summary.Controls.Add(this.AmountDue);
            this.Summary.Controls.Add(this.TradeIn);
            this.Summary.Controls.Add(this.Total);
            this.Summary.Controls.Add(this.SalesTax);
            this.Summary.Controls.Add(this.Subtotal);
            this.Summary.Controls.Add(this.Options);
            this.Summary.Controls.Add(this.VehicleSalePriceRead);
            this.Summary.Location = new System.Drawing.Point(325, 26);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(263, 262);
            this.Summary.TabIndex = 6;
            this.Summary.TabStop = false;
            this.Summary.Text = "Summary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Amount Due:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Trade-in:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Sales Tax (13%):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Subtotal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Options:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Vehicle\'s Sale Price:";
            // 
            // AmountDue
            // 
            this.AmountDue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AmountDue.Location = new System.Drawing.Point(164, 194);
            this.AmountDue.Name = "AmountDue";
            this.AmountDue.ReadOnly = true;
            this.AmountDue.Size = new System.Drawing.Size(68, 20);
            this.AmountDue.TabIndex = 19;
            this.AmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TradeIn
            // 
            this.TradeIn.Location = new System.Drawing.Point(164, 168);
            this.TradeIn.Name = "TradeIn";
            this.TradeIn.ReadOnly = true;
            this.TradeIn.Size = new System.Drawing.Size(68, 20);
            this.TradeIn.TabIndex = 18;
            this.TradeIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(164, 143);
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(68, 20);
            this.Total.TabIndex = 17;
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SalesTax
            // 
            this.SalesTax.Location = new System.Drawing.Point(164, 117);
            this.SalesTax.Name = "SalesTax";
            this.SalesTax.ReadOnly = true;
            this.SalesTax.Size = new System.Drawing.Size(68, 20);
            this.SalesTax.TabIndex = 16;
            this.SalesTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Subtotal
            // 
            this.Subtotal.Location = new System.Drawing.Point(164, 91);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Size = new System.Drawing.Size(68, 20);
            this.Subtotal.TabIndex = 15;
            this.Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Options
            // 
            this.Options.Location = new System.Drawing.Point(164, 65);
            this.Options.Name = "Options";
            this.Options.ReadOnly = true;
            this.Options.Size = new System.Drawing.Size(68, 20);
            this.Options.TabIndex = 14;
            this.Options.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // VehicleSalePriceRead
            // 
            this.VehicleSalePriceRead.Location = new System.Drawing.Point(164, 39);
            this.VehicleSalePriceRead.Name = "VehicleSalePriceRead";
            this.VehicleSalePriceRead.ReadOnly = true;
            this.VehicleSalePriceRead.Size = new System.Drawing.Size(68, 20);
            this.VehicleSalePriceRead.TabIndex = 13;
            this.VehicleSalePriceRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Finance
            // 
            this.Finance.Controls.Add(this.label9);
            this.Finance.Controls.Add(this.MonthlyPayment);
            this.Finance.Controls.Add(this.AnnualIntrest);
            this.Finance.Controls.Add(this.years);
            this.Finance.Controls.Add(this.annualInterest);
            this.Finance.Controls.Add(this.numberYears);
            this.Finance.Location = new System.Drawing.Point(325, 310);
            this.Finance.Name = "Finance";
            this.Finance.Size = new System.Drawing.Size(263, 100);
            this.Finance.TabIndex = 4;
            this.Finance.TabStop = false;
            this.Finance.Text = "Finance";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(166, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Monthly Payment";
            // 
            // MonthlyPayment
            // 
            this.MonthlyPayment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MonthlyPayment.Location = new System.Drawing.Point(164, 62);
            this.MonthlyPayment.Name = "MonthlyPayment";
            this.MonthlyPayment.ReadOnly = true;
            this.MonthlyPayment.Size = new System.Drawing.Size(88, 20);
            this.MonthlyPayment.TabIndex = 11;
            this.MonthlyPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AnnualIntrest
            // 
            this.AnnualIntrest.Location = new System.Drawing.Point(75, 25);
            this.AnnualIntrest.Name = "AnnualIntrest";
            this.AnnualIntrest.Size = new System.Drawing.Size(69, 34);
            this.AnnualIntrest.TabIndex = 11;
            this.AnnualIntrest.Text = "Annual Interest Rate";
            // 
            // years
            // 
            this.years.AutoSize = true;
            this.years.Location = new System.Drawing.Point(3, 27);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(66, 13);
            this.years.TabIndex = 2;
            this.years.Text = "No. of Years";
            // 
            // annualInterest
            // 
            this.annualInterest.DecimalPlaces = 2;
            this.annualInterest.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.annualInterest.Location = new System.Drawing.Point(78, 62);
            this.annualInterest.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.annualInterest.Name = "annualInterest";
            this.annualInterest.Size = new System.Drawing.Size(80, 20);
            this.annualInterest.TabIndex = 1;
            this.annualInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.annualInterest.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numberYears
            // 
            this.numberYears.Location = new System.Drawing.Point(6, 62);
            this.numberYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberYears.Name = "numberYears";
            this.numberYears.Size = new System.Drawing.Size(66, 20);
            this.numberYears.TabIndex = 0;
            this.numberYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numberYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(48, 432);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 6;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(513, 432);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 5;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmSalesQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 467);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Finance);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.ExtFinish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TradeInValue);
            this.Controls.Add(this.VehPrice);
            this.Controls.Add(this.VehicleSalePrice);
            this.Controls.Add(this.GRPA);
            this.Name = "frmSalesQuote";
            this.Text = "SalesQuote";
            this.GRPA.ResumeLayout(false);
            this.GRPA.PerformLayout();
            this.ExtFinish.ResumeLayout(false);
            this.ExtFinish.PerformLayout();
            this.Summary.ResumeLayout(false);
            this.Summary.PerformLayout();
            this.Finance.ResumeLayout(false);
            this.Finance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.annualInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GRPA;
        private System.Windows.Forms.CheckBox chkComputer;
        private System.Windows.Forms.CheckBox chkLeather;
        private System.Windows.Forms.CheckBox chkStereo;
        private System.Windows.Forms.TextBox VehicleSalePrice;
        private System.Windows.Forms.Label VehPrice;
        private System.Windows.Forms.TextBox TradeInValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox ExtFinish;
        private System.Windows.Forms.RadioButton ExtCustom;
        private System.Windows.Forms.RadioButton ExtPearlized;
        private System.Windows.Forms.RadioButton ExtStandard;
        private System.Windows.Forms.GroupBox Summary;
        private System.Windows.Forms.GroupBox Finance;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label AnnualIntrest;
        private System.Windows.Forms.Label years;
        private System.Windows.Forms.NumericUpDown annualInterest;
        private System.Windows.Forms.NumericUpDown numberYears;
        private System.Windows.Forms.TextBox MonthlyPayment;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.TextBox SalesTax;
        private System.Windows.Forms.TextBox Subtotal;
        private System.Windows.Forms.TextBox Options;
        private System.Windows.Forms.TextBox VehicleSalePriceRead;
        private System.Windows.Forms.TextBox AmountDue;
        private System.Windows.Forms.TextBox TradeIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}