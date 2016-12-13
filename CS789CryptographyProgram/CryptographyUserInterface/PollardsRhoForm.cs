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
	public partial class PollardsRhoForm : Form
	{
		public PollardsRhoForm()
		{
			InitializeComponent();
		}

		private void OnSubmitClick(object sender, EventArgs e)
		{
			if (!ValidateInput())
				return;

			int n = Convert.ToInt32(_inputN.Text);
			int p = AlgorithmManager.PollardsRhoMethod(n);
			int q = n / p;

			_output.Text = "p = " + p + " | q = " + q;
		}

		private bool ValidateInput()
		{
			if (_inputN.Text == string.Empty)
				return false;

			return true;
		}
	}
}
