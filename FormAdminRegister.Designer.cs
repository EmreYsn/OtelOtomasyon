namespace OtelOtomasyonu
{
    partial class FormAdminRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminRegister));
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordAgainTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adminSurnameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adminNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adminRegisterBtn = new System.Windows.Forms.Button();
            this.adminPasswordTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adminNicknameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backBtn.ForeColor = System.Drawing.Color.Red;
            this.backBtn.Location = new System.Drawing.Point(12, 491);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(101, 42);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Geri";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordAgainTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.adminSurnameTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.adminNameTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.adminRegisterBtn);
            this.groupBox1.Controls.Add(this.adminPasswordTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.adminNicknameTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 445);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yönetici Kayıt İşlemleri";
            // 
            // passwordAgainTxt
            // 
            this.passwordAgainTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordAgainTxt.Location = new System.Drawing.Point(227, 311);
            this.passwordAgainTxt.Name = "passwordAgainTxt";
            this.passwordAgainTxt.Size = new System.Drawing.Size(398, 31);
            this.passwordAgainTxt.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(21, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "Şifre Tekrarı :";
            // 
            // adminSurnameTxt
            // 
            this.adminSurnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminSurnameTxt.Location = new System.Drawing.Point(227, 129);
            this.adminSurnameTxt.Name = "adminSurnameTxt";
            this.adminSurnameTxt.Size = new System.Drawing.Size(398, 31);
            this.adminSurnameTxt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(106, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Şifre :";
            // 
            // adminNameTxt
            // 
            this.adminNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminNameTxt.Location = new System.Drawing.Point(227, 70);
            this.adminNameTxt.Name = "adminNameTxt";
            this.adminNameTxt.Size = new System.Drawing.Size(398, 31);
            this.adminNameTxt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // adminRegisterBtn
            // 
            this.adminRegisterBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminRegisterBtn.ForeColor = System.Drawing.Color.Blue;
            this.adminRegisterBtn.Location = new System.Drawing.Point(259, 375);
            this.adminRegisterBtn.Name = "adminRegisterBtn";
            this.adminRegisterBtn.Size = new System.Drawing.Size(125, 43);
            this.adminRegisterBtn.TabIndex = 9;
            this.adminRegisterBtn.Text = "Kayıt Et";
            this.adminRegisterBtn.UseVisualStyleBackColor = true;
            this.adminRegisterBtn.Click += new System.EventHandler(this.adminRegisterBtn_Click);
            // 
            // adminPasswordTxt
            // 
            this.adminPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminPasswordTxt.Location = new System.Drawing.Point(227, 254);
            this.adminPasswordTxt.Name = "adminPasswordTxt";
            this.adminPasswordTxt.Size = new System.Drawing.Size(398, 31);
            this.adminPasswordTxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(86, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Soyadı :";
            // 
            // adminNicknameTxt
            // 
            this.adminNicknameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminNicknameTxt.Location = new System.Drawing.Point(227, 196);
            this.adminNicknameTxt.Name = "adminNicknameTxt";
            this.adminNicknameTxt.Size = new System.Drawing.Size(398, 31);
            this.adminNicknameTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(119, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adı :";
            // 
            // FormAdminRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(715, 545);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAdminRegister";
            this.Text = "Otel Otomasyonu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button adminRegisterBtn;
        private System.Windows.Forms.TextBox adminPasswordTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adminNicknameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adminSurnameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordAgainTxt;
        private System.Windows.Forms.Label label5;
    }
}