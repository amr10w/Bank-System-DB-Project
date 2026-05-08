namespace BankSystem
{
    partial class DeleteCustomerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.t_SSN = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Customer SSN to Delete:";
            // 
            // t_SSN
            // 
            this.t_SSN.Location = new System.Drawing.Point(340, 109);
            this.t_SSN.Name = "t_SSN";
            this.t_SSN.Size = new System.Drawing.Size(100, 22);
            this.t_SSN.TabIndex = 1;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(509, 349);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(115, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete Customer";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(648, 349);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(105, 23);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Back to Menu";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // DeleteCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.t_SSN);
            this.Controls.Add(this.label1);
            this.Name = "DeleteCustomerForm";
            this.Text = "Delete Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_SSN;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Back;
    }
}