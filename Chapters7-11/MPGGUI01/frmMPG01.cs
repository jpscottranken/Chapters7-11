using System;
using System.Windows.Forms;

namespace MPGGUI01
{
    public partial class frmMPG01 : Form
    {
        public frmMPG01()
        {
            InitializeComponent();
        }

        //  Declare and initialize program constants
        const decimal MINMILES = 1M;
        const decimal MAXMILES = 1000M;
        const decimal MINGALLS = 1M;
        const decimal MAXGALLS = 100M;
        const string  NIIT     = "NO INPUT IN TEXTBOX";
        const string  NNIIT    = "NON-NUMERIC INPUT IN TEXTBOX";
        const string  OORIT    = "OUT-OF-RANGE INPUT IN TEXTBOX";
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool keepGoing = ValidateMilesDriven();

            if (keepGoing)
            {
                keepGoing = ValidateGallonsUsed();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                CalculateMPG();
            }
            else
            {
                return;
            }
        }

        private bool ValidateMilesDriven()
        {
            bool result;
            bool retVal = true;
            decimal milesDriven;

            if (txtMilesDriven.Text.Trim() == "")
            {                               //  Check for no input in md textbox
                ShowMessage("No Value Inputted For Miles Driven TextBox", NIIT);

                ClearAndSetFocusToMilesDrivenTextBox();
                retVal = false;
            }
            //  There was input. First check if input was numeric
            else
            {
                result = Decimal.TryParse(txtMilesDriven.Text, out  milesDriven);
                if (!result)
                {
                    ShowMessage("Non-Numeric Value Inputted For Miles Driven TextBox", NNIIT);

                    ClearAndSetFocusToMilesDrivenTextBox();
                    retVal = false;
                }
                //  Input was numeric. Make sure input is within range
                else if ((milesDriven < MINMILES) || (milesDriven > MAXMILES))
                {
                    ShowMessage("Out-Of-Range Value Inputted For Miles Driven TextBox", OORIT);

                    ClearAndSetFocusToMilesDrivenTextBox();
                    retVal = false;
                }
            }

            return retVal;
        }

        private bool ValidateGallonsUsed()
        {
            bool result;
            bool retVal = true;
            decimal gallonsUsed;

            if (txtGallonsUsed.Text.Trim() == "")
            {                               //  Check for no input in gu textbox
                ShowMessage("No Value Inputted For Gallons Used TextBox", NIIT);

                ClearAndSetFocusToGallonsUsedTextBox();
                retVal = false;
            }
            //  There was input. First check if input was numeric
            else
            {
                result = Decimal.TryParse(txtGallonsUsed.Text, out gallonsUsed);
                if (!result)
                {
                    ShowMessage("Non-Numeric Value Inputted For Gallons Used TextBox", NNIIT);

                    ClearAndSetFocusToGallonsUsedTextBox();
                    retVal = false;
                }
                //  Input was numeric. Make sure input is within range
                else if ((gallonsUsed < MINGALLS) || (gallonsUsed > MAXGALLS))
                {
                    ShowMessage("Out-Of-Range Value Inputted For GallonsUsed TextBox", OORIT);

                    ClearAndSetFocusToGallonsUsedTextBox();
                    retVal = false;
                }
            }

            return retVal;
        }

        private void ClearAndSetFocusToMilesDrivenTextBox()
        {
            txtMilesDriven.Text = "";
            txtMilesDriven.Focus();
        }

        private void ClearAndSetFocusToGallonsUsedTextBox()
        {
            txtGallonsUsed.Text = "";
            txtGallonsUsed.Focus();
        }

        private void CalculateMPG()
        {
            decimal milesDriven;
            decimal gallonsUsed;
            decimal mpg = 0m;

            try
            {
                milesDriven = Convert.ToDecimal(txtMilesDriven.Text);
                gallonsUsed = Convert.ToDecimal(txtGallonsUsed.Text);
                mpg = milesDriven / gallonsUsed;
                txtMilesPerGallon.Text = mpg.ToString("n2");
            }
            catch (FormatException fe)
            {
                ShowMessage("Error" + fe.Message, "ILLEGAL INPUT!");
            }
            catch (DivideByZeroException dbze)
            {
                ShowMessage("Error" + dbze.Message, "ILLEGAL DIVIDE BY ZERO!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtMilesDriven.Text    = "";
            txtGallonsUsed.Text    = "";
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
    }
}
