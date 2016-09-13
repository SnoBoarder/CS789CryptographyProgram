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
				int firstValue = Convert.ToInt32(_firstValue.Text);
				int secondValue = Convert.ToInt32(_secondValue.Text);

				int answer = AlgorithmManager.FastEuclideanAlgorithm(firstValue, secondValue);

				if (answer != 1)
				{
					_answer.Text = answer.ToString();
  				}
				else
				{
					int gcd;
					int x_0;
					int y_0;

					AlgorithmManager.VerboseEuclideanAlgorithm(firstValue, secondValue, out gcd, out x_0, out y_0);

					_answer.Text = "x_0: " + x_0 + ", y_0: " + y_0;
				}
			}
		}
	}
}
