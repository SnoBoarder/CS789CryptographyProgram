namespace CryptographyUserInterface
{
	partial class BlumBlumShubRNGForm
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
			this._generate = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this._output = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// _generate
			// 
			this._generate.Location = new System.Drawing.Point(12, 12);
			this._generate.Name = "_generate";
			this._generate.Size = new System.Drawing.Size(198, 37);
			this._generate.TabIndex = 48;
			this._generate.Text = "Generate 32-bit Number";
			this._generate.UseVisualStyleBackColor = true;
			this._generate.Click += new System.EventHandler(this.OnGenerateClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 13);
			this.label6.TabIndex = 50;
			this.label6.Text = "Output:";
			// 
			// _output
			// 
			this._output.Location = new System.Drawing.Point(12, 78);
			this._output.Multiline = true;
			this._output.Name = "_output";
			this._output.ReadOnly = true;
			this._output.Size = new System.Drawing.Size(198, 64);
			this._output.TabIndex = 49;
			// 
			// BlumBlumShubRNGForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(224, 154);
			this.Controls.Add(this._generate);
			this.Controls.Add(this.label6);
			this.Controls.Add(this._output);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BlumBlumShubRNGForm";
			this.ShowInTaskbar = false;
			this.Text = "BlumBlumShubRNGForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _generate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox _output;
	}
}