namespace PRO
{
    partial class ViewBranch
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
            this.btnClose9 = new System.Windows.Forms.Button();
            this.dataBranch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataBranch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose9
            // 
            this.btnClose9.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose9.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose9.Location = new System.Drawing.Point(948, 473);
            this.btnClose9.Name = "btnClose9";
            this.btnClose9.Size = new System.Drawing.Size(134, 43);
            this.btnClose9.TabIndex = 5;
            this.btnClose9.Text = "CLOSE";
            this.btnClose9.UseVisualStyleBackColor = false;
            this.btnClose9.Click += new System.EventHandler(this.btnClose9_Click);
            // 
            // dataBranch
            // 
            this.dataBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBranch.Location = new System.Drawing.Point(12, 33);
            this.dataBranch.Name = "dataBranch";
            this.dataBranch.RowHeadersWidth = 51;
            this.dataBranch.RowTemplate.Height = 24;
            this.dataBranch.Size = new System.Drawing.Size(1070, 423);
            this.dataBranch.TabIndex = 4;
            // 
            // ViewBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1126, 577);
            this.Controls.Add(this.btnClose9);
            this.Controls.Add(this.dataBranch);
            this.Name = "ViewBranch";
            this.Text = "ViewBranch";
            this.Load += new System.EventHandler(this.ViewBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBranch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose9;
        private System.Windows.Forms.DataGridView dataBranch;
    }
}