namespace PRO
{
    partial class CreateCategory
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd5 = new System.Windows.Forms.Button();
            this.txtDescription5 = new System.Windows.Forms.TextBox();
            this.txtName5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(124, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 32);
            this.label6.TabIndex = 37;
            this.label6.Text = "Insert the following data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Name:";
            // 
            // btnAdd5
            // 
            this.btnAdd5.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd5.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd5.Location = new System.Drawing.Point(326, 377);
            this.btnAdd5.Name = "btnAdd5";
            this.btnAdd5.Size = new System.Drawing.Size(112, 35);
            this.btnAdd5.TabIndex = 33;
            this.btnAdd5.Text = "ADD";
            this.btnAdd5.UseVisualStyleBackColor = false;
            this.btnAdd5.Click += new System.EventHandler(this.btnAdd5_Click);
            // 
            // txtDescription5
            // 
            this.txtDescription5.Location = new System.Drawing.Point(212, 255);
            this.txtDescription5.Name = "txtDescription5";
            this.txtDescription5.Size = new System.Drawing.Size(310, 22);
            this.txtDescription5.TabIndex = 32;
            // 
            // txtName5
            // 
            this.txtName5.Location = new System.Drawing.Point(212, 196);
            this.txtName5.Name = "txtName5";
            this.txtName5.Size = new System.Drawing.Size(382, 22);
            this.txtName5.TabIndex = 30;
            // 
            // CreateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 580);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd5);
            this.Controls.Add(this.txtDescription5);
            this.Controls.Add(this.txtName5);
            this.Name = "CreateCategory";
            this.Text = "CreateCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd5;
        private System.Windows.Forms.TextBox txtDescription5;
        private System.Windows.Forms.TextBox txtName5;
    }
}