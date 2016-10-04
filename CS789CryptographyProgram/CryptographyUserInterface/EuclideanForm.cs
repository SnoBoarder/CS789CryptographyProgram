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

		public void HandleEuclideanAlgorithm()
		{
			if (!ValidateInput())
				return;

			int gcd;
			int x_0;
			int y_0;
			AlgorithmManager.VerboseEuclideanAlgorithm(
				Convert.ToInt32(_firstValue.Text),
				Convert.ToInt32(_secondValue.Text),
				out gcd,
				out x_0,
				out y_0);

			if (gcd == 1)
				_answer.Text = "x_0: " + x_0 + ", y_0: " + y_0;
			else
				_answer.Text = gcd.ToString();
		}

		private bool ValidateInput()
		{
			if (_firstValue.Text == string.Empty)
			{
				MessageBox.Show("First value needs a value");
				return false;
			}

			if (_secondValue.Text == string.Empty)
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
			else if (e.KeyChar == (char)Keys.Back)
			{
				// Backspace key is OK
			}
			else if (e.KeyChar == (char)Keys.Return)
			{
				HandleEuclideanAlgorithm();
			}
			else
			{
				e.Handled = true;
			}
		}

		private void OnSubmit(object sender, EventArgs e)
		{
			HandleEuclideanAlgorithm();
		}

		private void OnReset(object sender, EventArgs e)
		{
			_firstValue.Text = string.Empty;
			_secondValue.Text = string.Empty;
			_answer.Text = string.Empty;
		}
	}
}
