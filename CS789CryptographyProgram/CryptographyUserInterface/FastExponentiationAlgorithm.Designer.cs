namespace CryptographyUserInterface
{
	partial class FastExponentiationAlgorithm
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
			this._xInput = new System.Windows.Forms.TextBox();
			this._eInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this._mInput = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this._answer = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this._submit = new System.Windows.Forms.Button();
			this._reset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _xInput
			// 
			this._xInput.Location = new System.Drawing.Point(36, 45);
			this._xInput.Name = "_xInput";
			this._xInput.Size = new System.Drawing.Size(100, 20);
			this._xInput.TabIndex = 0;
			this._xInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._xInput.Enter += new System.EventHandler(this.OnFocus);
			this._xInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
			// 
			// _eInput
			// 
			this._eInput.Location = new System.Drawing.Point(134, 14);
			this._eInput.MaxLength = 4;
			this._eInput.Name = "_eInput";
			this._eInput.Size = new System.Drawing.Size(54, 20);
			this._eInput.TabIndex = 1;
			this._eInput.Enter += new System.EventHandler(this.OnFocus);
			this._eInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(174, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "mod";
			// 
			// _mInput
			// 
			this._mInput.Location = new System.Drawing.Point(205, 45);
			this._mInput.Name = "_mInput";
			this._mInput.Size = new System.Drawing.Size(66, 20);
			this._mInput.TabIndex = 2;
			this._mInput.Enter += new System.EventHandler(this.OnFocus);
			this._mInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(277, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "=";
			// 
			// _answer
			// 
			this._answer.Location = new System.Drawing.Point(296, 45);
			this._answer.Name = "_answer";
			this._answer.ReadOnly = true;
			this._answer.Size = new System.Drawing.Size(100, 20);
			this._answer.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(131, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "^";
			// 
			// _submit
			// 
			this._submit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this._submit.Location = new System.Drawing.Point(235, 82);
			this._submit.Name = "_submit";
			this._submit.Size = new System.Drawing.Size(180, 45);
			this._submit.TabIndex = 7;
			this._submit.Text = "Submit";
			this._submit.UseVisualStyleBackColor = true;
			this._submit.Click += new System.EventHandler(this.OnSubmitClick);
			// 
			// _reset
			// 
			this._reset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this._reset.Location = new System.Drawing.Point(12, 82);
			this._reset.Name = "_reset";
			this._reset.Size = new System.Drawing.Size(180, 45);
			this._reset.TabIndex = 8;
			this._reset.Text = "Reset";
			this._reset.UseVisualStyleBackColor = true;
			this._reset.Click += new System.EventHandler(this.OnResetClick);
			// 
			// FastExponentiationAlgorithm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(427, 139);
			this.Controls.Add(this._reset);
			this.Controls.Add(this._submit);
			this.Controls.Add(this._answer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._mInput);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._eInput);
			this.Controls.Add(this._xInput);
			this.Controls.Add(this.label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FastExponentiationAlgorithm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FastExponentiationAlgorithm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox _xInput;
		private System.Windows.Forms.TextBox _eInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _mInput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox _answer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button _submit;
		private System.Windows.Forms.Button _reset;
	}
}