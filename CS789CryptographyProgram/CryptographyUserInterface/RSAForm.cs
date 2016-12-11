using CryptographyBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographyUserInterface
{
    public partial class RSAForm : Form
    {
        public RSAForm()
        {
            InitializeComponent();
        }

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
            else
            {
                e.Handled = true;
            }
        }

		private void OnGenerateClick(object sender, EventArgs eventArgs)
		{
			short p;
			short q;
			int n;
			int e;

			AlgorithmManager.GenerateCompositeRSANumber(out n, out p, out q, out e);

			_generateOutput.Text = "n: " + n + " | p,q: " + p + "," + q + " | e: " + e;

			_encryptComposite.Text = n.ToString();
			_encryptBobEncryption.Text = e.ToString();

			_decryptComposite.Text = n.ToString();
			_decryptBobEncryption.Text = e.ToString();
			_decryptBobP.Text = p.ToString();
			_decryptBobQ.Text = q.ToString();

			_hackComposite.Text = n.ToString();
			_hackBobsEncryption.Text = e.ToString();
		}

		private void OnEncryptSubmitClick(object sender, EventArgs eventArgs)
        {
            if (!ValidateEncrypt())
                return;

            int n = Convert.ToInt32(_encryptComposite.Text);
            int e = Convert.ToInt32(_encryptBobEncryption.Text);
            int plainMessage = Convert.ToInt32(_encryptMessage.Text);

            _encryptOutput.Text = AlgorithmManager.RSAEncrypt(plainMessage, n, e).ToString();
        }

        private void OnDecryptSubmitClick(object sender, EventArgs eventArgs)
        {
            if (!ValidateDecrypt())
                return;

            int n = Convert.ToInt32(_decryptComposite.Text);
            int e = Convert.ToInt32(_decryptBobEncryption.Text);
            int p = Convert.ToInt32(_decryptBobP.Text);
            int q = Convert.ToInt32(_decryptBobQ.Text);
            int message = Convert.ToInt32(_decryptEncryptedMessage.Text);

            _decryptOutput.Text = AlgorithmManager.RSADecrypt(message, n, p, q, e).ToString();
        }

        private void OnHackSubmitClick(object sender, EventArgs eventArgs)
        {
            if (!ValidateHack())
                return;

            int n = Convert.ToInt32(_hackComposite.Text);
            int e = Convert.ToInt32(_hackBobsEncryption.Text);
            int message = Convert.ToInt32(_hackEncryptedMessage.Text);

            _hackOutput.Text = AlgorithmManager.RSAHack(message, n, e).ToString();
        }

        private bool ValidateEncrypt()
        {
            if (_encryptComposite.Text == string.Empty)
                return false;

            if (_encryptBobEncryption.Text == string.Empty)
                return false;

            if (_encryptMessage.Text == string.Empty)
                return false;

            return true;
        }

        private bool ValidateDecrypt()
        {
            if (_decryptComposite.Text == string.Empty)
                return false;

            if (_decryptBobEncryption.Text == string.Empty)
                return false;

            if (_decryptBobQ.Text == string.Empty && _decryptBobP.Text == string.Empty)
                return false;

            if (_decryptEncryptedMessage.Text == string.Empty)
                return false;

            return true;
        }

        private bool ValidateHack()
        {
            if (_hackComposite.Text == string.Empty)
                return false;

            if (_hackBobsEncryption.Text == string.Empty)
                return false;

            if (_hackEncryptedMessage.Text == string.Empty)
                return false;

            if (_hackEncryptedMessage.Text == string.Empty)
                return false;

            return true;
        }
	}
}
