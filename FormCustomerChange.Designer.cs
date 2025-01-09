namespace OtelOtomasyonu
{
    partial class FormCustomerChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomerChange));
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.customerChangeBtn = new System.Windows.Forms.Button();
            this.phoneNumberTxt = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backBtn.ForeColor = System.Drawing.Color.Red;
            this.backBtn.Location = new System.Drawing.Point(12, 271);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(101, 42);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Geri";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(70, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Müşteri Adı ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(267, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Müşteri Soyadı ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(479, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Müşteri Telefon Numarası";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTxt.Location = new System.Drawing.Point(47, 173);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(144, 29);
            this.nameTxt.TabIndex = 10;
            // 
            // surnameTxt
            // 
            this.surnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameTxt.Location = new System.Drawing.Point(271, 173);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(144, 29);
            this.surnameTxt.TabIndex = 11;
            // 
            // customerChangeBtn
            // 
            this.customerChangeBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerChangeBtn.ForeColor = System.Drawing.Color.Blue;
            this.customerChangeBtn.Location = new System.Drawing.Point(286, 227);
            this.customerChangeBtn.Name = "customerChangeBtn";
            this.customerChangeBtn.Size = new System.Drawing.Size(114, 42);
            this.customerChangeBtn.TabIndex = 13;
            this.customerChangeBtn.Text = "Düzenle";
            this.customerChangeBtn.UseVisualStyleBackColor = true;
            this.customerChangeBtn.Click += new System.EventHandler(this.customerChangeBtn_Click);
            // 
            // phoneNumberTxt
            // 
            this.phoneNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneNumberTxt.Location = new System.Drawing.Point(483, 173);
            this.phoneNumberTxt.Mask = "(999) 000-0000";
            this.phoneNumberTxt.Name = "phoneNumberTxt";
            this.phoneNumberTxt.Size = new System.Drawing.Size(245, 29);
            this.phoneNumberTxt.TabIndex = 14;
            // 
            // FormCustomerChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 334);
            this.Controls.Add(this.phoneNumberTxt);
            this.Controls.Add(this.customerChangeBtn);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCustomerChange";
            this.Text = "Otel Otomasyonu";
            this.Load += new System.EventHandler(this.FormCustomerChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.Button customerChangeBtn;
        private System.Windows.Forms.MaskedTextBox phoneNumberTxt;
    }
}