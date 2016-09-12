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
	public partial class EuclideanForm : Form
	{
		public EuclideanForm()
		{
			InitializeComponent();
		}

		private bool ValidateInput(TextBox firstVal, TextBox secondVal)
		{
			if (firstVal.Text == string.Empty)
			{
				MessageBox.Show("First value needs a value");
				return false;
			}

			if (secondVal.Text == string.Empty)
			{
				MessageBox.Show("Second value needs a value");
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
			else if (e.KeyChar == '\b')
			{
				// Backspace key is OK
			}
			else
			{
				e.Handled = true;
			}
		}

		private void OnSubmit(object sender, EventArgs e)
		{
			if (ValidateInput(_firstValue, _secondValue))
			{
				int answer = AlgorithmManager.EuclideanAlgorithm(Convert.ToInt32(_firstValue.Text), Convert.ToInt32(_secondValue.Text));
				_answer.Text = answer.ToString();
			}
		}
	}
}
