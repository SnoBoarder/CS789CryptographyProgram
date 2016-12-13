namespace CryptographyUserInterface
{
    partial class DiffieHelmanForm
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
			this._encryptMessage = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this._encryptBobPublic = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this._encryptAlicePrivate = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this._encryptGenerator = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this._encryptPrime = new System.Windows.Forms.TextBox();
			this._label = new System.Windows.Forms.Label();
			this._decryptSubmit = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this._decryptOutput = new System.Windows.Forms.TextBox();
			this._decryptEncryptedMessage = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this._decryptAlicePublic = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this._decryptBobPrivate = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this._decryptGenerator = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this._decryptPrime = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this._hackSubmit = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this._hackOutput = new System.Windows.Forms.TextBox();
			this._hackEncryptedMessage = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this._hackBobPublic = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this._hackAlicePublic = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this._hackGenerator = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this._hackPrime = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this._generate = new System.Windows.Forms.Button();
			this.label21 = new System.Windows.Forms.Label();
			this._generateOutput = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this._generateBitCount = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _encryptSubmit
			// 
			this._encryptSubmit.Location = new System.Drawing.Point(233, 180);
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
			this.label6.Location = new System.Drawing.Point(224, 224);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 13);
			this.label6.TabIndex = 42;
			this.label6.Text = "Output:";
			// 
			// _encryptOutput
			// 
			this._encryptOutput.Location = new System.Drawing.Point(233, 246);
			this._encryptOutput.Multiline = true;
			this._encryptOutput.Name = "_encryptOutput";
			this._encryptOutput.ReadOnly = true;
			this._encryptOutput.Size = new System.Drawing.Size(198, 64);
			this._encryptOutput.TabIndex = 41;
			// 
			// _encryptMessage
			// 
			this._encryptMessage.Location = new System.Drawing.Point(331, 154);
			this._encryptMessage.Name = "_encryptMessage";
			this._encryptMessage.Size = new System.Drawing.Size(100, 20);
			this._encryptMessage.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(230, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 13);
			this.label5.TabIndex = 40;
			this.label5.Text = "Plain Message (int):";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(231, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(201, 29);
			this.label4.TabIndex = 39;
			this.label4.Text = "Encrypt (As Alice)";
			// 
			// _encryptBobPublic
			// 
			this._encryptBobPublic.Location = new System.Drawing.Point(331, 128);
			this._encryptBobPublic.Name = "_encryptBobPublic";
			this._encryptBobPublic.Size = new System.Drawing.Size(100, 20);
			this._encryptBobPublic.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(230, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 13);
			this.label3.TabIndex = 38;
			this.label3.Text = "Bob\'s Public Key:";
			// 
			// _encryptAlicePrivate
			// 
			this._encryptAlicePrivate.Location = new System.Drawing.Point(331, 102);
			this._encryptAlicePrivate.Name = "_encryptAlicePrivate";
			this._encryptAlicePrivate.Size = new System.Drawing.Size(100, 20);
			this._encryptAlicePrivate.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(230, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 13);
			this.label2.TabIndex = 37;
			this.label2.Text = "Alice\'s Private Key:";
			// 
			// _encryptGenerator
			// 
			this._encryptGenerator.Location = new System.Drawing.Point(331, 76);
			this._encryptGenerator.Name = "_encryptGenerator";
			this._encryptGenerator.Size = new System.Drawing.Size(100, 20);
			this._encryptGenerator.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(230, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 36;
			this.label1.Text = "Generator:";
			// 
			// _encryptPrime
			// 
			this._encryptPrime.Location = new System.Drawing.Point(331, 50);
			this._encryptPrime.Name = "_encryptPrime";
			this._encryptPrime.Size = new System.Drawing.Size(100, 20);
			this._encryptPrime.TabIndex = 1;
			// 
			// _label
			// 
			this._label.AutoSize = true;
			this._label.Location = new System.Drawing.Point(230, 54);
			this._label.Name = "_label";
			this._label.Size = new System.Drawing.Size(36, 13);
			this._label.TabIndex = 35;
			this._label.Text = "Prime:";
			// 
			// _decryptSubmit
			// 
			this._decryptSubmit.Location = new System.Drawing.Point(457, 180);
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
			this.label7.Location = new System.Drawing.Point(454, 224);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(42, 13);
			this.label7.TabIndex = 69;
			this.label7.Text = "Output:";
			// 
			// _decryptOutput
			// 
			this._decryptOutput.Location = new System.Drawing.Point(457, 246);
			this._decryptOutput.Multiline = true;
			this._decryptOutput.Name = "_decryptOutput";
			this._decryptOutput.ReadOnly = true;
			this._decryptOutput.Size = new System.Drawing.Size(198, 64);
			this._decryptOutput.TabIndex = 68;
			// 
			// _decryptEncryptedMessage
			// 
			this._decryptEncryptedMessage.Location = new System.Drawing.Point(555, 154);
			this._decryptEncryptedMessage.Name = "_decryptEncryptedMessage";
			this._decryptEncryptedMessage.Size = new System.Drawing.Size(100, 20);
			this._decryptEncryptedMessage.TabIndex = 11;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(454, 158);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(104, 13);
			this.label8.TabIndex = 67;
			this.label8.Text = "Encrypted Message:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(459, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(194, 29);
			this.label9.TabIndex = 66;
			this.label9.Text = "Decrypt (As Bob)";
			// 
			// _decryptAlicePublic
			// 
			this._decryptAlicePublic.Location = new System.Drawing.Point(555, 128);
			this._decryptAlicePublic.Name = "_decryptAlicePublic";
			this._decryptAlicePublic.Size = new System.Drawing.Size(100, 20);
			this._decryptAlicePublic.TabIndex = 10;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(454, 132);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(93, 13);
			this.label10.TabIndex = 65;
			this.label10.Text = "Alice\'s Public Key:";
			// 
			// _decryptBobPrivate
			// 
			this._decryptBobPrivate.Location = new System.Drawing.Point(555, 102);
			this._decryptBobPrivate.Name = "_decryptBobPrivate";
			this._decryptBobPrivate.Size = new System.Drawing.Size(100, 20);
			this._decryptBobPrivate.TabIndex = 9;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(454, 106);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(93, 13);
			this.label11.TabIndex = 64;
			this.label11.Text = "Bob\'s Private Key:";
			// 
			// _decryptGenerator
			// 
			this._decryptGenerator.Location = new System.Drawing.Point(555, 76);
			this._decryptGenerator.Name = "_decryptGenerator";
			this._decryptGenerator.Size = new System.Drawing.Size(100, 20);
			this._decryptGenerator.TabIndex = 8;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(454, 80);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(57, 13);
			this.label12.TabIndex = 63;
			this.label12.Text = "Generator:";
			// 
			// _decryptPrime
			// 
			this._decryptPrime.Location = new System.Drawing.Point(555, 50);
			this._decryptPrime.Name = "_decryptPrime";
			this._decryptPrime.Size = new System.Drawing.Size(100, 20);
			this._decryptPrime.TabIndex = 7;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(454, 54);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(36, 13);
			this.label13.TabIndex = 62;
			this.label13.Text = "Prime:";
			// 
			// _hackSubmit
			// 
			this._hackSubmit.Location = new System.Drawing.Point(679, 180);
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
			this.label14.Location = new System.Drawing.Point(676, 224);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(42, 13);
			this.label14.TabIndex = 83;
			this.label14.Text = "Output:";
			// 
			// _hackOutput
			// 
			this._hackOutput.Location = new System.Drawing.Point(679, 246);
			this._hackOutput.Multiline = true;
			this._hackOutput.Name = "_hackOutput";
			this._hackOutput.ReadOnly = true;
			this._hackOutput.Size = new System.Drawing.Size(198, 64);
			this._hackOutput.TabIndex = 82;
			// 
			// _hackEncryptedMessage
			// 
			this._hackEncryptedMessage.Location = new System.Drawing.Point(777, 154);
			this._hackEncryptedMessage.Name = "_hackEncryptedMessage";
			this._hackEncryptedMessage.Size = new System.Drawing.Size(100, 20);
			this._hackEncryptedMessage.TabIndex = 17;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(676, 158);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(104, 13);
			this.label15.TabIndex = 81;
			this.label15.Text = "Encrypted Message:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(700, 9);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(163, 29);
			this.label16.TabIndex = 80;
			this.label16.Text = "Hack (As Eve)";
			// 
			// _hackBobPublic
			// 
			this._hackBobPublic.Location = new System.Drawing.Point(777, 128);
			this._hackBobPublic.Name = "_hackBobPublic";
			this._hackBobPublic.Size = new System.Drawing.Size(100, 20);
			this._hackBobPublic.TabIndex = 16;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(676, 132);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(89, 13);
			this.label17.TabIndex = 79;
			this.label17.Text = "Bob\'s Public Key:";
			// 
			// _hackAlicePublic
			// 
			this._hackAlicePublic.Location = new System.Drawing.Point(777, 102);
			this._hackAlicePublic.Name = "_hackAlicePublic";
			this._hackAlicePublic.Size = new System.Drawing.Size(100, 20);
			this._hackAlicePublic.TabIndex = 15;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(676, 106);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(93, 13);
			this.label18.TabIndex = 78;
			this.label18.Text = "Alice\'s Public Key:";
			// 
			// _hackGenerator
			// 
			this._hackGenerator.Location = new System.Drawing.Point(777, 76);
			this._hackGenerator.Name = "_hackGenerator";
			this._hackGenerator.Size = new System.Drawing.Size(100, 20);
			this._hackGenerator.TabIndex = 14;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(676, 80);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(57, 13);
			this.label19.TabIndex = 77;
			this.label19.Text = "Generator:";
			// 
			// _hackPrime
			// 
			this._hackPrime.Location = new System.Drawing.Point(777, 50);
			this._hackPrime.Name = "_hackPrime";
			this._hackPrime.Size = new System.Drawing.Size(100, 20);
			this._hackPrime.TabIndex = 13;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(676, 54);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(36, 13);
			this.label20.TabIndex = 76;
			this.label20.Text = "Prime:";
			// 
			// _generate
			// 
			this._generate.Location = new System.Drawing.Point(14, 180);
			this._generate.Name = "_generate";
			this._generate.Size = new System.Drawing.Size(198, 37);
			this._generate.TabIndex = 89;
			this._generate.Text = "Generate";
			this._generate.UseVisualStyleBackColor = true;
			this._generate.Click += new System.EventHandler(this.OnGenerateClick);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(11, 224);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(42, 13);
			this.label21.TabIndex = 97;
			this.label21.Text = "Output:";
			// 
			// _generateOutput
			// 
			this._generateOutput.Location = new System.Drawing.Point(14, 246);
			this._generateOutput.Multiline = true;
			this._generateOutput.Name = "_generateOutput";
			this._generateOutput.ReadOnly = true;
			this._generateOutput.Size = new System.Drawing.Size(198, 64);
			this._generateOutput.TabIndex = 96;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(3, 9);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(221, 29);
			this.label23.TabIndex = 94;
			this.label23.Text = "Generate (As Alice)";
			// 
			// _generateBitCount
			// 
			this._generateBitCount.Location = new System.Drawing.Point(113, 154);
			this._generateBitCount.Name = "_generateBitCount";
			this._generateBitCount.Size = new System.Drawing.Size(100, 20);
			this._generateBitCount.TabIndex = 98;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(12, 158);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(53, 13);
			this.label22.TabIndex = 99;
			this.label22.Text = "Bit Count:";
			// 
			// DiffieHelmanForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(895, 326);
			this.Controls.Add(this._generateBitCount);
			this.Controls.Add(this.label22);
			this.Controls.Add(this._generate);
			this.Controls.Add(this.label21);
			this.Controls.Add(this._generateOutput);
			this.Controls.Add(this.label23);
			this.Controls.Add(this._hackSubmit);
			this.Controls.Add(this.label14);
			this.Controls.Add(this._hackOutput);
			this.Controls.Add(this._hackEncryptedMessage);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label16);
			this.Controls.Add(this._hackBobPublic);
			this.Controls.Add(this.label17);
			this.Controls.Add(this._hackAlicePublic);
			this.Controls.Add(this.label18);
			this.Controls.Add(this._hackGenerator);
			this.Controls.Add(this.label19);
			this.Controls.Add(this._hackPrime);
			this.Controls.Add(this.label20);
			this.Controls.Add(this._decryptSubmit);
			this.Controls.Add(this.label7);
			this.Controls.Add(this._decryptOutput);
			this.Controls.Add(this._decryptEncryptedMessage);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this._decryptAlicePublic);
			this.Controls.Add(this.label10);
			this.Controls.Add(this._decryptBobPrivate);
			this.Controls.Add(this.label11);
			this.Controls.Add(this._decryptGenerator);
			this.Controls.Add(this.label12);
			this.Controls.Add(this._decryptPrime);
			this.Controls.Add(this.label13);
			this.Controls.Add(this._encryptSubmit);
			this.Controls.Add(this.label6);
			this.Controls.Add(this._encryptOutput);
			this.Controls.Add(this._encryptMessage);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this._encryptBobPublic);
			this.Controls.Add(this.label3);
			this.Controls.Add(this._encryptAlicePrivate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._encryptGenerator);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._encryptPrime);
			this.Controls.Add(this._label);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DiffieHelmanForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DiffieHelmanForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _encryptSubmit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _encryptOutput;
        private System.Windows.Forms.TextBox _encryptMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _encryptBobPublic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _encryptAlicePrivate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _encryptGenerator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _encryptPrime;
        private System.Windows.Forms.Label _label;
        private System.Windows.Forms.Button _decryptSubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _decryptOutput;
        private System.Windows.Forms.TextBox _decryptEncryptedMessage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _decryptAlicePublic;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox _decryptBobPrivate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox _decryptGenerator;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox _decryptPrime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button _hackSubmit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox _hackOutput;
        private System.Windows.Forms.TextBox _hackEncryptedMessage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox _hackBobPublic;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox _hackAlicePublic;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox _hackGenerator;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox _hackPrime;
        private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Button _generate;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox _generateOutput;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox _generateBitCount;
		private System.Windows.Forms.Label label22;
	}
}