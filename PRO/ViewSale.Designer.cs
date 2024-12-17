namespace PRO
{
    partial class ViewSale
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
            this.btnClose8 = new System.Windows.Forms.Button();
            this.dataSale = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSale)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose8
            // 
            this.btnClose8.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose8.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose8.Location = new System.Drawing.Point(958, 477);
            this.btnClose8.Name = "btnClose8";
            this.btnClose8.Size = new System.Drawing.Size(134, 43);
            this.btnClose8.TabIndex = 7;
            this.btnClose8.Text = "CLOSE";
            this.btnClose8.UseVisualStyleBackColor = false;
            this.btnClose8.Click += new System.EventHandler(this.btnClose8_Click);
            // 
            // dataSale
            // 
            this.dataSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSale.Location = new System.Drawing.Point(22, 37);
            this.dataSale.Name = "dataSale";
            this.dataSale.RowHeadersWidth = 51;
            this.dataSale.RowTemplate.Height = 24;
            this.dataSale.Size = new System.Drawing.Size(1070, 423);
            this.dataSale.TabIndex = 6;
            // 
            // ViewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1156, 585);
            this.Controls.Add(this.btnClose8);
            this.Controls.Add(this.dataSale);
            this.Name = "ViewSale";
            this.Text = "ViewSale";
            this.Load += new System.EventHandler(this.ViewSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose8;
        private System.Windows.Forms.DataGridView dataSale;
    }
}