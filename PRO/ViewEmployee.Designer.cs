namespace PRO
{
    partial class ViewEmployee
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
            this.btnClose1 = new System.Windows.Forms.Button();
            this.dataEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose1
            // 
            this.btnClose1.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose1.Location = new System.Drawing.Point(967, 486);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(134, 43);
            this.btnClose1.TabIndex = 3;
            this.btnClose1.Text = "CLOSE";
            this.btnClose1.UseVisualStyleBackColor = false;
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // dataEmployee
            // 
            this.dataEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmployee.Location = new System.Drawing.Point(31, 46);
            this.dataEmployee.Name = "dataEmployee";
            this.dataEmployee.RowHeadersWidth = 51;
            this.dataEmployee.RowTemplate.Height = 24;
            this.dataEmployee.Size = new System.Drawing.Size(1070, 423);
            this.dataEmployee.TabIndex = 2;
            // 
            // ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1161, 579);
            this.Controls.Add(this.btnClose1);
            this.Controls.Add(this.dataEmployee);
            this.Name = "ViewEmployee";
            this.Text = "ViewEmployee";
            this.Load += new System.EventHandler(this.ViewEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose1;
        private System.Windows.Forms.DataGridView dataEmployee;
    }
}