namespace HotelApp.UserInterface
{
    partial class FormInvoice
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_RegisterPayment = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_PaidAmount = new System.Windows.Forms.Label();
            this.lbl_InvoiceSum = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.txt_Paid = new System.Windows.Forms.TextBox();
            this.lbl_CustomerId = new System.Windows.Forms.Label();
            this.txt_CustomerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_BookingId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "SEK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "SEK";
            // 
            // btn_RegisterPayment
            // 
            this.btn_RegisterPayment.Location = new System.Drawing.Point(21, 275);
            this.btn_RegisterPayment.Name = "btn_RegisterPayment";
            this.btn_RegisterPayment.Size = new System.Drawing.Size(177, 60);
            this.btn_RegisterPayment.TabIndex = 24;
            this.btn_RegisterPayment.Text = "Register payment";
            this.btn_RegisterPayment.UseVisualStyleBackColor = true;
            this.btn_RegisterPayment.Click += new System.EventHandler(this.btn_RegisterPayment_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(204, 275);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(139, 60);
            this.btn_Cancel.TabIndex = 23;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_PaidAmount
            // 
            this.lbl_PaidAmount.AutoSize = true;
            this.lbl_PaidAmount.Location = new System.Drawing.Point(77, 153);
            this.lbl_PaidAmount.Name = "lbl_PaidAmount";
            this.lbl_PaidAmount.Size = new System.Drawing.Size(44, 20);
            this.lbl_PaidAmount.TabIndex = 22;
            this.lbl_PaidAmount.Text = "Paid:";
            // 
            // lbl_InvoiceSum
            // 
            this.lbl_InvoiceSum.AutoSize = true;
            this.lbl_InvoiceSum.Location = new System.Drawing.Point(52, 104);
            this.lbl_InvoiceSum.Name = "lbl_InvoiceSum";
            this.lbl_InvoiceSum.Size = new System.Drawing.Size(69, 20);
            this.lbl_InvoiceSum.TabIndex = 21;
            this.lbl_InvoiceSum.Text = "Amount:";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(127, 101);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.ReadOnly = true;
            this.txt_Amount.Size = new System.Drawing.Size(102, 26);
            this.txt_Amount.TabIndex = 20;
            // 
            // txt_Paid
            // 
            this.txt_Paid.Location = new System.Drawing.Point(127, 150);
            this.txt_Paid.Name = "txt_Paid";
            this.txt_Paid.Size = new System.Drawing.Size(102, 26);
            this.txt_Paid.TabIndex = 19;
            // 
            // lbl_CustomerId
            // 
            this.lbl_CustomerId.AutoSize = true;
            this.lbl_CustomerId.Location = new System.Drawing.Point(18, 18);
            this.lbl_CustomerId.Name = "lbl_CustomerId";
            this.lbl_CustomerId.Size = new System.Drawing.Size(103, 20);
            this.lbl_CustomerId.TabIndex = 18;
            this.lbl_CustomerId.Text = "Customer ID:";
            // 
            // txt_CustomerId
            // 
            this.txt_CustomerId.Location = new System.Drawing.Point(127, 15);
            this.txt_CustomerId.Name = "txt_CustomerId";
            this.txt_CustomerId.ReadOnly = true;
            this.txt_CustomerId.Size = new System.Drawing.Size(66, 26);
            this.txt_CustomerId.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Booking ID:";
            // 
            // txt_BookingId
            // 
            this.txt_BookingId.Location = new System.Drawing.Point(127, 60);
            this.txt_BookingId.Name = "txt_BookingId";
            this.txt_BookingId.ReadOnly = true;
            this.txt_BookingId.Size = new System.Drawing.Size(66, 26);
            this.txt_BookingId.TabIndex = 27;
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_BookingId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_RegisterPayment);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_PaidAmount);
            this.Controls.Add(this.lbl_InvoiceSum);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.txt_Paid);
            this.Controls.Add(this.lbl_CustomerId);
            this.Controls.Add(this.txt_CustomerId);
            this.Name = "FormInvoice";
            this.Text = "FormInvoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_RegisterPayment;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_PaidAmount;
        private System.Windows.Forms.Label lbl_InvoiceSum;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.TextBox txt_Paid;
        private System.Windows.Forms.Label lbl_CustomerId;
        private System.Windows.Forms.TextBox txt_CustomerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_BookingId;
    }
}