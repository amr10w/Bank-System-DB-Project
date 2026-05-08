namespace BankSystem
{
    partial class ViewCustomersForm
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
            this.dgv_Customers = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Customers
            // 
            this.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customers.Location = new System.Drawing.Point(0, 0);
            this.dgv_Customers.Name = "dgv_Customers";
            this.dgv_Customers.RowHeadersWidth = 51;
            this.dgv_Customers.RowTemplate.Height = 24;
            this.dgv_Customers.Size = new System.Drawing.Size(797, 450);
            this.dgv_Customers.TabIndex = 0;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(569, 387);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(664, 387);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(109, 23);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "Back to Menu";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // ViewCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv_Customers);
            this.Name = "ViewCustomersForm";
            this.Text = "View All Customers";
            this.Load += new System.EventHandler(this.ViewCustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Customers;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Back;
    }
}