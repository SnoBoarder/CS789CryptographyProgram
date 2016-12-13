namespace CryptographyUserInterface
{
	partial class PollardsRhoForm
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
			this._inputN = new System.Windows.Forms.TextBox();
			this._label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _submit
			// 
			this._submit.Location = new System.Drawing.Point(12, 31);
			this._submit.Name = "_submit";
			this._submit.Size = new System.Drawing.Size(198, 37);
			this._submit.TabIndex = 44;
			this._submit.Text = "Submit";
			this._submit.UseVisualStyleBackColor = true;
			this._submit.Click += new System.EventHandler(this.OnSubmitClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 75);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 13);
			this.label6.TabIndex = 47;
			this.label6.Text = "Output:";
			// 
			// _output
			// 
			this._output.Location = new System.Drawing.Point(12, 97);
			this._output.Multiline = true;
			this._output.Name = "_output";
			this._output.ReadOnly = true;
			this._output.Size = new System.Drawing.Size(198, 64);
			this._output.TabIndex = 46;
			// 
			// _inputN
			// 
			this._inputN.Location = new System.Drawing.Point(109, 5);
			this._inputN.Name = "_inputN";
			this._inputN.Size = new System.Drawing.Size(100, 20);
			this._inputN.TabIndex = 43;
			// 
			// _label
			// 
			this._label.AutoSize = true;
			this._label.Location = new System.Drawing.Point(12, 9);
			this._label.Name = "_label";
			this._label.Size = new System.Drawing.Size(18, 13);
			this._label.TabIndex = 45;
			this._label.Text = "N:";
			// 
			// PollardsRhoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(223, 174);
			this.Controls.Add(this._submit);
			this.Controls.Add(this.label6);
			this.Controls.Add(this._output);
			this.Controls.Add(this._inputN);
			this.Controls.Add(this._label);
			this.Name = "PollardsRhoForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PollardsRhoForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _submit;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox _output;
		private System.Windows.Forms.TextBox _inputN;
		private System.Windows.Forms.Label _label;
	}
}