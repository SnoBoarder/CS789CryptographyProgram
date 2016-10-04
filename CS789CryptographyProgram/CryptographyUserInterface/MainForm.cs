using System;
using System.Windows.Forms;

namespace CryptographyUserInterface
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		public void ShowEuclideanForm()
		{
			EuclideanForm dlg = new EuclideanForm();
			dlg.ShowDialog();
		}

		public void ShowExponentiationForm()
		{
			FastExponentiationAlgorithm dlg = new FastExponentiationAlgorithm();
			dlg.ShowDialog();
		}

		private void OnEuclideanClick(object sender, EventArgs e)
		{
			ShowEuclideanForm();
		}

		private void OnExponentiationClick(object sender, EventArgs e)
		{
			ShowExponentiationForm();
		}
	}
}
