namespace PRO
{
    partial class CreateEmployee
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
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.txtStand = new System.Windows.Forms.TextBox();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 32);
            this.label6.TabIndex = 29;
            this.label6.Text = "Insert the following data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Pay:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Stand:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name:";
            // 
            // btnAdd1
            // 
            this.btnAdd1.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd1.Location = new System.Drawing.Point(264, 358);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(112, 35);
            this.btnAdd1.TabIndex = 23;
            this.btnAdd1.Text = "ADD";
            this.btnAdd1.UseVisualStyleBackColor = false;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // txtStand
            // 
            this.txtStand.Location = new System.Drawing.Point(186, 221);
            this.txtStand.Name = "txtStand";
            this.txtStand.Size = new System.Drawing.Size(310, 22);
            this.txtStand.TabIndex = 22;
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(186, 285);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(310, 22);
            this.txtPay.TabIndex = 21;
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(186, 162);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(382, 22);
            this.txtName1.TabIndex = 18;
            // 
            // CreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 544);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.txtStand);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.txtName1);
            this.Name = "CreateEmployee";
            this.Text = "CreateEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.TextBox txtStand;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.TextBox txtName1;
    }
}