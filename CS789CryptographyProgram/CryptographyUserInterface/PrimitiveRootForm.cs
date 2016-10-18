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
    public partial class PrimitiveRootForm : Form
    {
        public PrimitiveRootForm()
        {
            InitializeComponent();
        }

        private void HandlePrimitiveRootSearchAlgorithm()
        {
            if (!ValidateInput())
                return;

            int answer = AlgorithmManager.PrimitiveRootSearchAlgorithm(Convert.ToInt32(_input.Text));
            _answer.Text = answer.ToString();
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
                HandlePrimitiveRootSearchAlgorithm();
            }
            else
            {
                e.Handled = true;
            }
        }

        private void OnSubmitClick(object sender, EventArgs e)
        {
            HandlePrimitiveRootSearchAlgorithm();
        }

        private void OnFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
    }
}
