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
using System.Numerics;

namespace CryptographyUserInterface
{
    public partial class FastExponentiationAlgorithm : Form
    {
        public FastExponentiationAlgorithm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// TODO: Remove this from this class!
        /// </summary>
        private void TestDiffieHellmanKeyExchange()
        {
            // p = 7
            // g = 3;
            // r = 5;
            // l = 8;
            // p = 11;
            // g^l%p = 2
            // g^r%p = 5

            int largePrime = 7;
            int generator = 3;
            int alicePrivate = 5;
            int bobPrivate = 8;
            int alicePublic = (int)AlgorithmManager.FastExponentiationAlgorithm(generator, alicePrivate, largePrime);
            int bobPublic = (int)AlgorithmManager.FastExponentiationAlgorithm(generator, bobPrivate, largePrime);

            long message = AlgorithmManager.DiffieHellmanKeyEncrypt('c', largePrime, generator, alicePrivate, bobPublic);

            Console.WriteLine("message: " + message);

            Console.WriteLine("translated msg: " + AlgorithmManager.DiffieHellmanKeyDecrypt(message, largePrime, generator, bobPrivate, alicePublic));
        }

        private void HandleFastExponentiationAlgorithm()
        {
            if (!ValidateInput())
                return;

            long answer = (long)AlgorithmManager.FastExponentiationAlgorithm(
                Convert.ToInt64(_xInput.Text),
                Convert.ToInt64(_eInput.Text),
                Convert.ToInt64(_mInput.Text));

            _answer.Text = answer.ToString();
        }

        private bool ValidateInput()
        {
            if (_xInput.Text == string.Empty)
            {
                MessageBox.Show("Need a base value");
                return false;
            }

            if (_eInput.Text == string.Empty)
            {
                MessageBox.Show("Need an exponent value");
                return false;
            }

            if (_mInput.Text == string.Empty)
            {
                MessageBox.Show("Need a modulator");
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
                HandleFastExponentiationAlgorithm();
            }
            else
            {
                e.Handled = true;
            }
        }

        private void OnSubmitClick(object sender, EventArgs e)
        {
            HandleFastExponentiationAlgorithm();
        }

        private void OnResetClick(object sender, EventArgs e)
        {
            _xInput.Text = string.Empty;
            _eInput.Text = string.Empty;
            _mInput.Text = string.Empty;
            _answer.Text = string.Empty;
        }

        private void OnFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
    }
}
