namespace OtelOtomasyonu
{
    partial class FormPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phoneNumberTxt = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.roomPriceTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roomTypeTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.roomNumberTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.exitTimeTxt = new System.Windows.Forms.MaskedTextBox();
            this.entryTimeTxt = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.totalPriceTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.reservationIdTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backBtn.ForeColor = System.Drawing.Color.Red;
            this.backBtn.Location = new System.Drawing.Point(12, 512);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(101, 42);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "Geri";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.phoneNumberTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.surnameTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(35, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 145);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // phoneNumberTxt
            // 
            this.phoneNumberTxt.BackColor = System.Drawing.Color.SlateGray;
            this.phoneNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumberTxt.Enabled = false;
            this.phoneNumberTxt.Location = new System.Drawing.Point(176, 96);
            this.phoneNumberTxt.Mask = "(999) 000-0000";
            this.phoneNumberTxt.Name = "phoneNumberTxt";
            this.phoneNumberTxt.Size = new System.Drawing.Size(276, 22);
            this.phoneNumberTxt.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Telefon No :";
            // 
            // surnameTxt
            // 
            this.surnameTxt.BackColor = System.Drawing.Color.SlateGray;
            this.surnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surnameTxt.Enabled = false;
            this.surnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameTxt.Location = new System.Drawing.Point(648, 42);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(253, 22);
            this.surnameTxt.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(519, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Soyadınız :";
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.Color.SlateGray;
            this.nameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTxt.Enabled = false;
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTxt.Location = new System.Drawing.Point(195, 44);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(257, 22);
            this.nameTxt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Adınız :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.roomPriceTxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.roomTypeTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.roomNumberTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(35, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 145);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oda Bilgileri";
            // 
            // roomPriceTxt
            // 
            this.roomPriceTxt.BackColor = System.Drawing.Color.SlateGray;
            this.roomPriceTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomPriceTxt.Enabled = false;
            this.roomPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomPriceTxt.Location = new System.Drawing.Point(195, 90);
            this.roomPriceTxt.Name = "roomPriceTxt";
            this.roomPriceTxt.Size = new System.Drawing.Size(257, 22);
            this.roomPriceTxt.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Oda Fiyatı :";
            // 
            // roomTypeTxt
            // 
            this.roomTypeTxt.BackColor = System.Drawing.Color.SlateGray;
            this.roomTypeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomTypeTxt.Enabled = false;
            this.roomTypeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomTypeTxt.Location = new System.Drawing.Point(648, 28);
            this.roomTypeTxt.Name = "roomTypeTxt";
            this.roomTypeTxt.Size = new System.Drawing.Size(253, 22);
            this.roomTypeTxt.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(529, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Oda Tipi :";
            // 
            // roomNumberTxt
            // 
            this.roomNumberTxt.BackColor = System.Drawing.Color.SlateGray;
            this.roomNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomNumberTxt.Enabled = false;
            this.roomNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomNumberTxt.Location = new System.Drawing.Point(195, 44);
            this.roomNumberTxt.Name = "roomNumberTxt";
            this.roomNumberTxt.Size = new System.Drawing.Size(257, 22);
            this.roomNumberTxt.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(49, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Oda No :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.exitTimeTxt);
            this.groupBox3.Controls.Add(this.entryTimeTxt);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.totalPriceTxt);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.reservationIdTxt);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(35, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(907, 145);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rezervasyon Bilgileri";
            // 
            // exitTimeTxt
            // 
            this.exitTimeTxt.BackColor = System.Drawing.Color.SlateGray;
            this.exitTimeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exitTimeTxt.Enabled = false;
            this.exitTimeTxt.Location = new System.Drawing.Point(648, 96);
            this.exitTimeTxt.Mask = "00/00/0000";
            this.exitTimeTxt.Name = "exitTimeTxt";
            this.exitTimeTxt.Size = new System.Drawing.Size(253, 22);
            this.exitTimeTxt.TabIndex = 24;
            this.exitTimeTxt.ValidatingType = typeof(System.DateTime);
            // 
            // entryTimeTxt
            // 
            this.entryTimeTxt.BackColor = System.Drawing.Color.SlateGray;
            this.entryTimeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entryTimeTxt.Enabled = false;
            this.entryTimeTxt.Location = new System.Drawing.Point(648, 39);
            this.entryTimeTxt.Mask = "00/00/0000";
            this.entryTimeTxt.Name = "entryTimeTxt";
            this.entryTimeTxt.Size = new System.Drawing.Size(253, 22);
            this.entryTimeTxt.TabIndex = 23;
            this.entryTimeTxt.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(490, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Çıkış Zamanı :";
            // 
            // totalPriceTxt
            // 
            this.totalPriceTxt.BackColor = System.Drawing.Color.SlateGray;
            this.totalPriceTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalPriceTxt.Enabled = false;
            this.totalPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalPriceTxt.Location = new System.Drawing.Point(195, 95);
            this.totalPriceTxt.Name = "totalPriceTxt";
            this.totalPriceTxt.Size = new System.Drawing.Size(257, 22);
            this.totalPriceTxt.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(40, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Toplam Fiyat :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(492, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Giriş Zamanı :";
            // 
            // reservationIdTxt
            // 
            this.reservationIdTxt.BackColor = System.Drawing.Color.SlateGray;
            this.reservationIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservationIdTxt.Enabled = false;
            this.reservationIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reservationIdTxt.Location = new System.Drawing.Point(195, 44);
            this.reservationIdTxt.Name = "reservationIdTxt";
            this.reservationIdTxt.Size = new System.Drawing.Size(257, 22);
            this.reservationIdTxt.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(17, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Rezervasyon Id :";
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(964, 572);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPayment";
            this.Text = "Otel Otomasyonu";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox roomPriceTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox roomTypeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox roomNumberTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totalPriceTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox reservationIdTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox phoneNumberTxt;
        private System.Windows.Forms.MaskedTextBox entryTimeTxt;
        private System.Windows.Forms.MaskedTextBox exitTimeTxt;
    }
}