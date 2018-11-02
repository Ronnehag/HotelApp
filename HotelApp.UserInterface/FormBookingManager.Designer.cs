namespace HotelApp.UserInterface
{
    partial class FormBookingManager
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
            this.btn_RegisterInvoice = new System.Windows.Forms.Button();
            this.dataGridView_Bookings = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bookings)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_RegisterInvoice
            // 
            this.btn_RegisterInvoice.Location = new System.Drawing.Point(2, 12);
            this.btn_RegisterInvoice.Name = "btn_RegisterInvoice";
            this.btn_RegisterInvoice.Size = new System.Drawing.Size(183, 55);
            this.btn_RegisterInvoice.TabIndex = 3;
            this.btn_RegisterInvoice.Text = "Register invoice";
            this.btn_RegisterInvoice.UseVisualStyleBackColor = true;
            this.btn_RegisterInvoice.Click += new System.EventHandler(this.btn_RegisterInvoice_Click);
            // 
            // dataGridView_Bookings
            // 
            this.dataGridView_Bookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Bookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Bookings.Location = new System.Drawing.Point(2, 234);
            this.dataGridView_Bookings.Name = "dataGridView_Bookings";
            this.dataGridView_Bookings.ReadOnly = true;
            this.dataGridView_Bookings.RowTemplate.Height = 28;
            this.dataGridView_Bookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Bookings.Size = new System.Drawing.Size(1033, 379);
            this.dataGridView_Bookings.TabIndex = 2;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(2, 73);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(183, 55);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete selected";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(2, 134);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(183, 55);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Update selected";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(903, 175);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(132, 53);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh table";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // FormBookingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 625);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_RegisterInvoice);
            this.Controls.Add(this.dataGridView_Bookings);
            this.Name = "FormBookingManager";
            this.Text = "FormBookingManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bookings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_RegisterInvoice;
        private System.Windows.Forms.DataGridView dataGridView_Bookings;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Refresh;
    }
}