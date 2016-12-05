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
    public partial class MillerRabinTestForm : Form
    {
        public MillerRabinTestForm()
        {
            InitializeComponent();
        }

        public void HandleMillerRabinTest()
        {
            if (!ValidateInput())
                return;

            bool answer = AlgorithmManager.MillerRabinOptimal(Convert.ToInt64(_input.Text));
            _answer.Text = answer ? "Prime" : "Composite";
        }

        private bool ValidateInput()
        {
            if (_input.Text == string.Empty)
            {
                MessageBox.Show("Need a value");
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
                HandleMillerRabinTest();
            }
            else
            {
                e.Handled = true;
            }
        }

        private void OnSubmitClick(object sender, EventArgs e)
        {
            HandleMillerRabinTest();
        }

        private void OnFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
    }
}
