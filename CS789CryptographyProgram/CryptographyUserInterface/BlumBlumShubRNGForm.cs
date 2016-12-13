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
	public partial class BlumBlumShubRNGForm : Form
	{
		public BlumBlumShubRNGForm()
		{
			InitializeComponent();
		}

		private void OnGenerateClick(object sender, EventArgs e)
		{
			_output.Text = AlgorithmManager.BlumBlumShubRandomNumberGenerator().ToString();
		}
	}
}
