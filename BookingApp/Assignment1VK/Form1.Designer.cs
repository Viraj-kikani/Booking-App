namespace Assignment1VK
{
    partial class Form1
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
            this.lstRows = new System.Windows.Forms.ListBox();
            this.lstColums = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameOfCust = new System.Windows.Forms.TextBox();
            this.btnA1 = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnA4 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnB4 = new System.Windows.Forms.Button();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.btnC4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.cancelBooking = new System.Windows.Forms.Button();
            this.allSeats = new System.Windows.Forms.Button();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpVenue = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grpVenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRows
            // 
            this.lstRows.FormattingEnabled = true;
            this.lstRows.ItemHeight = 25;
            this.lstRows.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.lstRows.Location = new System.Drawing.Point(589, 175);
            this.lstRows.Name = "lstRows";
            this.lstRows.Size = new System.Drawing.Size(182, 304);
            this.lstRows.TabIndex = 0;
            // 
            // lstColums
            // 
            this.lstColums.FormattingEnabled = true;
            this.lstColums.ItemHeight = 25;
            this.lstColums.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.lstColums.Location = new System.Drawing.Point(802, 175);
            this.lstColums.Name = "lstColums";
            this.lstColums.Size = new System.Drawing.Size(165, 304);
            this.lstColums.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(584, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer name:";
            // 
            // nameOfCust
            // 
            this.nameOfCust.Location = new System.Drawing.Point(772, 495);
            this.nameOfCust.Multiline = true;
            this.nameOfCust.Name = "nameOfCust";
            this.nameOfCust.Size = new System.Drawing.Size(195, 41);
            this.nameOfCust.TabIndex = 3;
            // 
            // btnA1
            // 
            this.btnA1.BackColor = System.Drawing.Color.Lime;
            this.btnA1.Location = new System.Drawing.Point(15, 30);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(81, 64);
            this.btnA1.TabIndex = 4;
            this.btnA1.Text = "A1";
            this.btnA1.UseVisualStyleBackColor = false;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(37, 27);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(676, 25);
            this.status.TabIndex = 5;
            this.status.Text = "Total capacity 12, Seet$ 12 (I.e. et capacity). no one is on the weit list";
            // 
            // btnA2
            // 
            this.btnA2.BackColor = System.Drawing.Color.Lime;
            this.btnA2.Location = new System.Drawing.Point(102, 30);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(81, 64);
            this.btnA2.TabIndex = 7;
            this.btnA2.Text = "A2";
            this.btnA2.UseVisualStyleBackColor = false;
            // 
            // btnA3
            // 
            this.btnA3.BackColor = System.Drawing.Color.Lime;
            this.btnA3.Location = new System.Drawing.Point(198, 30);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(81, 64);
            this.btnA3.TabIndex = 8;
            this.btnA3.Text = "A3";
            this.btnA3.UseVisualStyleBackColor = false;
            // 
            // btnA4
            // 
            this.btnA4.BackColor = System.Drawing.Color.Lime;
            this.btnA4.Location = new System.Drawing.Point(285, 30);
            this.btnA4.Name = "btnA4";
            this.btnA4.Size = new System.Drawing.Size(81, 64);
            this.btnA4.TabIndex = 9;
            this.btnA4.Text = "A4";
            this.btnA4.UseVisualStyleBackColor = false;
            // 
            // btnB1
            // 
            this.btnB1.BackColor = System.Drawing.Color.Lime;
            this.btnB1.Location = new System.Drawing.Point(15, 121);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(81, 64);
            this.btnB1.TabIndex = 10;
            this.btnB1.Text = "B1";
            this.btnB1.UseVisualStyleBackColor = false;
            // 
            // btnB2
            // 
            this.btnB2.BackColor = System.Drawing.Color.Lime;
            this.btnB2.Location = new System.Drawing.Point(102, 121);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(81, 64);
            this.btnB2.TabIndex = 11;
            this.btnB2.Text = "B2";
            this.btnB2.UseVisualStyleBackColor = false;
            // 
            // btnB3
            // 
            this.btnB3.BackColor = System.Drawing.Color.Lime;
            this.btnB3.Location = new System.Drawing.Point(198, 121);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(81, 64);
            this.btnB3.TabIndex = 12;
            this.btnB3.Text = "B3";
            this.btnB3.UseVisualStyleBackColor = false;
            // 
            // btnB4
            // 
            this.btnB4.BackColor = System.Drawing.Color.Lime;
            this.btnB4.Location = new System.Drawing.Point(285, 121);
            this.btnB4.Name = "btnB4";
            this.btnB4.Size = new System.Drawing.Size(81, 64);
            this.btnB4.TabIndex = 13;
            this.btnB4.Text = "B4";
            this.btnB4.UseVisualStyleBackColor = false;
            // 
            // btnC1
            // 
            this.btnC1.BackColor = System.Drawing.Color.Lime;
            this.btnC1.Location = new System.Drawing.Point(15, 211);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(81, 64);
            this.btnC1.TabIndex = 14;
            this.btnC1.Text = "C1";
            this.btnC1.UseVisualStyleBackColor = false;
            // 
            // btnC2
            // 
            this.btnC2.BackColor = System.Drawing.Color.Lime;
            this.btnC2.Location = new System.Drawing.Point(102, 211);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(81, 64);
            this.btnC2.TabIndex = 15;
            this.btnC2.Text = "C2";
            this.btnC2.UseVisualStyleBackColor = false;
            // 
            // btnC3
            // 
            this.btnC3.BackColor = System.Drawing.Color.Lime;
            this.btnC3.Location = new System.Drawing.Point(198, 211);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(81, 64);
            this.btnC3.TabIndex = 16;
            this.btnC3.Text = "C3";
            this.btnC3.UseVisualStyleBackColor = false;
            // 
            // btnC4
            // 
            this.btnC4.BackColor = System.Drawing.Color.Lime;
            this.btnC4.Location = new System.Drawing.Point(285, 211);
            this.btnC4.Name = "btnC4";
            this.btnC4.Size = new System.Drawing.Size(81, 64);
            this.btnC4.TabIndex = 17;
            this.btnC4.Text = "C4";
            this.btnC4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "A1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(589, 569);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(137, 46);
            this.btnBook.TabIndex = 18;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // cancelBooking
            // 
            this.cancelBooking.Location = new System.Drawing.Point(843, 644);
            this.cancelBooking.Name = "cancelBooking";
            this.cancelBooking.Size = new System.Drawing.Size(202, 46);
            this.cancelBooking.TabIndex = 19;
            this.cancelBooking.Text = "Cancel all booking";
            this.cancelBooking.UseVisualStyleBackColor = true;
            this.cancelBooking.Click += new System.EventHandler(this.cancelBooking_Click);
            // 
            // allSeats
            // 
            this.allSeats.Location = new System.Drawing.Point(589, 644);
            this.allSeats.Name = "allSeats";
            this.allSeats.Size = new System.Drawing.Size(197, 46);
            this.allSeats.TabIndex = 20;
            this.allSeats.Text = "Fill all seats";
            this.allSeats.UseVisualStyleBackColor = true;
            this.allSeats.Click += new System.EventHandler(this.allSeats_Click);
            // 
            // btnPending
            // 
            this.btnPending.Location = new System.Drawing.Point(912, 569);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(192, 46);
            this.btnPending.TabIndex = 21;
            this.btnPending.Text = "Add to waited";
            this.btnPending.UseVisualStyleBackColor = true;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(748, 569);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 46);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Rows:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(797, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Colums:";
            // 
            // grpVenue
            // 
            this.grpVenue.Controls.Add(this.btnA1);
            this.grpVenue.Controls.Add(this.btnA2);
            this.grpVenue.Controls.Add(this.btnA3);
            this.grpVenue.Controls.Add(this.btnA4);
            this.grpVenue.Controls.Add(this.btnB1);
            this.grpVenue.Controls.Add(this.btnB2);
            this.grpVenue.Controls.Add(this.btnB3);
            this.grpVenue.Controls.Add(this.btnB4);
            this.grpVenue.Controls.Add(this.btnC4);
            this.grpVenue.Controls.Add(this.btnC1);
            this.grpVenue.Controls.Add(this.btnC3);
            this.grpVenue.Controls.Add(this.btnC2);
            this.grpVenue.Location = new System.Drawing.Point(42, 134);
            this.grpVenue.Name = "grpVenue";
            this.grpVenue.Size = new System.Drawing.Size(391, 293);
            this.grpVenue.TabIndex = 25;
            this.grpVenue.TabStop = false;
            this.grpVenue.Text = "Venue:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(52, 644);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 33);
            this.lblInfo.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1123, 737);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.grpVenue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPending);
            this.Controls.Add(this.allSeats);
            this.Controls.Add(this.cancelBooking);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.status);
            this.Controls.Add(this.nameOfCust);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstColums);
            this.Controls.Add(this.lstRows);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Load);
            this.grpVenue.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRows;
        private System.Windows.Forms.ListBox lstColums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameOfCust;
        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.Button btnA4;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnB4;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.Button btnC4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button cancelBooking;
        private System.Windows.Forms.Button allSeats;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpVenue;
        private System.Windows.Forms.Label lblInfo;
    }
}

