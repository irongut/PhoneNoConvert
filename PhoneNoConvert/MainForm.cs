using PhoneNumbers;
using System;
using System.Windows.Forms;

namespace PhoneNoConvert
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            string phoneNo = PhoneNoTextBox.Text.Trim();
            string countryCode = CountryCodeTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(phoneNo) || string.IsNullOrWhiteSpace(countryCode))
            {
                MessageBox.Show("A phone number and a country code are required.");
            }
            else
            {
                try
                {
                    PhoneNumberUtil phoneUtil = PhoneNumberUtil.GetInstance();
                    PhoneNumber phone = phoneUtil.Parse(phoneNo, countryCode);
                    ResultsTextBox.Text += $"Original No: {phoneNo}, E.164 Format: {phoneUtil.Format(phone, PhoneNumberFormat.E164)}{Environment.NewLine}";
                }
                catch (Exception ex)
                {
                    ResultsTextBox.Text += $"{Environment.NewLine}ERROR converting number {phoneNo}: {ex.Message}{Environment.NewLine}";
                }
            }
        }
    }
}
