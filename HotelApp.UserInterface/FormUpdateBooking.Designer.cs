namespace HotelApp.UserInterface
{
    partial class FormUpdateBooking
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
            this.gB_RoomInfo = new System.Windows.Forms.GroupBox();
            this.lbl_PricePerNight = new System.Windows.Forms.Label();
            this.txt_PerNight = new System.Windows.Forms.TextBox();
            this.lbl_ExtraBeds = new System.Windows.Forms.Label();
            this.txt_Beds = new System.Windows.Forms.TextBox();
            this.cb_ExtraBeds = new System.Windows.Forms.ComboBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txt_RoomPrice = new System.Windows.Forms.TextBox();
            this.lbl_Beds = new System.Windows.Forms.Label();
            this.lbl_Available = new System.Windows.Forms.Label();
            this.cb_Customers = new System.Windows.Forms.ComboBox();
            this.lbl_Persons = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.datePicker_To = new System.Windows.Forms.DateTimePicker();
            this.datePicker_From = new System.Windows.Forms.DateTimePicker();
            this.btn_Update = new System.Windows.Forms.Button();
            this.gB_RoomInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB_RoomInfo
            // 
            this.gB_RoomInfo.Controls.Add(this.lbl_PricePerNight);
            this.gB_RoomInfo.Controls.Add(this.txt_PerNight);
            this.gB_RoomInfo.Controls.Add(this.lbl_ExtraBeds);
            this.gB_RoomInfo.Controls.Add(this.txt_Beds);
            this.gB_RoomInfo.Controls.Add(this.cb_ExtraBeds);
            this.gB_RoomInfo.Controls.Add(this.lbl_Price);
            this.gB_RoomInfo.Controls.Add(this.txt_RoomPrice);
            this.gB_RoomInfo.Controls.Add(this.lbl_Beds);
            this.gB_RoomInfo.Location = new System.Drawing.Point(410, 8);
            this.gB_RoomInfo.Name = "gB_RoomInfo";
            this.gB_RoomInfo.Size = new System.Drawing.Size(307, 255);
            this.gB_RoomInfo.TabIndex = 46;
            this.gB_RoomInfo.TabStop = false;
            this.gB_RoomInfo.Text = "Room information";
            // 
            // lbl_PricePerNight
            // 
            this.lbl_PricePerNight.AutoSize = true;
            this.lbl_PricePerNight.Location = new System.Drawing.Point(19, 115);
            this.lbl_PricePerNight.Name = "lbl_PricePerNight";
            this.lbl_PricePerNight.Size = new System.Drawing.Size(76, 20);
            this.lbl_PricePerNight.TabIndex = 20;
            this.lbl_PricePerNight.Text = "Per night:";
            // 
            // txt_PerNight
            // 
            this.txt_PerNight.Location = new System.Drawing.Point(101, 112);
            this.txt_PerNight.Name = "txt_PerNight";
            this.txt_PerNight.ReadOnly = true;
            this.txt_PerNight.Size = new System.Drawing.Size(107, 26);
            this.txt_PerNight.TabIndex = 21;
            // 
            // lbl_ExtraBeds
            // 
            this.lbl_ExtraBeds.AutoSize = true;
            this.lbl_ExtraBeds.Location = new System.Drawing.Point(6, 29);
            this.lbl_ExtraBeds.Name = "lbl_ExtraBeds";
            this.lbl_ExtraBeds.Size = new System.Drawing.Size(89, 20);
            this.lbl_ExtraBeds.TabIndex = 7;
            this.lbl_ExtraBeds.Text = "Extra beds:";
            // 
            // txt_Beds
            // 
            this.txt_Beds.Location = new System.Drawing.Point(101, 71);
            this.txt_Beds.Name = "txt_Beds";
            this.txt_Beds.ReadOnly = true;
            this.txt_Beds.Size = new System.Drawing.Size(107, 26);
            this.txt_Beds.TabIndex = 19;
            // 
            // cb_ExtraBeds
            // 
            this.cb_ExtraBeds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ExtraBeds.FormattingEnabled = true;
            this.cb_ExtraBeds.Location = new System.Drawing.Point(101, 26);
            this.cb_ExtraBeds.Name = "cb_ExtraBeds";
            this.cb_ExtraBeds.Size = new System.Drawing.Size(200, 28);
            this.cb_ExtraBeds.TabIndex = 6;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(47, 189);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(48, 20);
            this.lbl_Price.TabIndex = 16;
            this.lbl_Price.Text = "Total:";
            // 
            // txt_RoomPrice
            // 
            this.txt_RoomPrice.Location = new System.Drawing.Point(101, 186);
            this.txt_RoomPrice.Name = "txt_RoomPrice";
            this.txt_RoomPrice.ReadOnly = true;
            this.txt_RoomPrice.Size = new System.Drawing.Size(107, 26);
            this.txt_RoomPrice.TabIndex = 17;
            // 
            // lbl_Beds
            // 
            this.lbl_Beds.AutoSize = true;
            this.lbl_Beds.Location = new System.Drawing.Point(45, 74);
            this.lbl_Beds.Name = "lbl_Beds";
            this.lbl_Beds.Size = new System.Drawing.Size(50, 20);
            this.lbl_Beds.TabIndex = 18;
            this.lbl_Beds.Text = "Beds:";
            // 
            // lbl_Available
            // 
            this.lbl_Available.AutoSize = true;
            this.lbl_Available.Location = new System.Drawing.Point(-370, 8);
            this.lbl_Available.Name = "lbl_Available";
            this.lbl_Available.Size = new System.Drawing.Size(124, 20);
            this.lbl_Available.TabIndex = 45;
            this.lbl_Available.Text = "Available rooms:";
            // 
            // cb_Customers
            // 
            this.cb_Customers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Customers.FormattingEnabled = true;
            this.cb_Customers.Location = new System.Drawing.Point(86, 133);
            this.cb_Customers.Name = "cb_Customers";
            this.cb_Customers.Size = new System.Drawing.Size(200, 28);
            this.cb_Customers.TabIndex = 42;
            // 
            // lbl_Persons
            // 
            this.lbl_Persons.AutoSize = true;
            this.lbl_Persons.Location = new System.Drawing.Point(9, 136);
            this.lbl_Persons.Name = "lbl_Persons";
            this.lbl_Persons.Size = new System.Drawing.Size(71, 20);
            this.lbl_Persons.TabIndex = 43;
            this.lbl_Persons.Text = "Persons:";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Location = new System.Drawing.Point(49, 87);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(31, 20);
            this.lbl_To.TabIndex = 41;
            this.lbl_To.Text = "To:";
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Location = new System.Drawing.Point(30, 36);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(50, 20);
            this.lbl_From.TabIndex = 40;
            this.lbl_From.Text = "From:";
            // 
            // datePicker_To
            // 
            this.datePicker_To.Location = new System.Drawing.Point(86, 82);
            this.datePicker_To.Name = "datePicker_To";
            this.datePicker_To.Size = new System.Drawing.Size(285, 26);
            this.datePicker_To.TabIndex = 39;
            this.datePicker_To.ValueChanged += new System.EventHandler(this.datePicker_To_ValueChanged);
            // 
            // datePicker_From
            // 
            this.datePicker_From.Location = new System.Drawing.Point(86, 31);
            this.datePicker_From.Name = "datePicker_From";
            this.datePicker_From.Size = new System.Drawing.Size(285, 26);
            this.datePicker_From.TabIndex = 38;
            this.datePicker_From.ValueChanged += new System.EventHandler(this.datePicker_From_ValueChanged);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(86, 206);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(195, 57);
            this.btn_Update.TabIndex = 37;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // FormUpdateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 298);
            this.Controls.Add(this.gB_RoomInfo);
            this.Controls.Add(this.lbl_Available);
            this.Controls.Add(this.cb_Customers);
            this.Controls.Add(this.lbl_Persons);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.lbl_From);
            this.Controls.Add(this.datePicker_To);
            this.Controls.Add(this.datePicker_From);
            this.Controls.Add(this.btn_Update);
            this.Name = "FormUpdateBooking";
            this.Text = "FormUpdateBooking";
            this.gB_RoomInfo.ResumeLayout(false);
            this.gB_RoomInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gB_RoomInfo;
        private System.Windows.Forms.Label lbl_PricePerNight;
        private System.Windows.Forms.TextBox txt_PerNight;
        private System.Windows.Forms.Label lbl_ExtraBeds;
        private System.Windows.Forms.TextBox txt_Beds;
        private System.Windows.Forms.ComboBox cb_ExtraBeds;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox txt_RoomPrice;
        private System.Windows.Forms.Label lbl_Beds;
        private System.Windows.Forms.Label lbl_Available;
        private System.Windows.Forms.ComboBox cb_Customers;
        private System.Windows.Forms.Label lbl_Persons;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.DateTimePicker datePicker_To;
        private System.Windows.Forms.DateTimePicker datePicker_From;
        private System.Windows.Forms.Button btn_Update;
    }
}