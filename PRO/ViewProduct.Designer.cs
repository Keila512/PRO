namespace PRO
{
    partial class ViewProduct
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
            this.btnClose3 = new System.Windows.Forms.Button();
            this.dataProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose3
            // 
            this.btnClose3.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose3.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose3.Location = new System.Drawing.Point(963, 484);
            this.btnClose3.Name = "btnClose3";
            this.btnClose3.Size = new System.Drawing.Size(134, 43);
            this.btnClose3.TabIndex = 5;
            this.btnClose3.Text = "CLOSE";
            this.btnClose3.UseVisualStyleBackColor = false;
            this.btnClose3.Click += new System.EventHandler(this.btnClose3_Click);
            // 
            // dataProduct
            // 
            this.dataProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProduct.Location = new System.Drawing.Point(27, 44);
            this.dataProduct.Name = "dataProduct";
            this.dataProduct.RowHeadersWidth = 51;
            this.dataProduct.RowTemplate.Height = 24;
            this.dataProduct.Size = new System.Drawing.Size(1070, 423);
            this.dataProduct.TabIndex = 4;
            // 
            // ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1173, 601);
            this.Controls.Add(this.btnClose3);
            this.Controls.Add(this.dataProduct);
            this.Name = "ViewProduct";
            this.Text = "ViewProduct";
            this.Load += new System.EventHandler(this.ViewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose3;
        private System.Windows.Forms.DataGridView dataProduct;
    }
}