using System;
using System.Net.Configuration;
using System.Windows.Forms;

namespace MPGGUI02
{
    public partial class frmMPG02 : Form
    {
        public frmMPG02()
        {
            InitializeComponent();
        }

        //  Declare and initialize program constants
        const decimal MINMILES =    1M;
        const decimal MAXMILES = 1000M;
        const decimal MINGALLS =    1M;
        const decimal MAXGALLS =  100M;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string msg          = "";
            decimal milesDriven = 0m;
            decimal gallonsUsed = 0m;

            try
            {
                if (IsValidData())
                {
                    milesDriven = Convert.ToDecimal(txtMilesDriven.Text);
                    gallonsUsed = Convert.ToDecimal(txtGallonsUsed.Text);
                    CalculateMPG(milesDriven, gallonsUsed);
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error: {msg}\n{ex.Message}\n\n",
                            "ERROR MESSAGES");
            }
        }

        private bool IsValidData()
        {
            string errorMessage = "";

            //  Validate the miles driven textbox
            errorMessage += IsPresent(txtMilesDriven.Text, "milesDriven", txtMilesDriven);
            errorMessage += IsDecimal(txtMilesDriven.Text, "milesDriven", txtMilesDriven);
            errorMessage += IsWithinRange(txtMilesDriven.Text, "milesDriven",
                                          MINMILES, MAXMILES, txtMilesDriven);

            if (errorMessage != "")
            {
                ShowMessage($"Errors: {errorMessage}", "ERROR MESSAGES");
                return false;
            }
            else
            {
                //  Validate the gallons used textbox
                errorMessage += IsPresent(txtGallonsUsed.Text, "gallonsUsed", txtGallonsUsed);
                errorMessage += IsDecimal(txtGallonsUsed.Text, "gallonsUsed", txtGallonsUsed);
                errorMessage += IsWithinRange(txtGallonsUsed.Text, "gallonsUsed",
                                              MINGALLS, MAXGALLS, txtGallonsUsed);
            }

            if (errorMessage != "")
            {
                ShowMessage($"Errors: {errorMessage}", "ERROR MESSAGES");
                return false;
            }

            return true;
        }

        private string IsPresent(string value, string name, Control ctrl)
        {
            string msg = "";
            if (value.Trim() == "")
            {
                msg = name + " is a required field.\n";
                ClearAndSetFocusToCorrectControl(ctrl);
            }

            return msg;
        }
        private string IsDecimal(string value, string name, Control ctrl)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg = name + " must be a valid decimal value.\n";
                ClearAndSetFocusToCorrectControl(ctrl);
            }

            return msg;
        }

        private string IsWithinRange(string value, string name, 
                                     decimal min, decimal max, Control ctrl)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if ((number < min) || (number > max))
                {
                    msg = name + " must be between " + min + " and " + max + ".\n";
                    ClearAndSetFocusToCorrectControl(ctrl);
                }
            }

            return msg;
        }

        private void ClearAndSetFocusToCorrectControl(Control ctrl)
        {
            ctrl.Text = "";
            ctrl.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtMilesDriven.Text = "";
            txtGallonsUsed.Text = "";
            txtMilesPerGallon.Text = "";
            txtMilesDriven.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
            "Do You Really Want To Exit The Program?",
            "EXIT NOW?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void CalculateMPG(decimal milesDriven, decimal gallonsUsed)
        {
            decimal mpg = milesDriven / gallonsUsed;
            txtMilesPerGallon.Text = mpg.ToString("n2");
        }
    }
}
