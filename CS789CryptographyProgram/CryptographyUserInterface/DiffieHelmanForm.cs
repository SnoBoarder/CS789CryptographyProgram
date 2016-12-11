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
using static CryptographyBusiness.AlgorithmManager;

namespace CryptographyUserInterface
{
    public partial class DiffieHelmanForm : Form
    {
        public DiffieHelmanForm()
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

		private void OnGenerateClick(object sender, EventArgs e)
		{
			if (_generateBitCount.Text == string.Empty)
				return;

			DiffieHellmanKey dhk = AlgorithmManager.DiffieHellmanKeyGenerate(Convert.ToInt32(_generateBitCount.Text));

			_generateOutput.Text = "prime: " + dhk.prime + " | generator: " + dhk.generator + " | private: " + dhk.alicePrivate + " | public: " + dhk.alicePublic;

			// just unit test everything here:
			_encryptPrime.Text = dhk.prime.ToString();
			_encryptGenerator.Text = dhk.generator.ToString();
			_encryptAlicePrivate.Text = dhk.alicePrivate.ToString();
			_encryptBobPublic.Text = dhk.bobPublic.ToString();

			_decryptPrime.Text = dhk.prime.ToString();
			_decryptGenerator.Text = dhk.generator.ToString();
			_decryptBobPrivate.Text = dhk.bobPrivate.ToString();
			_decryptAlicePublic.Text = dhk.alicePublic.ToString();

			_hackPrime.Text = dhk.prime.ToString();
			_hackGenerator.Text = dhk.generator.ToString();
			_hackAlicePublic.Text = dhk.alicePublic.ToString();
			_hackBobPublic.Text = dhk.bobPublic.ToString();
		}

        private void OnEncryptSubmitClick(object sender, EventArgs e)
        {
            if (!ValidateEncrypt())
                return;

            int prime = Convert.ToInt32(_encryptPrime.Text);
            int generator = Convert.ToInt32(_encryptGenerator.Text);
            int alicePrivate = Convert.ToInt32(_encryptAlicePrivate.Text);
            int bobPublic = Convert.ToInt32(_encryptBobPublic.Text);
            int message = Convert.ToInt32(_encryptMessage.Text);

            _encryptOutput.Text = AlgorithmManager.DiffieHellmanKeyEncrypt(message, prime, generator, alicePrivate, bobPublic).ToString();
        }

        private void OnDecryptSubmitClick(object sender, EventArgs e)
        {
            if (!ValidateDecrypt())
                return;

            int prime = Convert.ToInt32(_decryptPrime.Text);
            int generator = Convert.ToInt32(_decryptGenerator.Text);
            int bobPrivate = Convert.ToInt32(_decryptBobPrivate.Text);
            int alicePublic = Convert.ToInt32(_decryptAlicePublic.Text);
            int message = Convert.ToInt32(_decryptEncryptedMessage.Text);

            _decryptOutput.Text = AlgorithmManager.DiffieHellmanKeyDecrypt(message, prime, generator, bobPrivate, alicePublic).ToString();
        }

        private void OnHackSubmitClick(object sender, EventArgs e)
        {
            if (!ValidateHack())
                return;

            int prime = Convert.ToInt32(_hackPrime.Text);
            int generator = Convert.ToInt32(_hackGenerator.Text);
            int alicePublic = Convert.ToInt32(_hackAlicePublic.Text);
            int bobPublic= Convert.ToInt32(_hackBobPublic.Text);
            int message = Convert.ToInt32(_hackEncryptedMessage.Text);

            _hackOutput.Text = AlgorithmManager.DiffieHellmanKeyHack(message, prime, generator, alicePublic, bobPublic).ToString();
        }

        private bool ValidateEncrypt()
        {
            if (_encryptPrime.Text == string.Empty)
                return false;

            if (_encryptGenerator.Text == string.Empty)
                return false;

            if (_encryptAlicePrivate.Text == string.Empty)
                return false;

            if (_encryptBobPublic.Text == string.Empty)
                return false;

            if (_encryptMessage.Text == string.Empty)
                return false;

            return true;
        }

        private bool ValidateDecrypt()
        {
            if (_decryptPrime.Text == string.Empty)
                return false;

            if (_decryptGenerator.Text == string.Empty)
                return false;

            if (_decryptAlicePublic.Text == string.Empty && _decryptBobPrivate.Text == string.Empty)
                return false;

            if (_decryptEncryptedMessage.Text == string.Empty)
                return false;

            return true;
        }

        private bool ValidateHack()
        {
            if (_hackPrime.Text == string.Empty)
                return false;

            if (_hackGenerator.Text == string.Empty)
                return false;

            if (_hackAlicePublic.Text == string.Empty)
                return false;

            if (_hackBobPublic.Text == string.Empty)
                return false;

            if (_hackEncryptedMessage.Text == string.Empty)
                return false;

            return true;
        }
    }
}
