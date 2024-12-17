namespace PRO
{
    partial class ViewPayments
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
            this.btnClose6 = new System.Windows.Forms.Button();
            this.dataPayment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose6
            // 
            this.btnClose6.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose6.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose6.Location = new System.Drawing.Point(969, 472);
            this.btnClose6.Name = "btnClose6";
            this.btnClose6.Size = new System.Drawing.Size(134, 43);
            this.btnClose6.TabIndex = 7;
            this.btnClose6.Text = "CLOSE";
            this.btnClose6.UseVisualStyleBackColor = false;
            this.btnClose6.Click += new System.EventHandler(this.btnClose6_Click);
            // 
            // dataPayment
            // 
            this.dataPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPayment.Location = new System.Drawing.Point(33, 32);
            this.dataPayment.Name = "dataPayment";
            this.dataPayment.RowHeadersWidth = 51;
            this.dataPayment.RowTemplate.Height = 24;
            this.dataPayment.Size = new System.Drawing.Size(1070, 423);
            this.dataPayment.TabIndex = 6;
            // 
            // ViewPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1165, 592);
            this.Controls.Add(this.btnClose6);
            this.Controls.Add(this.dataPayment);
            this.Name = "ViewPayments";
            this.Text = "ViewPayments";
            this.Load += new System.EventHandler(this.ViewPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose6;
        private System.Windows.Forms.DataGridView dataPayment;
    }
}