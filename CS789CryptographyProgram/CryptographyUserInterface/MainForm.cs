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

        public void ShowPrimitiveRootForm()
        {
            PrimitiveRootForm dlg = new PrimitiveRootForm();
            dlg.ShowDialog();
        }

        public void ShowMillerRabinTestForm()
        {
            MillerRabinTestForm dlg = new MillerRabinTestForm();
            dlg.ShowDialog();
        }

        public void ShowDiffieHelmanForm()
        {
            DiffieHelmanForm dlg = new DiffieHelmanForm();
            dlg.ShowDialog();
        }

        public void ShowRSAForm()
        {
            RSAForm dlg = new RSAForm();
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

        private void OnPrimitiveRootClick(object sender, EventArgs e)
        {
            ShowPrimitiveRootForm();
        }

        private void OnMillerRabinTestClick(object sender, EventArgs e)
        {
            ShowMillerRabinTestForm();
        }

        private void OnDiffieHelmanClick(object sender, EventArgs e)
        {
            ShowDiffieHelmanForm();
        }

        private void OnRSAClick(object sender, EventArgs e)
        {
            ShowRSAForm();
        }
    }
}
