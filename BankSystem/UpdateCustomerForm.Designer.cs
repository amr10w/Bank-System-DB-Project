namespace BankSystem
{
    partial class UpdateCustomerForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NewSSN = new System.Windows.Forms.TextBox();
            this.txt_NewAddress = new System.Windows.Forms.TextBox();
            this.txt_NewDOB = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer SSN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Address:\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Date of Birth (YYYY-MM-DD):\n\n";
            // 
            // txt_NewSSN
            // 
            this.txt_NewSSN.Location = new System.Drawing.Point(424, 59);
            this.txt_NewSSN.Name = "txt_NewSSN";
            this.txt_NewSSN.Size = new System.Drawing.Size(100, 22);
            this.txt_NewSSN.TabIndex = 3;
            // 
            // txt_NewAddress
            // 
            this.txt_NewAddress.Location = new System.Drawing.Point(424, 126);
            this.txt_NewAddress.Name = "txt_NewAddress";
            this.txt_NewAddress.Size = new System.Drawing.Size(100, 22);
            this.txt_NewAddress.TabIndex = 4;
            // 
            // txt_NewDOB
            // 
            this.txt_NewDOB.Location = new System.Drawing.Point(424, 197);
            this.txt_NewDOB.Name = "txt_NewDOB";
            this.txt_NewDOB.Size = new System.Drawing.Size(100, 22);
            this.txt_NewDOB.TabIndex = 5;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(475, 347);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(591, 347);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(106, 23);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "Back to Menu";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // UpdateCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.txt_NewDOB);
            this.Controls.Add(this.txt_NewAddress);
            this.Controls.Add(this.txt_NewSSN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateCustomerForm";
            this.Text = "Update Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NewSSN;
        private System.Windows.Forms.TextBox txt_NewAddress;
        private System.Windows.Forms.TextBox txt_NewDOB;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Back;
    }
}