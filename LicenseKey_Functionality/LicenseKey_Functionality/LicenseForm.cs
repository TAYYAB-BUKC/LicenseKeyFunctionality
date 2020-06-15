using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseKey_Functionality
{
	public partial class LicenseForm : Form
	{
		private static string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
		public int TotalDaysLeft { get; set; }
		public LicenseForm()
		{
			InitializeComponent();
		}

		private void LicenseForm_Load(object sender, EventArgs e)
		{
			NameTextBox.Focus();
			TrialMessageLabel.Text = "You have " + TotalDaysLeft + " Days left in your Trial Period";

			if (TotalDaysLeft > 0)
			{
				ExitButton.Text = "Continue Trial";
			}
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			CheckDaysOnClosing();
		}

		private void CheckDaysOnClosing()
		{
			//Program.mainForm.Hide();
			if (TotalDaysLeft == 0)
			{
				Application.Exit();
			}
			else
			{
				this.Close();
			}
		}


		private void VerifyButton_Click(object sender, EventArgs e)
		{
			if (IsValidated())
			{
				UpdateDetails();
			}
		}

		private void UpdateDetails()
		{
			using (SqlConnection sql = new SqlConnection(connectionString))
			{
				using (SqlCommand cmd = new SqlCommand("Update License set Name=@Name,ProductKey=@ProductKey", sql))
				{
					sql.Open();

					cmd.Parameters.AddWithValue("@Name", NameTextBox.Text);
					cmd.Parameters.AddWithValue("@ProductKey", LicenseKeyMaskedTextBox.Text);

					cmd.ExecuteNonQuery();
					MessageBox.Show("Product Key is valid. Now yo can use the system for lifetime.\nThanks for chosing us.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
			}
			
		}

		private bool IsValidated()
		{
			if (NameTextBox.Text.Trim() == String.Empty)
			{
				MessageBox.Show("Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				NameTextBox.Focus();
				return false;
			}
			if (!LicenseKeyMaskedTextBox.MaskCompleted)
			{
				MessageBox.Show("Product Key should be 25 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				LicenseKeyMaskedTextBox.Focus();
				return false;
			}
			else
			{
				bool isValid = ValidateProductKey(LicenseKeyMaskedTextBox.Text);
				if (!isValid)
				{
					MessageBox.Show("Invalid Product Key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					LicenseKeyMaskedTextBox.Focus();
					return false;
				}
			}
			return true;
		}

		private bool ValidateProductKey(string productKey)
		{

			//15 Different of Product Keys

			//3T9A0-Y4X6I-B9G7D-S6Q2O-U1K48
			//9T1AL-Y7C6J-B5P3D-S2Z4O-M5V9X
			//2T5A1-YZX37-B8F9D-S4W3O-O1H6N
			//1T7A0-Y3L7R-B5Q9D-S4X3O-J6C4K
			//4T3AX-Y9Z7L-B2R3D-S1P8O-K0U1X


			//2T5A1-Y7C6J-B5Q9D-S2Z4O-J6C4K
			//9T1AL-Y9Z7L-B4Q1D-S6Q2O-O1H6N
			//4T3AX-Y3L7R-B2R3D-S4X3O-M5V9X
			//1T7A0-YZX37-B9G7D-S3R4O-U1K7J
			//3T9A0-Y4X6I-B8F9D-S2N8O-K0U1X


			//2T5A1-Y3L7R-B2R3D-S6Q2O-O1H6N
			//9T1AL-YZX37-B9G7D-S2Z4O-J6C4K
			//3T9A0-Y7C6J-B5Q9D-S3R4O-U1K7J
			//1T7A0-Y9Z7L-B4Q1D-S4W3O-M5V9X
			//0T8AI-Y1H9I-B3Z7D-S4V9O-X0E6W

			StringBuilder builder = new StringBuilder();

			builder.Append(productKey.Substring(1, 1));	  //T
			builder.Append(productKey.Substring(3, 1));	  //A
			builder.Append(productKey.Substring(6, 1));	  //Y
			builder.Append(productKey.Substring(6, 1));	  //Y
			builder.Append(productKey.Substring(3, 1));	  //A
			builder.Append(productKey.Substring(12, 1));  //B
			builder.Append(productKey.Substring(16, 1));  //D
			builder.Append(productKey.Substring(22, 1));  //O
			builder.Append(productKey.Substring(18, 1));   //S
			builder.Append(productKey.Substring(1, 1));   //T

			if (builder.ToString() != "TAYYABDOST")
			{
				return false;
			}
			return true;
		}

		private void LicenseForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			CheckDaysOnClosing();
		}
	}
}
