namespace CryptographyUserInterface
{
	partial class BabyStepGiantStepForm
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
			this._submit = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this._output = new System.Windows.Forms.TextBox();
			this._prime = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this._generator = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this._generatorPowL = new System.Windows.Forms.TextBox();
			this._label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _submit
			// 
			this._submit.Location = new System.Drawing.Point(12, 82);
			this._submit.Name = "_submit";
			this._submit.Size = new System.Drawing.Size(198, 37);
			this._submit.TabIndex = 46;
			this._submit.Text = "Submit";
			this._submit.UseVisualStyleBackColor = true;
			this._submit.Click += new System.EventHandler(this.OnSubmitClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 126);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 13);
			this.label6.TabIndex = 51;
			this.label6.Text = "Output:";
			// 
			// _output
			// 
			this._output.Location = new System.Drawing.Point(12, 148);
			this._output.Multiline = true;
			this._output.Name = "_output";
			this._output.ReadOnly = true;
			this._output.Size = new System.Drawing.Size(198, 64);
			this._output.TabIndex = 50;
			// 
			// _prime
			// 
			this._prime.Location = new System.Drawing.Point(109, 56);
			this._prime.Name = "_prime";
			this._prime.Size = new System.Drawing.Size(100, 20);
			this._prime.TabIndex = 45;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 49;
			this.label2.Text = "Prime:";
			// 
			// _generator
			// 
			this._generator.Location = new System.Drawing.Point(109, 30);
			this._generator.Name = "_generator";
			this._generator.Size = new System.Drawing.Size(100, 20);
			this._generator.TabIndex = 44;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 48;
			this.label1.Text = "generator:";
			// 
			// _generatorPowL
			// 
			this._generatorPowL.Location = new System.Drawing.Point(109, 4);
			this._generatorPowL.Name = "_generatorPowL";
			this._generatorPowL.Size = new System.Drawing.Size(100, 20);
			this._generatorPowL.TabIndex = 43;
			// 
			// _label
			// 
			this._label.AutoSize = true;
			this._label.Location = new System.Drawing.Point(8, 8);
			this._label.Name = "_label";
			this._label.Size = new System.Drawing.Size(82, 13);
			this._label.TabIndex = 47;
			this._label.Text = "generatorPowL:";
			// 
			// BabyStepGiantStepForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(224, 225);
			this.Controls.Add(this._submit);
			this.Controls.Add(this.label6);
			this.Controls.Add(this._output);
			this.Controls.Add(this._prime);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._generator);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._generatorPowL);
			this.Controls.Add(this._label);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BabyStepGiantStepForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "BabyStepGiantStepForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _submit;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox _output;
		private System.Windows.Forms.TextBox _prime;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox _generator;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _generatorPowL;
		private System.Windows.Forms.Label _label;
	}
}