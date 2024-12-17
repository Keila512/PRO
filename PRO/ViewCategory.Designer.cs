namespace PRO
{
    partial class ViewCategory
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
            this.btnClose5 = new System.Windows.Forms.Button();
            this.dataCategory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose5
            // 
            this.btnClose5.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose5.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose5.Location = new System.Drawing.Point(958, 484);
            this.btnClose5.Name = "btnClose5";
            this.btnClose5.Size = new System.Drawing.Size(134, 43);
            this.btnClose5.TabIndex = 5;
            this.btnClose5.Text = "CLOSE";
            this.btnClose5.UseVisualStyleBackColor = false;
            this.btnClose5.Click += new System.EventHandler(this.btnClose5_Click);
            // 
            // dataCategory
            // 
            this.dataCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCategory.Location = new System.Drawing.Point(22, 44);
            this.dataCategory.Name = "dataCategory";
            this.dataCategory.RowHeadersWidth = 51;
            this.dataCategory.RowTemplate.Height = 24;
            this.dataCategory.Size = new System.Drawing.Size(1070, 423);
            this.dataCategory.TabIndex = 4;
            // 
            // ViewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1145, 578);
            this.Controls.Add(this.btnClose5);
            this.Controls.Add(this.dataCategory);
            this.Name = "ViewCategory";
            this.Text = "ViewCategory";
            this.Load += new System.EventHandler(this.ViewCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose5;
        private System.Windows.Forms.DataGridView dataCategory;
    }
}