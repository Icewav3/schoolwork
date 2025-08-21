namespace assignment_1.Properties
{
    partial class InvoiceForm
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
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CityProvicePostalLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.InvoiceTitleLabel = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNameLabel.Location = new System.Drawing.Point(27, 13);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(281, 39);
            this.CompanyNameLabel.TabIndex = 0;
            this.CompanyNameLabel.Text = "[Company Name]";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(31, 61);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(76, 20);
            this.AddressLabel.TabIndex = 1;
            this.AddressLabel.Text = "[Address]";
            // 
            // CityProvicePostalLabel
            // 
            this.CityProvicePostalLabel.AutoSize = true;
            this.CityProvicePostalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityProvicePostalLabel.Location = new System.Drawing.Point(31, 89);
            this.CityProvicePostalLabel.Name = "CityProvicePostalLabel";
            this.CityProvicePostalLabel.Size = new System.Drawing.Size(154, 20);
            this.CityProvicePostalLabel.TabIndex = 2;
            this.CityProvicePostalLabel.Text = "[City. Provice. Postal]";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.Location = new System.Drawing.Point(32, 124);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(63, 20);
            this.PhoneLabel.TabIndex = 3;
            this.PhoneLabel.Text = "[Phone]";
            // 
            // InvoiceTitleLabel
            // 
            this.InvoiceTitleLabel.AutoSize = true;
            this.InvoiceTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceTitleLabel.Location = new System.Drawing.Point(33, 156);
            this.InvoiceTitleLabel.Name = "InvoiceTitleLabel";
            this.InvoiceTitleLabel.Size = new System.Drawing.Size(100, 20);
            this.InvoiceTitleLabel.TabIndex = 4;
            this.InvoiceTitleLabel.Text = "[Invoice Title]";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label23.Location = new System.Drawing.Point(628, 28);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(48, 20);
            this.Label23.TabIndex = 5;
            this.Label23.Text = "Date:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(682, 28);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(52, 20);
            this.DateLabel.TabIndex = 6;
            this.DateLabel.Text = "[Date]";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.Label23);
            this.Controls.Add(this.InvoiceTitleLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.CityProvicePostalLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.CompanyNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InvoiceForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "[Form Title]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label23;
        protected System.Windows.Forms.Label CompanyNameLabel;
        protected System.Windows.Forms.Label AddressLabel;
        protected System.Windows.Forms.Label CityProvicePostalLabel;
        protected System.Windows.Forms.Label PhoneLabel;
        protected System.Windows.Forms.Label InvoiceTitleLabel;
        protected System.Windows.Forms.Label DateLabel;
    }
}