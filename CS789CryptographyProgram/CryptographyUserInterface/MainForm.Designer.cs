﻿namespace CryptographyUserInterface
{
	partial class MainForm
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
			this._euclidean = new System.Windows.Forms.Button();
			this._fastExponentiation = new System.Windows.Forms.Button();
			this._primitiveRoot = new System.Windows.Forms.Button();
			this._millerRabinTest = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _euclidean
			// 
			this._euclidean.Location = new System.Drawing.Point(12, 270);
			this._euclidean.Name = "_euclidean";
			this._euclidean.Size = new System.Drawing.Size(192, 63);
			this._euclidean.TabIndex = 4;
			this._euclidean.Text = "Euclidean Algorithm";
			this._euclidean.UseVisualStyleBackColor = true;
			this._euclidean.Click += new System.EventHandler(this.OnEuclideanClick);
			// 
			// _fastExponentiation
			// 
			this._fastExponentiation.Location = new System.Drawing.Point(210, 270);
			this._fastExponentiation.Name = "_fastExponentiation";
			this._fastExponentiation.Size = new System.Drawing.Size(192, 63);
			this._fastExponentiation.TabIndex = 5;
			this._fastExponentiation.Text = "Fast Exponentiation Algorithm";
			this._fastExponentiation.UseVisualStyleBackColor = true;
			this._fastExponentiation.Click += new System.EventHandler(this.OnExponentiationClick);
			// 
			// _primitiveRoot
			// 
			this._primitiveRoot.Location = new System.Drawing.Point(210, 339);
			this._primitiveRoot.Name = "_primitiveRoot";
			this._primitiveRoot.Size = new System.Drawing.Size(192, 63);
			this._primitiveRoot.TabIndex = 7;
			this._primitiveRoot.Text = "Primitive Root Search Algorithm";
			this._primitiveRoot.UseVisualStyleBackColor = true;
			this._primitiveRoot.Click += new System.EventHandler(this.OnPrimitiveRootClick);
			// 
			// _millerRabinTest
			// 
			this._millerRabinTest.Location = new System.Drawing.Point(12, 339);
			this._millerRabinTest.Name = "_millerRabinTest";
			this._millerRabinTest.Size = new System.Drawing.Size(192, 63);
			this._millerRabinTest.TabIndex = 6;
			this._millerRabinTest.Text = "Miller-Rabin Test";
			this._millerRabinTest.UseVisualStyleBackColor = true;
			this._millerRabinTest.Click += new System.EventHandler(this.OnMillerRabinTestClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 94);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(192, 63);
			this.button1.TabIndex = 0;
			this.button1.Text = "Diffie-Helman";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.OnDiffieHelmanClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(210, 94);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(192, 63);
			this.button2.TabIndex = 1;
			this.button2.Text = "RSA";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.OnRSAClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(337, 29);
			this.label1.TabIndex = 6;
			this.label1.Text = "BU MET CS789 - Final Project";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 24);
			this.label2.TabIndex = 7;
			this.label2.Text = "By Brian Tran";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 201);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(192, 63);
			this.button3.TabIndex = 2;
			this.button3.Text = "Baby Step Giant Step Algorithm";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.OnBabyStepGiantStepClick);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(210, 201);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(192, 63);
			this.button4.TabIndex = 3;
			this.button4.Text = "Pollard\'s Rho Method";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.OnPollardsRhoClick);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(12, 408);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(192, 63);
			this.button5.TabIndex = 8;
			this.button5.Text = "Blum-Blum-Shub RNG";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.OnBlumBlumShubClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 483);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this._millerRabinTest);
			this.Controls.Add(this._primitiveRoot);
			this.Controls.Add(this._fastExponentiation);
			this.Controls.Add(this._euclidean);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _euclidean;
		private System.Windows.Forms.Button _fastExponentiation;
        private System.Windows.Forms.Button _primitiveRoot;
        private System.Windows.Forms.Button _millerRabinTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
	}
}