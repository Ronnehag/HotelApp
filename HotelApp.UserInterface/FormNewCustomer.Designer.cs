namespace HotelApp.UserInterface
{
    partial class FormNewCustomer
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_SaveCustomer = new System.Windows.Forms.Button();
            this.lbl_City = new System.Windows.Forms.Label();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.lbl_PostalCode = new System.Windows.Forms.Label();
            this.txt_PostalCode = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_SurName = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(196, 360);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(125, 58);
            this.btn_Cancel.TabIndex = 60;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_SaveCustomer
            // 
            this.btn_SaveCustomer.Location = new System.Drawing.Point(65, 360);
            this.btn_SaveCustomer.Name = "btn_SaveCustomer";
            this.btn_SaveCustomer.Size = new System.Drawing.Size(125, 58);
            this.btn_SaveCustomer.TabIndex = 59;
            this.btn_SaveCustomer.Text = "Save";
            this.btn_SaveCustomer.UseVisualStyleBackColor = true;
            this.btn_SaveCustomer.Click += new System.EventHandler(this.btn_SaveCustomer_Click);
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Location = new System.Drawing.Point(61, 205);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(39, 20);
            this.lbl_City.TabIndex = 58;
            this.lbl_City.Text = "City:";
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(106, 202);
            this.txt_City.Multiline = true;
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(206, 26);
            this.txt_City.TabIndex = 52;
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Location = new System.Drawing.Point(32, 255);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(68, 20);
            this.lbl_Country.TabIndex = 57;
            this.lbl_Country.Text = "Country:";
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(106, 252);
            this.txt_Country.Multiline = true;
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(206, 26);
            this.txt_Country.TabIndex = 54;
            // 
            // lbl_PostalCode
            // 
            this.lbl_PostalCode.AutoSize = true;
            this.lbl_PostalCode.Location = new System.Drawing.Point(4, 161);
            this.lbl_PostalCode.Name = "lbl_PostalCode";
            this.lbl_PostalCode.Size = new System.Drawing.Size(96, 20);
            this.lbl_PostalCode.TabIndex = 56;
            this.lbl_PostalCode.Text = "Postal code:";
            // 
            // txt_PostalCode
            // 
            this.txt_PostalCode.Location = new System.Drawing.Point(106, 158);
            this.txt_PostalCode.Multiline = true;
            this.txt_PostalCode.Name = "txt_PostalCode";
            this.txt_PostalCode.Size = new System.Drawing.Size(206, 26);
            this.txt_PostalCode.TabIndex = 50;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(28, 113);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(72, 20);
            this.lbl_Address.TabIndex = 55;
            this.lbl_Address.Text = "Address:";
            // 
            // lbl_SurName
            // 
            this.lbl_SurName.AutoSize = true;
            this.lbl_SurName.Location = new System.Drawing.Point(22, 61);
            this.lbl_SurName.Name = "lbl_SurName";
            this.lbl_SurName.Size = new System.Drawing.Size(78, 20);
            this.lbl_SurName.TabIndex = 53;
            this.lbl_SurName.Text = "Surname:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(12, 15);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(88, 20);
            this.lbl_Name.TabIndex = 51;
            this.lbl_Name.Text = "First name:";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(106, 110);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(206, 26);
            this.txt_Address.TabIndex = 49;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(106, 58);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(206, 26);
            this.txt_LastName.TabIndex = 48;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(106, 12);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(206, 26);
            this.txt_FirstName.TabIndex = 47;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(48, 299);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(52, 20);
            this.lbl_Email.TabIndex = 62;
            this.lbl_Email.Text = "Email:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(106, 296);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(206, 26);
            this.txt_Email.TabIndex = 61;
            // 
            // FormNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 430);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_SaveCustomer);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.lbl_PostalCode);
            this.Controls.Add(this.txt_PostalCode);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_SurName);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_FirstName);
            this.Name = "FormNewCustomer";
            this.Text = "FormNewCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_SaveCustomer;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.TextBox txt_Country;
        private System.Windows.Forms.Label lbl_PostalCode;
        private System.Windows.Forms.TextBox txt_PostalCode;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_SurName;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Email;
    }
}