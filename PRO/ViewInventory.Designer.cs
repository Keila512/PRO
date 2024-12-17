namespace PRO
{
    partial class ViewInventory
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
            this.dataInventory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose6
            // 
            this.btnClose6.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose6.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose6.Location = new System.Drawing.Point(965, 476);
            this.btnClose6.Name = "btnClose6";
            this.btnClose6.Size = new System.Drawing.Size(134, 43);
            this.btnClose6.TabIndex = 7;
            this.btnClose6.Text = "CLOSE";
            this.btnClose6.UseVisualStyleBackColor = false;
            this.btnClose6.Click += new System.EventHandler(this.btnClose6_Click);
            // 
            // dataInventory
            // 
            this.dataInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInventory.Location = new System.Drawing.Point(29, 36);
            this.dataInventory.Name = "dataInventory";
            this.dataInventory.RowHeadersWidth = 51;
            this.dataInventory.RowTemplate.Height = 24;
            this.dataInventory.Size = new System.Drawing.Size(1070, 423);
            this.dataInventory.TabIndex = 6;
            // 
            // ViewInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1150, 583);
            this.Controls.Add(this.btnClose6);
            this.Controls.Add(this.dataInventory);
            this.Name = "ViewInventory";
            this.Text = "ViewInventory";
            this.Load += new System.EventHandler(this.ViewInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose6;
        private System.Windows.Forms.DataGridView dataInventory;
    }
}