namespace CryptographyUserInterface
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
            this.SuspendLayout();
            // 
            // _euclidean
            // 
            this._euclidean.Location = new System.Drawing.Point(12, 12);
            this._euclidean.Name = "_euclidean";
            this._euclidean.Size = new System.Drawing.Size(192, 63);
            this._euclidean.TabIndex = 0;
            this._euclidean.Text = "Euclidean Algorithm";
            this._euclidean.UseVisualStyleBackColor = true;
            this._euclidean.Click += new System.EventHandler(this.OnEuclideanClick);
            // 
            // _fastExponentiation
            // 
            this._fastExponentiation.Location = new System.Drawing.Point(210, 12);
            this._fastExponentiation.Name = "_fastExponentiation";
            this._fastExponentiation.Size = new System.Drawing.Size(192, 63);
            this._fastExponentiation.TabIndex = 1;
            this._fastExponentiation.Text = "Fast Exponentiation Algorithm";
            this._fastExponentiation.UseVisualStyleBackColor = true;
            this._fastExponentiation.Click += new System.EventHandler(this.OnExponentiationClick);
            // 
            // _primitiveRoot
            // 
            this._primitiveRoot.Location = new System.Drawing.Point(408, 12);
            this._primitiveRoot.Name = "_primitiveRoot";
            this._primitiveRoot.Size = new System.Drawing.Size(192, 63);
            this._primitiveRoot.TabIndex = 2;
            this._primitiveRoot.Text = "Primitive Root Search Algorithm";
            this._primitiveRoot.UseVisualStyleBackColor = true;
            this._primitiveRoot.Click += new System.EventHandler(this.OnPrimitiveRootClick);
            // 
            // _millerRabinTest
            // 
            this._millerRabinTest.Location = new System.Drawing.Point(12, 81);
            this._millerRabinTest.Name = "_millerRabinTest";
            this._millerRabinTest.Size = new System.Drawing.Size(192, 63);
            this._millerRabinTest.TabIndex = 3;
            this._millerRabinTest.Text = "Miller-Rabin Test";
            this._millerRabinTest.UseVisualStyleBackColor = true;
            this._millerRabinTest.Click += new System.EventHandler(this.OnMillerRabinTestClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "Diffie-Helman";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnDiffieHelmanClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 63);
            this.button2.TabIndex = 5;
            this.button2.Text = "RSA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnRSAClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 483);
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

		}

		#endregion

		private System.Windows.Forms.Button _euclidean;
		private System.Windows.Forms.Button _fastExponentiation;
        private System.Windows.Forms.Button _primitiveRoot;
        private System.Windows.Forms.Button _millerRabinTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}