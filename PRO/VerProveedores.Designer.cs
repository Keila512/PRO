namespace PRO
{
    partial class VerProveedores
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
            this.dataSupplier = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSupplier
            // 
            this.dataSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSupplier.Location = new System.Drawing.Point(12, 12);
            this.dataSupplier.Name = "dataSupplier";
            this.dataSupplier.RowHeadersWidth = 51;
            this.dataSupplier.RowTemplate.Height = 24;
            this.dataSupplier.Size = new System.Drawing.Size(1070, 423);
            this.dataSupplier.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(948, 452);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 43);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // VerProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1107, 507);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataSupplier);
            this.Name = "VerProveedores";
            this.Text = "VerProveedores";
            this.Load += new System.EventHandler(this.VerProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSupplier;
        private System.Windows.Forms.Button btnClose;
    }
}