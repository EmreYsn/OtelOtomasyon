namespace OtelOtomasyonu
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roomListBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roomTypeCombobox = new System.Windows.Forms.ComboBox();
            this.roomNumberCombobox = new System.Windows.Forms.ComboBox();
            this.roomDeleteTxt = new System.Windows.Forms.TextBox();
            this.roomDeleteBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.roomChangeBtn = new System.Windows.Forms.Button();
            this.roomChangeTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.roomAddCombobox = new System.Windows.Forms.ComboBox();
            this.roomEmptyBtn = new System.Windows.Forms.Button();
            this.roomFullBtn = new System.Windows.Forms.Button();
            this.roomLayoutTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.roomAddBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.roomAddTxt = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.customerViewBtn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.adminRegisterLink = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.paymentViewBtn = new System.Windows.Forms.Button();
            this.paymentDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backBtn.ForeColor = System.Drawing.Color.Red;
            this.backBtn.Location = new System.Drawing.Point(12, 662);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(101, 42);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Geri";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roomListBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.roomTypeCombobox);
            this.groupBox1.Controls.Add(this.roomNumberCombobox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 360);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oda Numaraları";
            // 
            // roomListBtn
            // 
            this.roomListBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomListBtn.ForeColor = System.Drawing.Color.Blue;
            this.roomListBtn.Location = new System.Drawing.Point(54, 304);
            this.roomListBtn.Name = "roomListBtn";
            this.roomListBtn.Size = new System.Drawing.Size(133, 42);
            this.roomListBtn.TabIndex = 9;
            this.roomListBtn.Text = "Görüntüle";
            this.roomListBtn.UseVisualStyleBackColor = true;
            this.roomListBtn.Click += new System.EventHandler(this.roomListBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(47, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 37);
            this.label6.TabIndex = 8;
            this.label6.Text = "Oda Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Oda Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Oda Tipi";
            // 
            // roomTypeCombobox
            // 
            this.roomTypeCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomTypeCombobox.FormattingEnabled = true;
            this.roomTypeCombobox.Location = new System.Drawing.Point(54, 89);
            this.roomTypeCombobox.Name = "roomTypeCombobox";
            this.roomTypeCombobox.Size = new System.Drawing.Size(121, 28);
            this.roomTypeCombobox.TabIndex = 1;
            this.roomTypeCombobox.SelectedIndexChanged += new System.EventHandler(this.roomTypeCombobox_SelectedIndexChanged);
            // 
            // roomNumberCombobox
            // 
            this.roomNumberCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomNumberCombobox.FormattingEnabled = true;
            this.roomNumberCombobox.Location = new System.Drawing.Point(54, 196);
            this.roomNumberCombobox.Name = "roomNumberCombobox";
            this.roomNumberCombobox.Size = new System.Drawing.Size(121, 28);
            this.roomNumberCombobox.TabIndex = 0;
            this.roomNumberCombobox.SelectedIndexChanged += new System.EventHandler(this.roomNumberCombobox_SelectedIndexChanged);
            // 
            // roomDeleteTxt
            // 
            this.roomDeleteTxt.Enabled = false;
            this.roomDeleteTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomDeleteTxt.Location = new System.Drawing.Point(16, 249);
            this.roomDeleteTxt.Name = "roomDeleteTxt";
            this.roomDeleteTxt.Size = new System.Drawing.Size(291, 31);
            this.roomDeleteTxt.TabIndex = 7;
            // 
            // roomDeleteBtn
            // 
            this.roomDeleteBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomDeleteBtn.ForeColor = System.Drawing.Color.Red;
            this.roomDeleteBtn.Location = new System.Drawing.Point(168, 304);
            this.roomDeleteBtn.Name = "roomDeleteBtn";
            this.roomDeleteBtn.Size = new System.Drawing.Size(101, 42);
            this.roomDeleteBtn.TabIndex = 8;
            this.roomDeleteBtn.Text = "Sil";
            this.roomDeleteBtn.UseVisualStyleBackColor = true;
            this.roomDeleteBtn.Click += new System.EventHandler(this.roomDeleteBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Silinecek Oda Numarası";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.roomChangeBtn);
            this.groupBox3.Controls.Add(this.roomChangeTxt);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.roomAddCombobox);
            this.groupBox3.Controls.Add(this.roomEmptyBtn);
            this.groupBox3.Controls.Add(this.roomDeleteBtn);
            this.groupBox3.Controls.Add(this.roomFullBtn);
            this.groupBox3.Controls.Add(this.roomLayoutTxt);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.roomDeleteTxt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.roomAddBtn);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.roomAddTxt);
            this.groupBox3.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(291, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(848, 360);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Oda İşlemleri";
            // 
            // roomChangeBtn
            // 
            this.roomChangeBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomChangeBtn.ForeColor = System.Drawing.Color.Blue;
            this.roomChangeBtn.Location = new System.Drawing.Point(569, 304);
            this.roomChangeBtn.Name = "roomChangeBtn";
            this.roomChangeBtn.Size = new System.Drawing.Size(120, 42);
            this.roomChangeBtn.TabIndex = 15;
            this.roomChangeBtn.Text = "Düzenle";
            this.roomChangeBtn.UseVisualStyleBackColor = true;
            this.roomChangeBtn.Click += new System.EventHandler(this.roomChangeBtn_Click);
            // 
            // roomChangeTxt
            // 
            this.roomChangeTxt.Enabled = false;
            this.roomChangeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomChangeTxt.Location = new System.Drawing.Point(490, 245);
            this.roomChangeTxt.Name = "roomChangeTxt";
            this.roomChangeTxt.Size = new System.Drawing.Size(291, 31);
            this.roomChangeTxt.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(483, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(331, 37);
            this.label7.TabIndex = 13;
            this.label7.Text = "Düzenlenilecek Oda Numarası";
            // 
            // roomAddCombobox
            // 
            this.roomAddCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomAddCombobox.FormattingEnabled = true;
            this.roomAddCombobox.Location = new System.Drawing.Point(305, 93);
            this.roomAddCombobox.Name = "roomAddCombobox";
            this.roomAddCombobox.Size = new System.Drawing.Size(121, 28);
            this.roomAddCombobox.TabIndex = 12;
            // 
            // roomEmptyBtn
            // 
            this.roomEmptyBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomEmptyBtn.ForeColor = System.Drawing.Color.Green;
            this.roomEmptyBtn.Location = new System.Drawing.Point(687, 131);
            this.roomEmptyBtn.Name = "roomEmptyBtn";
            this.roomEmptyBtn.Size = new System.Drawing.Size(133, 42);
            this.roomEmptyBtn.TabIndex = 9;
            this.roomEmptyBtn.Text = "Boşaltma";
            this.roomEmptyBtn.UseVisualStyleBackColor = true;
            this.roomEmptyBtn.Click += new System.EventHandler(this.roomEmptyBtn_Click);
            // 
            // roomFullBtn
            // 
            this.roomFullBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomFullBtn.ForeColor = System.Drawing.Color.Red;
            this.roomFullBtn.Location = new System.Drawing.Point(490, 128);
            this.roomFullBtn.Name = "roomFullBtn";
            this.roomFullBtn.Size = new System.Drawing.Size(134, 42);
            this.roomFullBtn.TabIndex = 8;
            this.roomFullBtn.Text = "Doldurma";
            this.roomFullBtn.UseVisualStyleBackColor = true;
            this.roomFullBtn.Click += new System.EventHandler(this.roomFullBtn_Click);
            // 
            // roomLayoutTxt
            // 
            this.roomLayoutTxt.Enabled = false;
            this.roomLayoutTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomLayoutTxt.Location = new System.Drawing.Point(508, 89);
            this.roomLayoutTxt.Name = "roomLayoutTxt";
            this.roomLayoutTxt.Size = new System.Drawing.Size(291, 31);
            this.roomLayoutTxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(501, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(319, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Düzenlenecek Oda Numarası";
            // 
            // roomAddBtn
            // 
            this.roomAddBtn.BackColor = System.Drawing.Color.White;
            this.roomAddBtn.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomAddBtn.ForeColor = System.Drawing.Color.Blue;
            this.roomAddBtn.Location = new System.Drawing.Point(190, 133);
            this.roomAddBtn.Name = "roomAddBtn";
            this.roomAddBtn.Size = new System.Drawing.Size(101, 40);
            this.roomAddBtn.TabIndex = 8;
            this.roomAddBtn.Text = "Ekle";
            this.roomAddBtn.UseVisualStyleBackColor = false;
            this.roomAddBtn.Click += new System.EventHandler(this.roomAddBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(408, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Eklenecek Oda Numarası ve Oda Tipi";
            // 
            // roomAddTxt
            // 
            this.roomAddTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomAddTxt.Location = new System.Drawing.Point(16, 89);
            this.roomAddTxt.Name = "roomAddTxt";
            this.roomAddTxt.Size = new System.Drawing.Size(221, 31);
            this.roomAddTxt.TabIndex = 7;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.customerViewBtn);
            this.groupBox5.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(12, 378);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(259, 138);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Müşteri İşlemleri";
            // 
            // customerViewBtn
            // 
            this.customerViewBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerViewBtn.ForeColor = System.Drawing.Color.Blue;
            this.customerViewBtn.Location = new System.Drawing.Point(42, 61);
            this.customerViewBtn.Name = "customerViewBtn";
            this.customerViewBtn.Size = new System.Drawing.Size(133, 42);
            this.customerViewBtn.TabIndex = 8;
            this.customerViewBtn.Text = "Görüntüle";
            this.customerViewBtn.UseVisualStyleBackColor = true;
            this.customerViewBtn.Click += new System.EventHandler(this.customerViewBtn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.adminRegisterLink);
            this.groupBox6.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(12, 522);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(259, 122);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Yönetici Kaydı";
            // 
            // adminRegisterLink
            // 
            this.adminRegisterLink.AutoSize = true;
            this.adminRegisterLink.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminRegisterLink.ForeColor = System.Drawing.SystemColors.ControlText;
            this.adminRegisterLink.LinkColor = System.Drawing.Color.Blue;
            this.adminRegisterLink.Location = new System.Drawing.Point(19, 50);
            this.adminRegisterLink.Name = "adminRegisterLink";
            this.adminRegisterLink.Size = new System.Drawing.Size(195, 37);
            this.adminRegisterLink.TabIndex = 0;
            this.adminRegisterLink.TabStop = true;
            this.adminRegisterLink.Text = "Kayıt Etmek İçin";
            this.adminRegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.adminRegisterLink_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.paymentViewBtn);
            this.groupBox2.Controls.Add(this.paymentDataGrid);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(291, 395);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 309);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fatura İşlemleri";
            // 
            // paymentViewBtn
            // 
            this.paymentViewBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paymentViewBtn.ForeColor = System.Drawing.Color.Blue;
            this.paymentViewBtn.Location = new System.Drawing.Point(305, 235);
            this.paymentViewBtn.Name = "paymentViewBtn";
            this.paymentViewBtn.Size = new System.Drawing.Size(133, 42);
            this.paymentViewBtn.TabIndex = 11;
            this.paymentViewBtn.Text = "Görüntüle";
            this.paymentViewBtn.UseVisualStyleBackColor = true;
            this.paymentViewBtn.Click += new System.EventHandler(this.paymentViewBtn_Click);
            // 
            // paymentDataGrid
            // 
            this.paymentDataGrid.AllowUserToAddRows = false;
            this.paymentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymentDataGrid.BackgroundColor = System.Drawing.Color.SlateGray;
            this.paymentDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDataGrid.Location = new System.Drawing.Point(31, 44);
            this.paymentDataGrid.MultiSelect = false;
            this.paymentDataGrid.Name = "paymentDataGrid";
            this.paymentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paymentDataGrid.Size = new System.Drawing.Size(670, 170);
            this.paymentDataGrid.TabIndex = 0;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1178, 724);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.Text = "Otel Otomasyonu";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox roomTypeCombobox;
        private System.Windows.Forms.ComboBox roomNumberCombobox;
        private System.Windows.Forms.TextBox roomDeleteTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button roomDeleteBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button roomAddBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox roomAddTxt;
        private System.Windows.Forms.Button roomEmptyBtn;
        private System.Windows.Forms.Button roomFullBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox roomLayoutTxt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button customerViewBtn;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.LinkLabel adminRegisterLink;
        private System.Windows.Forms.Button roomListBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView paymentDataGrid;
        private System.Windows.Forms.Button paymentViewBtn;
        private System.Windows.Forms.ComboBox roomAddCombobox;
        private System.Windows.Forms.Button roomChangeBtn;
        private System.Windows.Forms.TextBox roomChangeTxt;
        private System.Windows.Forms.Label label7;
    }
}