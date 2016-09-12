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

		private void OnEuclideanClick(object sender, EventArgs e)
		{
			ShowEuclideanForm();
		}
	}
}
