namespace BankSystem
{
    partial class AddCustomerForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SSN = new System.Windows.Forms.TextBox();
            this.txt_Fname = new System.Windows.Forms.TextBox();
            this.txt_Lname = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_DOB = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SSN (14 chars):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Birth (YYYY-MM-DD):\n\n";
            // 
            // txt_SSN
            // 
            this.txt_SSN.Location = new System.Drawing.Point(274, 45);
            this.txt_SSN.Name = "txt_SSN";
            this.txt_SSN.Size = new System.Drawing.Size(100, 22);
            this.txt_SSN.TabIndex = 5;
            // 
            // txt_Fname
            // 
            this.txt_Fname.Location = new System.Drawing.Point(274, 112);
            this.txt_Fname.Name = "txt_Fname";
            this.txt_Fname.Size = new System.Drawing.Size(100, 22);
            this.txt_Fname.TabIndex = 6;
            // 
            // txt_Lname
            // 
            this.txt_Lname.Location = new System.Drawing.Point(274, 175);
            this.txt_Lname.Name = "txt_Lname";
            this.txt_Lname.Size = new System.Drawing.Size(100, 22);
            this.txt_Lname.TabIndex = 7;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(274, 258);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(100, 22);
            this.txt_Address.TabIndex = 8;
            // 
            // txt_DOB
            // 
            this.txt_DOB.Location = new System.Drawing.Point(274, 334);
            this.txt_DOB.Name = "txt_DOB";
            this.txt_DOB.Size = new System.Drawing.Size(100, 22);
            this.txt_DOB.TabIndex = 9;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(529, 360);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Add Customer";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(630, 360);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(108, 23);
            this.btn_Back.TabIndex = 11;
            this.btn_Back.Text = "Back to Menu";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_DOB);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_Lname);
            this.Controls.Add(this.txt_Fname);
            this.Controls.Add(this.txt_SSN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCustomerForm";
            this.Text = "Add New Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SSN;
        private System.Windows.Forms.TextBox txt_Fname;
        private System.Windows.Forms.TextBox txt_Lname;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_DOB;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Back;
    }
}