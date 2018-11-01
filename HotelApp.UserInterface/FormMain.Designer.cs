namespace HotelApp.UserInterface
{
    partial class FormMain
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
            this.btn_ManageBookings = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_City = new System.Windows.Forms.Label();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.btn_DeleteSelectedCustomer = new System.Windows.Forms.Button();
            this.btn_UpdateSelectedCustomer = new System.Windows.Forms.Button();
            this.btn_AddNewCustomer = new System.Windows.Forms.Button();
            this.listBox_RegistredCustomers = new System.Windows.Forms.ListBox();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_SurName = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.btn_Booking = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ManageBookings
            // 
            this.btn_ManageBookings.Location = new System.Drawing.Point(512, 509);
            this.btn_ManageBookings.Name = "btn_ManageBookings";
            this.btn_ManageBookings.Size = new System.Drawing.Size(146, 62);
            this.btn_ManageBookings.TabIndex = 54;
            this.btn_ManageBookings.Text = "Manage bookings";
            this.btn_ManageBookings.UseVisualStyleBackColor = true;
            this.btn_ManageBookings.Click += new System.EventHandler(this.btn_ManageBookings_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.Location = new System.Drawing.Point(12, 302);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(160, 42);
            this.btn_Refresh.TabIndex = 53;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Location = new System.Drawing.Point(408, 225);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(39, 20);
            this.lbl_City.TabIndex = 52;
            this.lbl_City.Text = "City:";
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(452, 222);
            this.txt_City.Multiline = true;
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(206, 26);
            this.txt_City.TabIndex = 42;
            // 
            // btn_DeleteSelectedCustomer
            // 
            this.btn_DeleteSelectedCustomer.BackColor = System.Drawing.Color.Red;
            this.btn_DeleteSelectedCustomer.Location = new System.Drawing.Point(346, 529);
            this.btn_DeleteSelectedCustomer.Name = "btn_DeleteSelectedCustomer";
            this.btn_DeleteSelectedCustomer.Size = new System.Drawing.Size(160, 42);
            this.btn_DeleteSelectedCustomer.TabIndex = 49;
            this.btn_DeleteSelectedCustomer.Text = "Delete";
            this.btn_DeleteSelectedCustomer.UseVisualStyleBackColor = false;
            this.btn_DeleteSelectedCustomer.Click += new System.EventHandler(this.btn_DeleteSelectedCustomer_Click);
            // 
            // btn_UpdateSelectedCustomer
            // 
            this.btn_UpdateSelectedCustomer.BackColor = System.Drawing.Color.Yellow;
            this.btn_UpdateSelectedCustomer.Location = new System.Drawing.Point(178, 529);
            this.btn_UpdateSelectedCustomer.Name = "btn_UpdateSelectedCustomer";
            this.btn_UpdateSelectedCustomer.Size = new System.Drawing.Size(162, 42);
            this.btn_UpdateSelectedCustomer.TabIndex = 47;
            this.btn_UpdateSelectedCustomer.Text = "Update";
            this.btn_UpdateSelectedCustomer.UseVisualStyleBackColor = false;
            this.btn_UpdateSelectedCustomer.Click += new System.EventHandler(this.btn_UpdateSelectedCustomer_Click);
            // 
            // btn_AddNewCustomer
            // 
            this.btn_AddNewCustomer.BackColor = System.Drawing.Color.Lime;
            this.btn_AddNewCustomer.Location = new System.Drawing.Point(10, 529);
            this.btn_AddNewCustomer.Name = "btn_AddNewCustomer";
            this.btn_AddNewCustomer.Size = new System.Drawing.Size(162, 42);
            this.btn_AddNewCustomer.TabIndex = 46;
            this.btn_AddNewCustomer.Text = "New customer";
            this.btn_AddNewCustomer.UseVisualStyleBackColor = false;
            this.btn_AddNewCustomer.Click += new System.EventHandler(this.btn_AddNewCustomer_Click);
            // 
            // listBox_RegistredCustomers
            // 
            this.listBox_RegistredCustomers.FormattingEnabled = true;
            this.listBox_RegistredCustomers.ItemHeight = 20;
            this.listBox_RegistredCustomers.Location = new System.Drawing.Point(12, 12);
            this.listBox_RegistredCustomers.Name = "listBox_RegistredCustomers";
            this.listBox_RegistredCustomers.Size = new System.Drawing.Size(332, 284);
            this.listBox_RegistredCustomers.Sorted = true;
            this.listBox_RegistredCustomers.TabIndex = 50;
            this.listBox_RegistredCustomers.SelectedIndexChanged += new System.EventHandler(this.listBox_RegistredCustomers_SelectedIndexChanged);
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Location = new System.Drawing.Point(379, 272);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(68, 20);
            this.lbl_Country.TabIndex = 51;
            this.lbl_Country.Text = "Country:";
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(453, 269);
            this.txt_Country.Multiline = true;
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(206, 26);
            this.txt_Country.TabIndex = 44;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(375, 122);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(72, 20);
            this.lbl_Address.TabIndex = 45;
            this.lbl_Address.Text = "Address:";
            // 
            // lbl_SurName
            // 
            this.lbl_SurName.AutoSize = true;
            this.lbl_SurName.Location = new System.Drawing.Point(369, 70);
            this.lbl_SurName.Name = "lbl_SurName";
            this.lbl_SurName.Size = new System.Drawing.Size(78, 20);
            this.lbl_SurName.TabIndex = 43;
            this.lbl_SurName.Text = "Surname:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(359, 24);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(88, 20);
            this.lbl_Name.TabIndex = 41;
            this.lbl_Name.Text = "First name:";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(453, 119);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(206, 86);
            this.txt_Address.TabIndex = 39;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(453, 67);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(206, 26);
            this.txt_LastName.TabIndex = 38;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(453, 21);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(206, 26);
            this.txt_FirstName.TabIndex = 37;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // btn_Booking
            // 
            this.btn_Booking.Location = new System.Drawing.Point(453, 342);
            this.btn_Booking.Name = "btn_Booking";
            this.btn_Booking.Size = new System.Drawing.Size(206, 62);
            this.btn_Booking.TabIndex = 36;
            this.btn_Booking.Text = "Book room selected customer";
            this.btn_Booking.UseVisualStyleBackColor = true;
            this.btn_Booking.Click += new System.EventHandler(this.btn_Booking_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(453, 310);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(206, 26);
            this.txt_Email.TabIndex = 55;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(395, 313);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(52, 20);
            this.lbl_Email.TabIndex = 56;
            this.lbl_Email.Text = "Email:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 582);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.btn_ManageBookings);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.btn_DeleteSelectedCustomer);
            this.Controls.Add(this.btn_UpdateSelectedCustomer);
            this.Controls.Add(this.btn_AddNewCustomer);
            this.Controls.Add(this.listBox_RegistredCustomers);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_SurName);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.btn_Booking);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ManageBookings;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Button btn_DeleteSelectedCustomer;
        private System.Windows.Forms.Button btn_UpdateSelectedCustomer;
        private System.Windows.Forms.Button btn_AddNewCustomer;
        private System.Windows.Forms.ListBox listBox_RegistredCustomers;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.TextBox txt_Country;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_SurName;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Button btn_Booking;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
    }
}

