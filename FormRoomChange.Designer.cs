namespace OtelOtomasyonu
{
    partial class FormRoomChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoomChange));
            this.backBtn = new System.Windows.Forms.Button();
            this.roomIdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomChangeBtn = new System.Windows.Forms.Button();
            this.roomTypeCombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roomPriceTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backBtn.ForeColor = System.Drawing.Color.Red;
            this.backBtn.Location = new System.Drawing.Point(12, 263);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(101, 42);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Geri";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // roomIdTxt
            // 
            this.roomIdTxt.Enabled = false;
            this.roomIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomIdTxt.Location = new System.Drawing.Point(28, 106);
            this.roomIdTxt.Name = "roomIdTxt";
            this.roomIdTxt.Size = new System.Drawing.Size(139, 29);
            this.roomIdTxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Oda Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(246, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Oda Tipi";
            // 
            // roomChangeBtn
            // 
            this.roomChangeBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomChangeBtn.ForeColor = System.Drawing.Color.Blue;
            this.roomChangeBtn.Location = new System.Drawing.Point(234, 178);
            this.roomChangeBtn.Name = "roomChangeBtn";
            this.roomChangeBtn.Size = new System.Drawing.Size(120, 42);
            this.roomChangeBtn.TabIndex = 16;
            this.roomChangeBtn.Text = "Değiştir";
            this.roomChangeBtn.UseVisualStyleBackColor = true;
            this.roomChangeBtn.Click += new System.EventHandler(this.roomChangeBtn_Click);
            // 
            // roomTypeCombobox
            // 
            this.roomTypeCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomTypeCombobox.FormattingEnabled = true;
            this.roomTypeCombobox.Location = new System.Drawing.Point(233, 106);
            this.roomTypeCombobox.Name = "roomTypeCombobox";
            this.roomTypeCombobox.Size = new System.Drawing.Size(121, 32);
            this.roomTypeCombobox.TabIndex = 17;
            this.roomTypeCombobox.SelectedIndexChanged += new System.EventHandler(this.roomTypeCombobox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(412, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Oda Fiyatı";
            // 
            // roomPriceTxt
            // 
            this.roomPriceTxt.Enabled = false;
            this.roomPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomPriceTxt.Location = new System.Drawing.Point(405, 106);
            this.roomPriceTxt.Name = "roomPriceTxt";
            this.roomPriceTxt.Size = new System.Drawing.Size(139, 29);
            this.roomPriceTxt.TabIndex = 19;
            // 
            // FormRoomChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(613, 317);
            this.Controls.Add(this.roomPriceTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roomTypeCombobox);
            this.Controls.Add(this.roomChangeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomIdTxt);
            this.Controls.Add(this.backBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRoomChange";
            this.Text = "Otel Otomasyonu";
            this.Load += new System.EventHandler(this.FormRoomChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox roomIdTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button roomChangeBtn;
        private System.Windows.Forms.ComboBox roomTypeCombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roomPriceTxt;
    }
}