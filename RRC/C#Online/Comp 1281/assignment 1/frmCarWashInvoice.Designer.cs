namespace assignment_1
{
    partial class frmCarWashInvoice
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
            this.label37 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.TaxesLabel = new System.Windows.Forms.Label();
            this.SubtotalLabel = new System.Windows.Forms.Label();
            this.FragrancePriceLabel = new System.Windows.Forms.Label();
            this.PackagePriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(632, 310);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(80, 13);
            this.label37.TabIndex = 7;
            this.label37.Text = "Package Price:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(627, 341);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(85, 13);
            this.label26.TabIndex = 8;
            this.label26.Text = "Fragrance Price:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(663, 367);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(49, 13);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Subtotal:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(673, 391);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(39, 13);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "Taxes:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(673, 416);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(34, 13);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "Total:";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(714, 416);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(37, 13);
            this.TotalPriceLabel.TabIndex = 12;
            this.TotalPriceLabel.Text = "[Total]";
            // 
            // TaxesLabel
            // 
            this.TaxesLabel.AutoSize = true;
            this.TaxesLabel.Location = new System.Drawing.Point(714, 391);
            this.TaxesLabel.Name = "TaxesLabel";
            this.TaxesLabel.Size = new System.Drawing.Size(42, 13);
            this.TaxesLabel.TabIndex = 13;
            this.TaxesLabel.Text = "[Taxes]";
            // 
            // SubtotalLabel
            // 
            this.SubtotalLabel.AutoSize = true;
            this.SubtotalLabel.Location = new System.Drawing.Point(714, 367);
            this.SubtotalLabel.Name = "SubtotalLabel";
            this.SubtotalLabel.Size = new System.Drawing.Size(52, 13);
            this.SubtotalLabel.TabIndex = 14;
            this.SubtotalLabel.Text = "[Subtotal]";
            // 
            // FragrancePriceLabel
            // 
            this.FragrancePriceLabel.AutoSize = true;
            this.FragrancePriceLabel.Location = new System.Drawing.Point(714, 341);
            this.FragrancePriceLabel.Name = "FragrancePriceLabel";
            this.FragrancePriceLabel.Size = new System.Drawing.Size(85, 13);
            this.FragrancePriceLabel.TabIndex = 15;
            this.FragrancePriceLabel.Text = "[FragrancePrice]";
            // 
            // PackagePriceLabel
            // 
            this.PackagePriceLabel.AutoSize = true;
            this.PackagePriceLabel.Location = new System.Drawing.Point(714, 310);
            this.PackagePriceLabel.Name = "PackagePriceLabel";
            this.PackagePriceLabel.Size = new System.Drawing.Size(80, 13);
            this.PackagePriceLabel.TabIndex = 16;
            this.PackagePriceLabel.Text = "[PackagePrice]";
            // 
            // frmCarWashInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PackagePriceLabel);
            this.Controls.Add(this.FragrancePriceLabel);
            this.Controls.Add(this.SubtotalLabel);
            this.Controls.Add(this.TaxesLabel);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label37);
            this.Name = "frmCarWashInvoice";
            this.Controls.SetChildIndex(this.CompanyNameLabel, 0);
            this.Controls.SetChildIndex(this.AddressLabel, 0);
            this.Controls.SetChildIndex(this.CityProvicePostalLabel, 0);
            this.Controls.SetChildIndex(this.PhoneLabel, 0);
            this.Controls.SetChildIndex(this.InvoiceTitleLabel, 0);
            this.Controls.SetChildIndex(this.DateLabel, 0);
            this.Controls.SetChildIndex(this.label37, 0);
            this.Controls.SetChildIndex(this.label26, 0);
            this.Controls.SetChildIndex(this.Label3, 0);
            this.Controls.SetChildIndex(this.Label4, 0);
            this.Controls.SetChildIndex(this.Label5, 0);
            this.Controls.SetChildIndex(this.TotalPriceLabel, 0);
            this.Controls.SetChildIndex(this.TaxesLabel, 0);
            this.Controls.SetChildIndex(this.SubtotalLabel, 0);
            this.Controls.SetChildIndex(this.FragrancePriceLabel, 0);
            this.Controls.SetChildIndex(this.PackagePriceLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label TaxesLabel;
        private System.Windows.Forms.Label SubtotalLabel;
        private System.Windows.Forms.Label FragrancePriceLabel;
        private System.Windows.Forms.Label PackagePriceLabel;
    }
}
