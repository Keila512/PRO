namespace PRO
{
    partial class ViewOrders
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
            this.btnClose4 = new System.Windows.Forms.Button();
            this.dataOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose4
            // 
            this.btnClose4.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose4.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose4.Location = new System.Drawing.Point(963, 474);
            this.btnClose4.Name = "btnClose4";
            this.btnClose4.Size = new System.Drawing.Size(134, 43);
            this.btnClose4.TabIndex = 5;
            this.btnClose4.Text = "CLOSE";
            this.btnClose4.UseVisualStyleBackColor = false;
            this.btnClose4.Click += new System.EventHandler(this.btnClose4_Click);
            // 
            // dataOrder
            // 
            this.dataOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrder.Location = new System.Drawing.Point(27, 34);
            this.dataOrder.Name = "dataOrder";
            this.dataOrder.RowHeadersWidth = 51;
            this.dataOrder.RowTemplate.Height = 24;
            this.dataOrder.Size = new System.Drawing.Size(1070, 423);
            this.dataOrder.TabIndex = 4;
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1135, 575);
            this.Controls.Add(this.btnClose4);
            this.Controls.Add(this.dataOrder);
            this.Name = "ViewOrders";
            this.Text = "ViewOrders";
            this.Load += new System.EventHandler(this.ViewOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose4;
        private System.Windows.Forms.DataGridView dataOrder;
    }
}