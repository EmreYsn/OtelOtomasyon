namespace OtelOtomasyonu
{
    partial class FormAdminEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminEntry));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.entryBtn = new System.Windows.Forms.Button();
            this.adminPasswordTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adminEntryTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.entryBtn);
            this.groupBox1.Controls.Add(this.adminPasswordTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.adminEntryTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 316);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yönetici Giriş İşlemleri";
            // 
            // entryBtn
            // 
            this.entryBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.entryBtn.ForeColor = System.Drawing.Color.Blue;
            this.entryBtn.Location = new System.Drawing.Point(256, 211);
            this.entryBtn.Name = "entryBtn";
            this.entryBtn.Size = new System.Drawing.Size(125, 43);
            this.entryBtn.TabIndex = 9;
            this.entryBtn.Text = "Giriş Yap";
            this.entryBtn.UseVisualStyleBackColor = true;
            this.entryBtn.Click += new System.EventHandler(this.entryBtn_Click);
            // 
            // adminPasswordTxt
            // 
            this.adminPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminPasswordTxt.Location = new System.Drawing.Point(242, 135);
            this.adminPasswordTxt.Name = "adminPasswordTxt";
            this.adminPasswordTxt.Size = new System.Drawing.Size(398, 31);
            this.adminPasswordTxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(151, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifre :";
            // 
            // adminEntryTxt
            // 
            this.adminEntryTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminEntryTxt.Location = new System.Drawing.Point(242, 70);
            this.adminEntryTxt.Name = "adminEntryTxt";
            this.adminEntryTxt.Size = new System.Drawing.Size(398, 31);
            this.adminEntryTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(66, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kullanıcı Adı :";
            // 
            // FormAdminEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(698, 348);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAdminEntry";
            this.Text = "Otel Otomasyonu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button entryBtn;
        private System.Windows.Forms.TextBox adminPasswordTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adminEntryTxt;
        private System.Windows.Forms.Label label3;
    }
}