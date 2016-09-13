namespace CryptographyUserInterface
{
	partial class EuclideanForm
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
			this._firstValue = new System.Windows.Forms.TextBox();
			this._secondValue = new System.Windows.Forms.TextBox();
			this._answer = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this._submit = new System.Windows.Forms.Button();
			this._reset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _firstValue
			// 
			this._firstValue.Location = new System.Drawing.Point(94, 6);
			this._firstValue.Name = "_firstValue";
			this._firstValue.Size = new System.Drawing.Size(100, 20);
			this._firstValue.TabIndex = 0;
			this._firstValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
			// 
			// _secondValue
			// 
			this._secondValue.Location = new System.Drawing.Point(94, 32);
			this._secondValue.Name = "_secondValue";
			this._secondValue.Size = new System.Drawing.Size(100, 20);
			this._secondValue.TabIndex = 1;
			this._secondValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
			// 
			// _answer
			// 
			this._answer.Location = new System.Drawing.Point(94, 58);
			this._answer.Name = "_answer";
			this._answer.ReadOnly = true;
			this._answer.Size = new System.Drawing.Size(100, 20);
			this._answer.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "First Value";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Second Value";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "gcd";
			// 
			// _submit
			// 
			this._submit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this._submit.Location = new System.Drawing.Point(14, 143);
			this._submit.Name = "_submit";
			this._submit.Size = new System.Drawing.Size(180, 45);
			this._submit.TabIndex = 6;
			this._submit.Text = "Submit";
			this._submit.UseVisualStyleBackColor = true;
			this._submit.Click += new System.EventHandler(this.OnSubmit);
			// 
			// _reset
			// 
			this._reset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this._reset.Location = new System.Drawing.Point(14, 92);
			this._reset.Name = "_reset";
			this._reset.Size = new System.Drawing.Size(180, 45);
			this._reset.TabIndex = 7;
			this._reset.Text = "Reset";
			this._reset.UseVisualStyleBackColor = true;
			this._reset.Click += new System.EventHandler(this.OnReset);
			// 
			// EuclideanForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(214, 200);
			this.Controls.Add(this._reset);
			this.Controls.Add(this._submit);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._answer);
			this.Controls.Add(this._secondValue);
			this.Controls.Add(this._firstValue);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EuclideanForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "EuclideanForm";
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox _firstValue;
		private System.Windows.Forms.TextBox _secondValue;
		private System.Windows.Forms.TextBox _answer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button _submit;
		private System.Windows.Forms.Button _reset;
	}
}