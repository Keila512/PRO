namespace PRO
{
    partial class CreatePayments
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
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd6 = new System.Windows.Forms.Button();
            this.txtPA6 = new System.Windows.Forms.TextBox();
            this.txtPD6 = new System.Windows.Forms.TextBox();
            this.txtIDSupplier6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 32);
            this.label6.TabIndex = 29;
            this.label6.Text = "Insert the following data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Payment Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Payment Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID Supplier:";
            // 
            // btnAdd6
            // 
            this.btnAdd6.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd6.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd6.Location = new System.Drawing.Point(292, 349);
            this.btnAdd6.Name = "btnAdd6";
            this.btnAdd6.Size = new System.Drawing.Size(112, 35);
            this.btnAdd6.TabIndex = 23;
            this.btnAdd6.Text = "ADD";
            this.btnAdd6.UseVisualStyleBackColor = false;
            this.btnAdd6.Click += new System.EventHandler(this.btnAdd6_Click);
            // 
            // txtPA6
            // 
            this.txtPA6.Location = new System.Drawing.Point(193, 216);
            this.txtPA6.Name = "txtPA6";
            this.txtPA6.Size = new System.Drawing.Size(310, 22);
            this.txtPA6.TabIndex = 22;
            // 
            // txtPD6
            // 
            this.txtPD6.Location = new System.Drawing.Point(193, 280);
            this.txtPD6.Name = "txtPD6";
            this.txtPD6.Size = new System.Drawing.Size(310, 22);
            this.txtPD6.TabIndex = 21;
            // 
            // txtIDSupplier6
            // 
            this.txtIDSupplier6.Location = new System.Drawing.Point(193, 157);
            this.txtIDSupplier6.Name = "txtIDSupplier6";
            this.txtIDSupplier6.Size = new System.Drawing.Size(382, 22);
            this.txtIDSupplier6.TabIndex = 18;
            // 
            // CreatePayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 504);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd6);
            this.Controls.Add(this.txtPA6);
            this.Controls.Add(this.txtPD6);
            this.Controls.Add(this.txtIDSupplier6);
            this.Name = "CreatePayments";
            this.Text = "CreatePayments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd6;
        private System.Windows.Forms.TextBox txtPA6;
        private System.Windows.Forms.TextBox txtPD6;
        private System.Windows.Forms.TextBox txtIDSupplier6;
    }
}