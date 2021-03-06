﻿namespace CryptographyUserInterface
{
    partial class MillerRabinTestForm
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
			this.label1 = new System.Windows.Forms.Label();
			this._answer = new System.Windows.Forms.TextBox();
			this._input = new System.Windows.Forms.TextBox();
			this._label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _submit
			// 
			this._submit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this._submit.Location = new System.Drawing.Point(15, 59);
			this._submit.Name = "_submit";
			this._submit.Size = new System.Drawing.Size(180, 45);
			this._submit.TabIndex = 13;
			this._submit.Text = "Submit";
			this._submit.UseVisualStyleBackColor = true;
			this._submit.Click += new System.EventHandler(this.OnSubmitClick);
			this._submit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(53, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Result:";
			// 
			// _answer
			// 
			this._answer.Location = new System.Drawing.Point(95, 33);
			this._answer.Name = "_answer";
			this._answer.ReadOnly = true;
			this._answer.Size = new System.Drawing.Size(100, 20);
			this._answer.TabIndex = 11;
			// 
			// _input
			// 
			this._input.Location = new System.Drawing.Point(95, 7);
			this._input.Name = "_input";
			this._input.Size = new System.Drawing.Size(100, 20);
			this._input.TabIndex = 10;
			this._input.Enter += new System.EventHandler(this.OnFocus);
			this._input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
			// 
			// _label
			// 
			this._label.AutoSize = true;
			this._label.Location = new System.Drawing.Point(12, 9);
			this._label.Name = "_label";
			this._label.Size = new System.Drawing.Size(80, 13);
			this._label.TabIndex = 9;
			this._label.Text = "Potential Prime:";
			// 
			// MillerRabinTestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(210, 113);
			this.Controls.Add(this._submit);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._answer);
			this.Controls.Add(this._input);
			this.Controls.Add(this._label);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MillerRabinTestForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MillerRabinTestForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _answer;
        private System.Windows.Forms.TextBox _input;
        private System.Windows.Forms.Label _label;
    }
}