namespace AES_Encryption
{
    partial class Form_Main
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
            this.label9 = new System.Windows.Forms.Label();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.btn_decryption = new System.Windows.Forms.Button();
            this.btn_encription = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_plaintext = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.radioBtn_CFB = new System.Windows.Forms.RadioButton();
            this.radioBtn_CBC = new System.Windows.Forms.RadioButton();
            this.radioBtn_ECB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Put Your Key Here: (16 characters)";
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(12, 440);
            this.txt_key.Name = "txt_key";
            this.txt_key.PasswordChar = '•';
            this.txt_key.Size = new System.Drawing.Size(416, 20);
            this.txt_key.TabIndex = 41;
            // 
            // btn_decryption
            // 
            this.btn_decryption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decryption.Location = new System.Drawing.Point(164, 466);
            this.btn_decryption.Name = "btn_decryption";
            this.btn_decryption.Size = new System.Drawing.Size(134, 66);
            this.btn_decryption.TabIndex = 40;
            this.btn_decryption.Text = "Decryption";
            this.btn_decryption.UseVisualStyleBackColor = true;
            this.btn_decryption.Click += new System.EventHandler(this.btn_decryption_Click);
            // 
            // btn_encription
            // 
            this.btn_encription.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encription.Location = new System.Drawing.Point(12, 466);
            this.btn_encription.Name = "btn_encription";
            this.btn_encription.Size = new System.Drawing.Size(136, 66);
            this.btn_encription.TabIndex = 39;
            this.btn_encription.Text = "Encription";
            this.btn_encription.UseVisualStyleBackColor = true;
            this.btn_encription.Click += new System.EventHandler(this.btn_encription_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 25);
            this.label7.TabIndex = 38;
            this.label7.Text = "Put Your Text Here";
            // 
            // txt_plaintext
            // 
            this.txt_plaintext.Location = new System.Drawing.Point(12, 138);
            this.txt_plaintext.Multiline = true;
            this.txt_plaintext.Name = "txt_plaintext";
            this.txt_plaintext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_plaintext.Size = new System.Drawing.Size(416, 273);
            this.txt_plaintext.TabIndex = 37;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(314, 466);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(114, 66);
            this.btn_clear.TabIndex = 36;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // radioBtn_CFB
            // 
            this.radioBtn_CFB.AutoSize = true;
            this.radioBtn_CFB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_CFB.Location = new System.Drawing.Point(202, 44);
            this.radioBtn_CFB.Name = "radioBtn_CFB";
            this.radioBtn_CFB.Size = new System.Drawing.Size(64, 25);
            this.radioBtn_CFB.TabIndex = 14;
            this.radioBtn_CFB.TabStop = true;
            this.radioBtn_CFB.Text = "CFB";
            this.radioBtn_CFB.UseVisualStyleBackColor = true;
            // 
            // radioBtn_CBC
            // 
            this.radioBtn_CBC.AutoSize = true;
            this.radioBtn_CBC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_CBC.Location = new System.Drawing.Point(108, 44);
            this.radioBtn_CBC.Name = "radioBtn_CBC";
            this.radioBtn_CBC.Size = new System.Drawing.Size(66, 25);
            this.radioBtn_CBC.TabIndex = 13;
            this.radioBtn_CBC.TabStop = true;
            this.radioBtn_CBC.Text = "CBC";
            this.radioBtn_CBC.UseVisualStyleBackColor = true;
            // 
            // radioBtn_ECB
            // 
            this.radioBtn_ECB.AutoSize = true;
            this.radioBtn_ECB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_ECB.Location = new System.Drawing.Point(16, 44);
            this.radioBtn_ECB.Name = "radioBtn_ECB";
            this.radioBtn_ECB.Size = new System.Drawing.Size(64, 25);
            this.radioBtn_ECB.TabIndex = 12;
            this.radioBtn_ECB.TabStop = true;
            this.radioBtn_ECB.Text = "ECB";
            this.radioBtn_ECB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtn_ECB);
            this.groupBox1.Controls.Add(this.radioBtn_CBC);
            this.groupBox1.Controls.Add(this.radioBtn_CFB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 88);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chose Your AES Cipher Type";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 547);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.btn_decryption);
            this.Controls.Add(this.btn_encription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_plaintext);
            this.Controls.Add(this.btn_clear);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AES_Encryption";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Button btn_decryption;
        private System.Windows.Forms.Button btn_encription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_plaintext;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.RadioButton radioBtn_CFB;
        private System.Windows.Forms.RadioButton radioBtn_CBC;
        private System.Windows.Forms.RadioButton radioBtn_ECB;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

