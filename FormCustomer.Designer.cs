namespace OtelOtomasyonu
{
    partial class FormCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reservationDeleteBtn = new System.Windows.Forms.Button();
            this.reservationDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerChangeBtn = new System.Windows.Forms.Button();
            this.reservationLink = new System.Windows.Forms.LinkLabel();
            this.customerRegisterBtn = new System.Windows.Forms.Button();
            this.customerDeleteBtn = new System.Windows.Forms.Button();
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backBtn.ForeColor = System.Drawing.Color.Red;
            this.backBtn.Location = new System.Drawing.Point(12, 396);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(101, 42);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "Geri";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reservationDeleteBtn);
            this.groupBox2.Controls.Add(this.reservationDataGrid);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 360);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rezarvasyon Kayıtları";
            // 
            // reservationDeleteBtn
            // 
            this.reservationDeleteBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reservationDeleteBtn.ForeColor = System.Drawing.Color.Red;
            this.reservationDeleteBtn.Location = new System.Drawing.Point(277, 300);
            this.reservationDeleteBtn.Name = "reservationDeleteBtn";
            this.reservationDeleteBtn.Size = new System.Drawing.Size(101, 42);
            this.reservationDeleteBtn.TabIndex = 6;
            this.reservationDeleteBtn.Text = "Sil";
            this.reservationDeleteBtn.UseVisualStyleBackColor = true;
            this.reservationDeleteBtn.Click += new System.EventHandler(this.reservationDeleteBtn_Click);
            // 
            // reservationDataGrid
            // 
            this.reservationDataGrid.AllowUserToAddRows = false;
            this.reservationDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reservationDataGrid.BackgroundColor = System.Drawing.Color.SlateGray;
            this.reservationDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationDataGrid.Location = new System.Drawing.Point(20, 106);
            this.reservationDataGrid.MultiSelect = false;
            this.reservationDataGrid.Name = "reservationDataGrid";
            this.reservationDataGrid.ReadOnly = true;
            this.reservationDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservationDataGrid.Size = new System.Drawing.Size(635, 188);
            this.reservationDataGrid.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Düzenlemek İstediğiniz Kaydı Seçin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customerChangeBtn);
            this.groupBox1.Controls.Add(this.reservationLink);
            this.groupBox1.Controls.Add(this.customerRegisterBtn);
            this.groupBox1.Controls.Add(this.customerDeleteBtn);
            this.groupBox1.Controls.Add(this.customerDataGrid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(714, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 410);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Kayıtları";
            // 
            // customerChangeBtn
            // 
            this.customerChangeBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerChangeBtn.ForeColor = System.Drawing.Color.Blue;
            this.customerChangeBtn.Location = new System.Drawing.Point(418, 300);
            this.customerChangeBtn.Name = "customerChangeBtn";
            this.customerChangeBtn.Size = new System.Drawing.Size(119, 42);
            this.customerChangeBtn.TabIndex = 11;
            this.customerChangeBtn.Text = "Düzenle";
            this.customerChangeBtn.UseVisualStyleBackColor = true;
            this.customerChangeBtn.Click += new System.EventHandler(this.customerChangeBtn_Click);
            // 
            // reservationLink
            // 
            this.reservationLink.AutoSize = true;
            this.reservationLink.Location = new System.Drawing.Point(156, 364);
            this.reservationLink.Name = "reservationLink";
            this.reservationLink.Size = new System.Drawing.Size(319, 25);
            this.reservationLink.TabIndex = 10;
            this.reservationLink.TabStop = true;
            this.reservationLink.Text = "Rezervasyon Oluşturmak İçin";
            this.reservationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reservationLink_LinkClicked);
            // 
            // customerRegisterBtn
            // 
            this.customerRegisterBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerRegisterBtn.ForeColor = System.Drawing.Color.Green;
            this.customerRegisterBtn.Location = new System.Drawing.Point(68, 300);
            this.customerRegisterBtn.Name = "customerRegisterBtn";
            this.customerRegisterBtn.Size = new System.Drawing.Size(101, 42);
            this.customerRegisterBtn.TabIndex = 9;
            this.customerRegisterBtn.Text = "Kayıt";
            this.customerRegisterBtn.UseVisualStyleBackColor = true;
            this.customerRegisterBtn.Click += new System.EventHandler(this.customerRegisterBtn_Click);
            // 
            // customerDeleteBtn
            // 
            this.customerDeleteBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerDeleteBtn.ForeColor = System.Drawing.Color.Red;
            this.customerDeleteBtn.Location = new System.Drawing.Point(246, 300);
            this.customerDeleteBtn.Name = "customerDeleteBtn";
            this.customerDeleteBtn.Size = new System.Drawing.Size(101, 42);
            this.customerDeleteBtn.TabIndex = 7;
            this.customerDeleteBtn.Text = "Sil";
            this.customerDeleteBtn.UseVisualStyleBackColor = true;
            this.customerDeleteBtn.Click += new System.EventHandler(this.customerDeleteBtn_Click);
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.AllowUserToAddRows = false;
            this.customerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGrid.BackgroundColor = System.Drawing.Color.SlateGray;
            this.customerDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid.Location = new System.Drawing.Point(20, 87);
            this.customerDataGrid.MultiSelect = false;
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.ReadOnly = true;
            this.customerDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGrid.Size = new System.Drawing.Size(563, 188);
            this.customerDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Düzenlemek İstediğiniz Kaydı Seçin";
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1315, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.backBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCustomer";
            this.Text = "Otel Otomasyonu";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView reservationDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView customerDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reservationDeleteBtn;
        private System.Windows.Forms.Button customerDeleteBtn;
        private System.Windows.Forms.Button customerRegisterBtn;
        private System.Windows.Forms.LinkLabel reservationLink;
        private System.Windows.Forms.Button customerChangeBtn;
    }
}