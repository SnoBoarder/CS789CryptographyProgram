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

        private void OnEncryptSubmitClick(object sender, EventArgs eventArgs)
        {
            if (!ValidateEncrypt())
                return;

            int n = Convert.ToInt32(_encryptPrime.Text);
            int e = Convert.ToInt32(_encryptBobEncryption.Text);
            int plainMessage = Convert.ToInt32(_encryptMessage.Text);

            _encryptOutput.Text = AlgorithmManager.RSAEncrypt(plainMessage, n, e).ToString();
        }

        private void OnDecryptSubmitClick(object sender, EventArgs eventArgs)
        {
            if (!ValidateDecrypt())
                return;

            int n = Convert.ToInt32(_decryptPrime.Text);
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

            int n = Convert.ToInt32(_hackPrime.Text);
            int e = Convert.ToInt32(_hackBobsEncryption.Text);
            int message = Convert.ToInt32(_hackEncryptedMessage.Text);

            _hackOutput.Text = AlgorithmManager.RSAHack(message, n, e).ToString();
        }

        private bool ValidateEncrypt()
        {
            if (_encryptPrime.Text == string.Empty)
                return false;

            if (_encryptBobEncryption.Text == string.Empty)
                return false;

            if (_encryptMessage.Text == string.Empty)
                return false;

            return true;
        }

        private bool ValidateDecrypt()
        {
            if (_decryptPrime.Text == string.Empty)
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
            if (_hackPrime.Text == string.Empty)
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
