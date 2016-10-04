using CryptographyBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographyUserInterface
{
	public partial class FastExponentiationAlgorithm : Form
	{
		public FastExponentiationAlgorithm()
		{
			InitializeComponent();
		}

		private void HandleFastExponentiationAlgorithm()
		{
			if (!ValidateInput())
				return;

			int answer = AlgorithmManager.FastExponentiationAlgorithm(
				Convert.ToInt32(_xInput.Text),
				Convert.ToInt32(_eInput.Text),
				Convert.ToInt32(_mInput.Text));

			_answer.Text = answer.ToString();
		}

		private bool ValidateInput()
		{
			if (_xInput.Text == string.Empty)
			{
				MessageBox.Show("Need a base value");
				return false;
			}

			if (_eInput.Text == string.Empty)
			{
				MessageBox.Show("Need an exponent value");
				return false;
			}

			if (_mInput.Text == string.Empty)
			{
				MessageBox.Show("Need a modulator");
				return false;
			}

			return true;
		}

		/// <summary>
		/// Handle key inputs
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnKeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar))
			{
				// Digits are OK
			}
			else if (e.KeyChar == (char)Keys.Back)
			{
				// Backspace key is OK
			}
			else if (e.KeyChar == (char)Keys.Return)
			{
				HandleFastExponentiationAlgorithm();
			}
			else
			{
				e.Handled = true;
			}
		}

		private void OnSubmitClick(object sender, EventArgs e)
		{
			HandleFastExponentiationAlgorithm();
		}

		private void OnResetClick(object sender, EventArgs e)
		{
			_xInput.Text = string.Empty;
			_eInput.Text = string.Empty;
			_mInput.Text = string.Empty;
			_answer.Text = string.Empty;
		}

		private void OnFocus(object sender, EventArgs e)
		{
			((TextBox)sender).SelectAll();
		}
	}
}
