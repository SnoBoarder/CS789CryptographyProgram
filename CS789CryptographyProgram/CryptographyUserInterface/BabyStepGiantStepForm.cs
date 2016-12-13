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
	public partial class BabyStepGiantStepForm : Form
	{
		public BabyStepGiantStepForm()
		{
			InitializeComponent();
		}

		private void OnSubmitClick(object sender, EventArgs e)
		{
			if (!ValidateInput())
				return;

			int answer = AlgorithmManager.BabyStepGiantStepAlgorithm(
				Convert.ToInt32(_generatorPowL.Text),
				Convert.ToInt32(_generator.Text),
				Convert.ToInt32(_prime.Text));

			_output.Text = answer.ToString();
		}

		private bool ValidateInput()
		{
			if (_generatorPowL.Text == string.Empty)
				return false;

			if (_generator.Text == string.Empty)
				return false;

			if (_prime.Text == string.Empty)
				return false;

			return true;
		}
	}
}
