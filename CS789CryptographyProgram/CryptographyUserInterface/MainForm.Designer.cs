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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 483);
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
    }
}