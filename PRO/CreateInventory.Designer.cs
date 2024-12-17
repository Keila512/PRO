namespace PRO
{
    partial class CreateInventory
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
            this.txtIDB = new System.Windows.Forms.TextBox();
            this.txtCQ = new System.Windows.Forms.TextBox();
            this.txtIDP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 32);
            this.label6.TabIndex = 29;
            this.label6.Text = "Insert the following data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Current Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID Branch:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID Product:";
            // 
            // btnAdd6
            // 
            this.btnAdd6.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd6.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd6.Location = new System.Drawing.Point(281, 345);
            this.btnAdd6.Name = "btnAdd6";
            this.btnAdd6.Size = new System.Drawing.Size(112, 35);
            this.btnAdd6.TabIndex = 23;
            this.btnAdd6.Text = "ADD";
            this.btnAdd6.UseVisualStyleBackColor = false;
            this.btnAdd6.Click += new System.EventHandler(this.btnAdd6_Click);
            // 
            // txtIDB
            // 
            this.txtIDB.Location = new System.Drawing.Point(231, 221);
            this.txtIDB.Name = "txtIDB";
            this.txtIDB.Size = new System.Drawing.Size(310, 22);
            this.txtIDB.TabIndex = 22;
            // 
            // txtCQ
            // 
            this.txtCQ.Location = new System.Drawing.Point(231, 285);
            this.txtCQ.Name = "txtCQ";
            this.txtCQ.Size = new System.Drawing.Size(310, 22);
            this.txtCQ.TabIndex = 21;
            // 
            // txtIDP
            // 
            this.txtIDP.Location = new System.Drawing.Point(231, 162);
            this.txtIDP.Name = "txtIDP";
            this.txtIDP.Size = new System.Drawing.Size(382, 22);
            this.txtIDP.TabIndex = 18;
            // 
            // CreateInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 570);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd6);
            this.Controls.Add(this.txtIDB);
            this.Controls.Add(this.txtCQ);
            this.Controls.Add(this.txtIDP);
            this.Name = "CreateInventory";
            this.Text = "CreateInventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd6;
        private System.Windows.Forms.TextBox txtIDB;
        private System.Windows.Forms.TextBox txtCQ;
        private System.Windows.Forms.TextBox txtIDP;
    }
}