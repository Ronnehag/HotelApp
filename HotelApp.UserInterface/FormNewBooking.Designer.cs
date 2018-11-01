namespace HotelApp.UserInterface
{
    partial class FormNewBooking
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
            this.btn_GetMatchingRooms = new System.Windows.Forms.Button();
            this.cb_Customers = new System.Windows.Forms.ComboBox();
            this.lbl_Persons = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.datePicker_To = new System.Windows.Forms.DateTimePicker();
            this.datePicker_From = new System.Windows.Forms.DateTimePicker();
            this.btn_Book = new System.Windows.Forms.Button();
            this.listBox_AvailableRooms = new System.Windows.Forms.ListBox();
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
            this.gB_RoomInfo.Location = new System.Drawing.Point(792, 8);
            this.gB_RoomInfo.Name = "gB_RoomInfo";
            this.gB_RoomInfo.Size = new System.Drawing.Size(307, 228);
            this.gB_RoomInfo.TabIndex = 35;
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
            this.lbl_Available.Location = new System.Drawing.Point(12, 8);
            this.lbl_Available.Name = "lbl_Available";
            this.lbl_Available.Size = new System.Drawing.Size(124, 20);
            this.lbl_Available.TabIndex = 33;
            this.lbl_Available.Text = "Available rooms:";
            // 
            // btn_GetMatchingRooms
            // 
            this.btn_GetMatchingRooms.Location = new System.Drawing.Point(468, 179);
            this.btn_GetMatchingRooms.Name = "btn_GetMatchingRooms";
            this.btn_GetMatchingRooms.Size = new System.Drawing.Size(195, 57);
            this.btn_GetMatchingRooms.TabIndex = 31;
            this.btn_GetMatchingRooms.Text = "Show rooms";
            this.btn_GetMatchingRooms.UseVisualStyleBackColor = true;
            this.btn_GetMatchingRooms.Click += new System.EventHandler(this.btn_GetMatchingRooms_Click);
            // 
            // cb_Customers
            // 
            this.cb_Customers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Customers.FormattingEnabled = true;
            this.cb_Customers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cb_Customers.Location = new System.Drawing.Point(468, 133);
            this.cb_Customers.Name = "cb_Customers";
            this.cb_Customers.Size = new System.Drawing.Size(200, 28);
            this.cb_Customers.TabIndex = 27;
            // 
            // lbl_Persons
            // 
            this.lbl_Persons.AutoSize = true;
            this.lbl_Persons.Location = new System.Drawing.Point(391, 136);
            this.lbl_Persons.Name = "lbl_Persons";
            this.lbl_Persons.Size = new System.Drawing.Size(71, 20);
            this.lbl_Persons.TabIndex = 28;
            this.lbl_Persons.Text = "Persons:";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Location = new System.Drawing.Point(431, 87);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(31, 20);
            this.lbl_To.TabIndex = 26;
            this.lbl_To.Text = "To:";
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Location = new System.Drawing.Point(412, 36);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(50, 20);
            this.lbl_From.TabIndex = 25;
            this.lbl_From.Text = "From:";
            // 
            // datePicker_To
            // 
            this.datePicker_To.Location = new System.Drawing.Point(468, 82);
            this.datePicker_To.Name = "datePicker_To";
            this.datePicker_To.Size = new System.Drawing.Size(285, 26);
            this.datePicker_To.TabIndex = 24;
            this.datePicker_To.ValueChanged += new System.EventHandler(this.datePicker_To_ValueChanged);
            // 
            // datePicker_From
            // 
            this.datePicker_From.Location = new System.Drawing.Point(468, 31);
            this.datePicker_From.Name = "datePicker_From";
            this.datePicker_From.Size = new System.Drawing.Size(285, 26);
            this.datePicker_From.TabIndex = 23;
            this.datePicker_From.ValueChanged += new System.EventHandler(this.datePicker_From_ValueChanged);
            // 
            // btn_Book
            // 
            this.btn_Book.Location = new System.Drawing.Point(391, 396);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(195, 57);
            this.btn_Book.TabIndex = 22;
            this.btn_Book.Text = "Book selected";
            this.btn_Book.UseVisualStyleBackColor = true;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // listBox_AvailableRooms
            // 
            this.listBox_AvailableRooms.FormattingEnabled = true;
            this.listBox_AvailableRooms.ItemHeight = 20;
            this.listBox_AvailableRooms.Location = new System.Drawing.Point(12, 29);
            this.listBox_AvailableRooms.Name = "listBox_AvailableRooms";
            this.listBox_AvailableRooms.Size = new System.Drawing.Size(373, 424);
            this.listBox_AvailableRooms.TabIndex = 21;
            this.listBox_AvailableRooms.SelectedIndexChanged += new System.EventHandler(this.listBox_AvailableRooms_SelectedIndexChanged);
            // 
            // FormNewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 462);
            this.Controls.Add(this.gB_RoomInfo);
            this.Controls.Add(this.lbl_Available);
            this.Controls.Add(this.btn_GetMatchingRooms);
            this.Controls.Add(this.cb_Customers);
            this.Controls.Add(this.lbl_Persons);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.lbl_From);
            this.Controls.Add(this.datePicker_To);
            this.Controls.Add(this.datePicker_From);
            this.Controls.Add(this.btn_Book);
            this.Controls.Add(this.listBox_AvailableRooms);
            this.Name = "FormNewBooking";
            this.Text = "FormNewBooking";
            this.gB_RoomInfo.ResumeLayout(false);
            this.gB_RoomInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gB_RoomInfo;
        private System.Windows.Forms.Label lbl_ExtraBeds;
        private System.Windows.Forms.TextBox txt_Beds;
        private System.Windows.Forms.ComboBox cb_ExtraBeds;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox txt_RoomPrice;
        private System.Windows.Forms.Label lbl_Beds;
        private System.Windows.Forms.Label lbl_Available;
        private System.Windows.Forms.Button btn_GetMatchingRooms;
        private System.Windows.Forms.ComboBox cb_Customers;
        private System.Windows.Forms.Label lbl_Persons;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.DateTimePicker datePicker_To;
        private System.Windows.Forms.DateTimePicker datePicker_From;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.ListBox listBox_AvailableRooms;
        private System.Windows.Forms.Label lbl_PricePerNight;
        private System.Windows.Forms.TextBox txt_PerNight;
    }
}