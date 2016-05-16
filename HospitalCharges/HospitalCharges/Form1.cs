using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Program    :   Hospital Charges
// Developer  :   Mikael Taylor
// Date       :   3/4/2016
// Description:   This program allows a user to enter various hospital charges such as
//                days stayed, medication charge, surgical charge, rehabilitation charge,
//                and calculates the fees for each category(stay, and misc) before writing
//                them to a text file with a default name of charges.txt.  It also allows the
//                user to enter a time and date, otherwise it populates that data when the form
//                is initialized and allows the user to simply keep the time/date at it's default
//                setting. It's methods are modular, and only called on clicking the submit button.
//                It also utilizes keypress validation, which has proven superior to the other
//                methods of validation thus far, for each textbox aside from date/time textboxes.
namespace HospitalCharges
{
    public partial class HospitalCharges : Form
    {
        private double dayCharge;//Daily base charge
        private double medCharge;//Medication charges
        private double surgCharge;//Surgical charges
        private double labCharge;//Lab Fees
        private double rehabCharge;//Physical rehabilitation charges
        private double days;//Days stayed
        private double stayCharges;//Stay charges
        private double miscCharges;//Misc charges
        private double totalCharges;//Total charges
        public HospitalCharges()
        {
            InitializeComponent();
            this.txtDateInput.Text = DateTime.Today.ToString("MM/dd/yyyy");
            //Set the default date
            this.txtTimeInput.Text = DateTime.Now.ToString("hh:mm:ss tt");
            //Set the default time
        }
        public void CalcStayCharges()
        {//We'll use CalcStayCharges to give us the stay charges based on number of days stayed multiplied by the dayCharge.
            dayCharge = 350;
            //dayCharge is the $350 a day that is the daily base charge.
            days = Double.Parse(txtDaysInput.Text);
            //Number of days set by user input. We'll parse it here.
            stayCharges = dayCharge * days;
            //Stay Charges are simply the dayCharge multiplied by days stayed.
        }
        public void CalcMiscCharges()
        {//We'll use CalcMiscCharges to calculate the total misc charges provided by the user.
            medCharge = double.Parse(txtMedInput.Text);
            //Medication charges provided by user input.
            surgCharge = double.Parse(txtSurgicalInput.Text);
            //Surgical charges provided by user input.
            labCharge = double.Parse(txtLabInput.Text);
            //Lab fees provided by user input.
            rehabCharge = double.Parse(txtRehabInput.Text);
            //Physical rehabilitation charges provided by user input.
            miscCharges = medCharge + surgCharge + labCharge + rehabCharge;
            //The sum of all these charges is the misc charges.
        }
        public void CalcTotalCharges()
        {//CalcTotalCharges calculates the total charges(Stay charges, and misc charges)
            totalCharges = stayCharges + miscCharges;
            //Total charges incurred.
        }
        public void writeFile()
        {
            if (txtDateInput.Text != null && txtTimeInput.Text != null && txtSurgicalInput.Text != null && txtRehabInput.Text != null && txtMedInput.Text != null && txtLabInput.Text != null && txtDaysInput.Text != null)
            {//If the textboxes aren't empty..
                try
                {//Try to..
                    DateTime dateTest;//Test the date format
                    if (DateTime.TryParseExact(txtDateInput.Text, "MM/dd/yyy", null, System.Globalization.DateTimeStyles.None, out dateTest) == false)
                    {
                        MessageBox.Show("Incorrect Date Entry.  Try again with valid MM/DD/YYYY input, or leave at default.");
                        this.txtDateInput.Text = DateTime.Today.ToString("MM/dd/yyyy");
                        //Set back to the default date  
                    }
                    DateTime timeTest;//Test the time format
                    if (DateTime.TryParseExact(txtTimeInput.Text, "hh:mm:ss tt", null, System.Globalization.DateTimeStyles.None, out timeTest) == false)
                    {
                        MessageBox.Show("Incorrect Time Entry.  Try again with valid hh:mm:ss AM/PM input, or leave at default");
                        this.txtTimeInput.Text = DateTime.Now.ToString("hh:mm:ss tt");
                        //Set back to the default time          
                    }

                    //Bring in user input for the quantity to be written.
                    saveFileDialog.FileName = "charges.txt";
                    saveFileDialog.Filter = "Text Files(TXT)|*.TXT";
                    saveFileDialog.ShowDialog();
                    //Ask the user where to save the file.
                    string file = saveFileDialog.FileName;
                    //Put the filename in a variable so that we can use it.
                    StreamWriter writer = new StreamWriter(file);
                    //Use StreamWriter so that we can write to the file.
                    writer.WriteLine(txtDateInput.Text);//Write the correct text to the file
                    writer.WriteLine(txtTimeInput.Text);//Write the correct text to the file
                    writer.WriteLine("Stay Charges : " + stayCharges);//Write the correct text to the file
                    writer.WriteLine("Misc Charges : " + miscCharges);//Write the correct text to the file
                    writer.WriteLine("Total Charges: " + totalCharges);//Write the correct text to the file
                    writer.Close();//Close the stream writer
                    //Close the streamwriter
                }//end try
                catch (Exception ex)
                {//If an exception occurs..
                    MessageBox.Show("Error Code: " + ex);
                    //Tell me what happened.
                }//close catch
            }
            else
            {
                MessageBox.Show("Please enter valid data in ALL of the text boxes.");
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {//When the user clicks the submit button..
            CalcStayCharges();
            //Calculate the stay charges
            CalcMiscCharges();
            //Calculate the misc charges
            CalcTotalCharges();
            //Calculate the total charges
            writeFile();
            //Write the file to charges.txt
        }
        //Keypress validation for each textbox is below.
        private void txtDaysInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("You will need to enter a correct number of days stayed.");
            }
        }

        private void txtMedInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("You will need to enter a correct amount of medication charges in decimal format without the currency symbol($).");
            }

        }

        private void txtSurgicalInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("You will need to enter a correct amount of surgical charges in decimal format without the currency symbol($).");
            }
        }

        private void txtRehabInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("You will need to enter a correct amount of physical rehabilitation charges in decimal format without the currency symbol($).");
            }
        }

        private void txtLabInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("You will need to enter a correct amount of lab fee in decimal format without the currency symbol($).");
            }
        }



    }

}
