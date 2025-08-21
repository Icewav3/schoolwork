namespace assignment_1
{
    partial class frmCarWash
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
            this.GroupSummary = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.ExtBox = new System.Windows.Forms.ListBox();
            this.PackBox = new System.Windows.Forms.ListBox();
            this.PackDrop = new System.Windows.Forms.ComboBox();
            this.FragDrop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.GSTBox = new System.Windows.Forms.TextBox();
            this.PSTBox = new System.Windows.Forms.TextBox();
            this.SubtotalBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupSummary.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupSummary
            // 
            this.GroupSummary.Controls.Add(this.label8);
            this.GroupSummary.Controls.Add(this.Label7);
            this.GroupSummary.Controls.Add(this.ExtBox);
            this.GroupSummary.Controls.Add(this.PackBox);
            this.GroupSummary.Location = new System.Drawing.Point(12, 91);
            this.GroupSummary.Name = "GroupSummary";
            this.GroupSummary.Size = new System.Drawing.Size(409, 208);
            this.GroupSummary.TabIndex = 0;
            this.GroupSummary.TabStop = false;
            this.GroupSummary.Text = "Summary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Exterior";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(22, 27);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(39, 13);
            this.Label7.TabIndex = 28;
            this.Label7.Text = "Interior";
            // 
            // ExtBox
            // 
            this.ExtBox.FormattingEnabled = true;
            this.ExtBox.Location = new System.Drawing.Point(227, 43);
            this.ExtBox.Name = "ExtBox";
            this.ExtBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ExtBox.Size = new System.Drawing.Size(163, 134);
            this.ExtBox.TabIndex = 1;
            // 
            // PackBox
            // 
            this.PackBox.FormattingEnabled = true;
            this.PackBox.Location = new System.Drawing.Point(22, 43);
            this.PackBox.Name = "PackBox";
            this.PackBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.PackBox.Size = new System.Drawing.Size(156, 134);
            this.PackBox.TabIndex = 0;
            // 
            // PackDrop
            // 
            this.PackDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PackDrop.FormattingEnabled = true;
            this.PackDrop.Location = new System.Drawing.Point(34, 42);
            this.PackDrop.Name = "PackDrop";
            this.PackDrop.Size = new System.Drawing.Size(121, 21);
            this.PackDrop.TabIndex = 1;
            // 
            // FragDrop
            // 
            this.FragDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FragDrop.FormattingEnabled = true;
            this.FragDrop.Location = new System.Drawing.Point(239, 42);
            this.FragDrop.Name = "FragDrop";
            this.FragDrop.Size = new System.Drawing.Size(121, 21);
            this.FragDrop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Package";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fragrance";
            // 
            // TotalBox
            // 
            this.TotalBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TotalBox.Location = new System.Drawing.Point(282, 408);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.ReadOnly = true;
            this.TotalBox.Size = new System.Drawing.Size(106, 20);
            this.TotalBox.TabIndex = 20;
            this.TotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GSTBox
            // 
            this.GSTBox.Location = new System.Drawing.Point(282, 382);
            this.GSTBox.Name = "GSTBox";
            this.GSTBox.ReadOnly = true;
            this.GSTBox.Size = new System.Drawing.Size(106, 20);
            this.GSTBox.TabIndex = 21;
            this.GSTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PSTBox
            // 
            this.PSTBox.Location = new System.Drawing.Point(282, 356);
            this.PSTBox.Name = "PSTBox";
            this.PSTBox.ReadOnly = true;
            this.PSTBox.Size = new System.Drawing.Size(106, 20);
            this.PSTBox.TabIndex = 22;
            this.PSTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SubtotalBox
            // 
            this.SubtotalBox.Location = new System.Drawing.Point(282, 330);
            this.SubtotalBox.Name = "SubtotalBox";
            this.SubtotalBox.ReadOnly = true;
            this.SubtotalBox.Size = new System.Drawing.Size(106, 20);
            this.SubtotalBox.TabIndex = 23;
            this.SubtotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Subtotal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "PST:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "GST:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Total:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(25, 356);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateInvoiceToolStripMenuItem});
            this.FileToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.FileToolStripMenuItem.MergeIndex = 0;
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "&File";
            this.FileToolStripMenuItem.Visible = false;
            // 
            // generateInvoiceToolStripMenuItem
            // 
            this.generateInvoiceToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.generateInvoiceToolStripMenuItem.MergeIndex = 1;
            this.generateInvoiceToolStripMenuItem.Name = "generateInvoiceToolStripMenuItem";
            this.generateInvoiceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.generateInvoiceToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.generateInvoiceToolStripMenuItem.Text = "Generate &Invoice";
            // 
            // frmCarWash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubtotalBox);
            this.Controls.Add(this.PSTBox);
            this.Controls.Add(this.GSTBox);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FragDrop);
            this.Controls.Add(this.PackDrop);
            this.Controls.Add(this.GroupSummary);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmCarWash";
            this.Text = "Car Wash";
            this.GroupSummary.ResumeLayout(false);
            this.GroupSummary.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupSummary;
        private System.Windows.Forms.ComboBox PackDrop;
        private System.Windows.Forms.ComboBox FragDrop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.ListBox ExtBox;
        private System.Windows.Forms.ListBox PackBox;
        private System.Windows.Forms.TextBox GSTBox;
        private System.Windows.Forms.TextBox PSTBox;
        private System.Windows.Forms.TextBox SubtotalBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateInvoiceToolStripMenuItem;
    }
}