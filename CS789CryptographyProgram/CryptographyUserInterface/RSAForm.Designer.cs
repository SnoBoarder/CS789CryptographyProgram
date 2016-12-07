namespace CryptographyUserInterface
{
    partial class RSAForm
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
            this._encryptSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this._encryptOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._encryptMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._encryptBobEncryption = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._encryptPrime = new System.Windows.Forms.TextBox();
            this._label = new System.Windows.Forms.Label();
            this._decryptSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this._decryptOutput = new System.Windows.Forms.TextBox();
            this._decryptEncryptedMessage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._decryptBobQ = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this._decryptBobP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this._decryptBobEncryption = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this._decryptPrime = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this._hackSubmit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this._hackOutput = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this._hackEncryptedMessage = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this._hackBobsEncryption = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this._hackPrime = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _encryptSubmit
            // 
            this._encryptSubmit.Location = new System.Drawing.Point(18, 180);
            this._encryptSubmit.Name = "_encryptSubmit";
            this._encryptSubmit.Size = new System.Drawing.Size(198, 37);
            this._encryptSubmit.TabIndex = 6;
            this._encryptSubmit.Text = "Submit";
            this._encryptSubmit.UseVisualStyleBackColor = true;
            this._encryptSubmit.Click += new System.EventHandler(this.OnEncryptSubmitClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Output:";
            // 
            // _encryptOutput
            // 
            this._encryptOutput.Location = new System.Drawing.Point(18, 246);
            this._encryptOutput.Multiline = true;
            this._encryptOutput.Name = "_encryptOutput";
            this._encryptOutput.ReadOnly = true;
            this._encryptOutput.Size = new System.Drawing.Size(198, 64);
            this._encryptOutput.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 29);
            this.label4.TabIndex = 39;
            this.label4.Text = "Encrypt (As Alice)";
            // 
            // _encryptMessage
            // 
            this._encryptMessage.Location = new System.Drawing.Point(116, 102);
            this._encryptMessage.Name = "_encryptMessage";
            this._encryptMessage.Size = new System.Drawing.Size(100, 20);
            this._encryptMessage.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Message:";
            // 
            // _encryptBobEncryption
            // 
            this._encryptBobEncryption.Location = new System.Drawing.Point(116, 76);
            this._encryptBobEncryption.Name = "_encryptBobEncryption";
            this._encryptBobEncryption.Size = new System.Drawing.Size(100, 20);
            this._encryptBobEncryption.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Bob\'s Encryption:";
            // 
            // _encryptPrime
            // 
            this._encryptPrime.Location = new System.Drawing.Point(116, 50);
            this._encryptPrime.Name = "_encryptPrime";
            this._encryptPrime.Size = new System.Drawing.Size(100, 20);
            this._encryptPrime.TabIndex = 1;
            // 
            // _label
            // 
            this._label.AutoSize = true;
            this._label.Location = new System.Drawing.Point(15, 54);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(65, 13);
            this._label.TabIndex = 35;
            this._label.Text = "Bob\'s Prime:";
            // 
            // _decryptSubmit
            // 
            this._decryptSubmit.Location = new System.Drawing.Point(242, 180);
            this._decryptSubmit.Name = "_decryptSubmit";
            this._decryptSubmit.Size = new System.Drawing.Size(198, 37);
            this._decryptSubmit.TabIndex = 12;
            this._decryptSubmit.Text = "Submit";
            this._decryptSubmit.UseVisualStyleBackColor = true;
            this._decryptSubmit.Click += new System.EventHandler(this.OnDecryptSubmitClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "Output:";
            // 
            // _decryptOutput
            // 
            this._decryptOutput.Location = new System.Drawing.Point(242, 246);
            this._decryptOutput.Multiline = true;
            this._decryptOutput.Name = "_decryptOutput";
            this._decryptOutput.ReadOnly = true;
            this._decryptOutput.Size = new System.Drawing.Size(198, 64);
            this._decryptOutput.TabIndex = 68;
            // 
            // _decryptEncryptedMessage
            // 
            this._decryptEncryptedMessage.Location = new System.Drawing.Point(340, 154);
            this._decryptEncryptedMessage.Name = "_decryptEncryptedMessage";
            this._decryptEncryptedMessage.Size = new System.Drawing.Size(100, 20);
            this._decryptEncryptedMessage.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Encrypted Message:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(249, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 29);
            this.label9.TabIndex = 66;
            this.label9.Text = "Decrypt (As Bob)";
            // 
            // _decryptBobQ
            // 
            this._decryptBobQ.Location = new System.Drawing.Point(340, 128);
            this._decryptBobQ.Name = "_decryptBobQ";
            this._decryptBobQ.Size = new System.Drawing.Size(100, 20);
            this._decryptBobQ.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Bob\'s Q:";
            // 
            // _decryptBobP
            // 
            this._decryptBobP.Location = new System.Drawing.Point(340, 102);
            this._decryptBobP.Name = "_decryptBobP";
            this._decryptBobP.Size = new System.Drawing.Size(100, 20);
            this._decryptBobP.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 64;
            this.label11.Text = "Bob\'s P:";
            // 
            // _decryptBobEncryption
            // 
            this._decryptBobEncryption.Location = new System.Drawing.Point(340, 76);
            this._decryptBobEncryption.Name = "_decryptBobEncryption";
            this._decryptBobEncryption.Size = new System.Drawing.Size(100, 20);
            this._decryptBobEncryption.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(239, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 63;
            this.label12.Text = "Bob\'s Encryption:";
            // 
            // _decryptPrime
            // 
            this._decryptPrime.Location = new System.Drawing.Point(340, 50);
            this._decryptPrime.Name = "_decryptPrime";
            this._decryptPrime.Size = new System.Drawing.Size(100, 20);
            this._decryptPrime.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(239, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 62;
            this.label13.Text = "Bob\'s Prime:";
            // 
            // _hackSubmit
            // 
            this._hackSubmit.Location = new System.Drawing.Point(464, 180);
            this._hackSubmit.Name = "_hackSubmit";
            this._hackSubmit.Size = new System.Drawing.Size(198, 37);
            this._hackSubmit.TabIndex = 18;
            this._hackSubmit.Text = "Submit";
            this._hackSubmit.UseVisualStyleBackColor = true;
            this._hackSubmit.Click += new System.EventHandler(this.OnHackSubmitClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(461, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 83;
            this.label14.Text = "Output:";
            // 
            // _hackOutput
            // 
            this._hackOutput.Location = new System.Drawing.Point(464, 246);
            this._hackOutput.Multiline = true;
            this._hackOutput.Name = "_hackOutput";
            this._hackOutput.ReadOnly = true;
            this._hackOutput.Size = new System.Drawing.Size(198, 64);
            this._hackOutput.TabIndex = 82;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(488, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 29);
            this.label16.TabIndex = 80;
            this.label16.Text = "Hack (As Eve)";
            // 
            // _hackEncryptedMessage
            // 
            this._hackEncryptedMessage.Location = new System.Drawing.Point(562, 102);
            this._hackEncryptedMessage.Name = "_hackEncryptedMessage";
            this._hackEncryptedMessage.Size = new System.Drawing.Size(100, 20);
            this._hackEncryptedMessage.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(461, 106);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 13);
            this.label18.TabIndex = 78;
            this.label18.Text = "Encrypted Message:";
            // 
            // _hackBobsEncryption
            // 
            this._hackBobsEncryption.Location = new System.Drawing.Point(562, 76);
            this._hackBobsEncryption.Name = "_hackBobsEncryption";
            this._hackBobsEncryption.Size = new System.Drawing.Size(100, 20);
            this._hackBobsEncryption.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(461, 80);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 13);
            this.label19.TabIndex = 77;
            this.label19.Text = "Bob\'s Encryption:";
            // 
            // _hackPrime
            // 
            this._hackPrime.Location = new System.Drawing.Point(562, 50);
            this._hackPrime.Name = "_hackPrime";
            this._hackPrime.Size = new System.Drawing.Size(100, 20);
            this._hackPrime.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(461, 54);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 76;
            this.label20.Text = "Bob\'s Prime:";
            // 
            // RSAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 326);
            this.Controls.Add(this._hackSubmit);
            this.Controls.Add(this.label14);
            this.Controls.Add(this._hackOutput);
            this.Controls.Add(this.label16);
            this.Controls.Add(this._hackEncryptedMessage);
            this.Controls.Add(this.label18);
            this.Controls.Add(this._hackBobsEncryption);
            this.Controls.Add(this.label19);
            this.Controls.Add(this._hackPrime);
            this.Controls.Add(this.label20);
            this.Controls.Add(this._decryptSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._decryptOutput);
            this.Controls.Add(this._decryptEncryptedMessage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._decryptBobQ);
            this.Controls.Add(this.label10);
            this.Controls.Add(this._decryptBobP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this._decryptBobEncryption);
            this.Controls.Add(this.label12);
            this.Controls.Add(this._decryptPrime);
            this.Controls.Add(this.label13);
            this.Controls.Add(this._encryptSubmit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._encryptOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._encryptMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._encryptBobEncryption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._encryptPrime);
            this.Controls.Add(this._label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RSAForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RSAForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _encryptSubmit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _encryptOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _encryptMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _encryptBobEncryption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _encryptPrime;
        private System.Windows.Forms.Label _label;
        private System.Windows.Forms.Button _decryptSubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _decryptOutput;
        private System.Windows.Forms.TextBox _decryptEncryptedMessage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _decryptBobQ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox _decryptBobP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox _decryptBobEncryption;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox _decryptPrime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button _hackSubmit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox _hackOutput;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox _hackEncryptedMessage;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox _hackBobsEncryption;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox _hackPrime;
        private System.Windows.Forms.Label label20;
    }
}