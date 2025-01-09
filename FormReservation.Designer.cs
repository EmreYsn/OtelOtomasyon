namespace OtelOtomasyonu
{
    partial class FormReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReservation));
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phoneNumberTxt = new System.Windows.Forms.MaskedTextBox();
            this.reservationBtn = new System.Windows.Forms.Button();
            this.roomPriceTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.customerSurnameTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.customerNameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.roomNumberCombobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.roomTypeCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.exitTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.entryTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backBtn.ForeColor = System.Drawing.Color.Red;
            this.backBtn.Location = new System.Drawing.Point(12, 601);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(101, 42);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Geri";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.phoneNumberTxt);
            this.groupBox1.Controls.Add(this.reservationBtn);
            this.groupBox1.Controls.Add(this.roomPriceTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.customerSurnameTxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.customerNameTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.roomNumberCombobox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.roomTypeCombobox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.exitTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.entryTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 566);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervasyon Formu";
            // 
            // phoneNumberTxt
            // 
            this.phoneNumberTxt.Enabled = false;
            this.phoneNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneNumberTxt.Location = new System.Drawing.Point(31, 84);
            this.phoneNumberTxt.Mask = "(999) 000-0000";
            this.phoneNumberTxt.Name = "phoneNumberTxt";
            this.phoneNumberTxt.Size = new System.Drawing.Size(308, 31);
            this.phoneNumberTxt.TabIndex = 29;
            // 
            // reservationBtn
            // 
            this.reservationBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reservationBtn.ForeColor = System.Drawing.Color.Blue;
            this.reservationBtn.Location = new System.Drawing.Point(278, 518);
            this.reservationBtn.Name = "reservationBtn";
            this.reservationBtn.Size = new System.Drawing.Size(110, 42);
            this.reservationBtn.TabIndex = 28;
            this.reservationBtn.Text = "Oluştur";
            this.reservationBtn.UseVisualStyleBackColor = true;
            this.reservationBtn.Click += new System.EventHandler(this.reservationBtn_Click);
            // 
            // roomPriceTxt
            // 
            this.roomPriceTxt.Enabled = false;
            this.roomPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomPriceTxt.Location = new System.Drawing.Point(433, 355);
            this.roomPriceTxt.Name = "roomPriceTxt";
            this.roomPriceTxt.Size = new System.Drawing.Size(237, 31);
            this.roomPriceTxt.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(428, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Oda Fiyatı";
            // 
            // customerSurnameTxt
            // 
            this.customerSurnameTxt.Enabled = false;
            this.customerSurnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerSurnameTxt.Location = new System.Drawing.Point(433, 191);
            this.customerSurnameTxt.Name = "customerSurnameTxt";
            this.customerSurnameTxt.Size = new System.Drawing.Size(237, 31);
            this.customerSurnameTxt.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(428, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Soyadı";
            // 
            // customerNameTxt
            // 
            this.customerNameTxt.Enabled = false;
            this.customerNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerNameTxt.Location = new System.Drawing.Point(433, 84);
            this.customerNameTxt.Name = "customerNameTxt";
            this.customerNameTxt.Size = new System.Drawing.Size(237, 31);
            this.customerNameTxt.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(428, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Adı";
            // 
            // roomNumberCombobox
            // 
            this.roomNumberCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomNumberCombobox.FormattingEnabled = true;
            this.roomNumberCombobox.Location = new System.Drawing.Point(31, 461);
            this.roomNumberCombobox.Name = "roomNumberCombobox";
            this.roomNumberCombobox.Size = new System.Drawing.Size(308, 33);
            this.roomNumberCombobox.TabIndex = 21;
            this.roomNumberCombobox.SelectedIndexChanged += new System.EventHandler(this.roomNumberCombobox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Oda Numarası";
            // 
            // roomTypeCombobox
            // 
            this.roomTypeCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomTypeCombobox.FormattingEnabled = true;
            this.roomTypeCombobox.Location = new System.Drawing.Point(31, 355);
            this.roomTypeCombobox.Name = "roomTypeCombobox";
            this.roomTypeCombobox.Size = new System.Drawing.Size(308, 33);
            this.roomTypeCombobox.TabIndex = 19;
            this.roomTypeCombobox.SelectedIndexChanged += new System.EventHandler(this.roomTypeCombobox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Oda Tipi";
            // 
            // exitTimePicker
            // 
            this.exitTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitTimePicker.Location = new System.Drawing.Point(31, 268);
            this.exitTimePicker.Name = "exitTimePicker";
            this.exitTimePicker.Size = new System.Drawing.Size(308, 30);
            this.exitTimePicker.TabIndex = 17;
            this.exitTimePicker.ValueChanged += new System.EventHandler(this.exitTimePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Çıkış Zamanı";
            // 
            // entryTimePicker
            // 
            this.entryTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.entryTimePicker.Location = new System.Drawing.Point(31, 173);
            this.entryTimePicker.Name = "entryTimePicker";
            this.entryTimePicker.Size = new System.Drawing.Size(308, 30);
            this.entryTimePicker.TabIndex = 15;
            this.entryTimePicker.ValueChanged += new System.EventHandler(this.entryTimePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Giriş Zamanı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Telefon Numarası";
            // 
            // FormReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(713, 655);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormReservation";
            this.Text = "Otel Otomasyonu";
            this.Load += new System.EventHandler(this.FormReservation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker entryTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox roomNumberCombobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox roomTypeCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker exitTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerSurnameTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox customerNameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox roomPriceTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button reservationBtn;
        private System.Windows.Forms.MaskedTextBox phoneNumberTxt;
    }
}