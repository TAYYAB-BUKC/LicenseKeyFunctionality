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
	public partial class MainForm : Form
	{
		private static string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			ValidateProductKey();
		}

		private void ValidateProductKey()
		{
			ProductKey keyDetails = GetDetails();
			int totalDaysLeft = 0;

			if (keyDetails.Key == String.Empty)
			{
				if (keyDetails.TrialPeriod == new DateTime(1900,1,1))
				{
					UpdateTrialPeriod();

					totalDaysLeft = FindTrialDaysLeft(DateTime.Now.Date.AddMonths(1),DateTime.Now.Date);
				}
				else
				{
					totalDaysLeft = FindTrialDaysLeft(keyDetails.TrialPeriod, DateTime.Now.Date);
				}

				ShowLicenseForm(totalDaysLeft);
			}
		}

		private void ShowLicenseForm(int totalDaysLeft)
		{
			//Program.mainForm.Hide();
			LicenseForm licenseForm = new LicenseForm();
			licenseForm.TotalDaysLeft = totalDaysLeft;
			licenseForm.ShowDialog();

		}

		private int FindTrialDaysLeft(DateTime trialDate, DateTime currentDate)
		{
			int days = Convert.ToInt32((trialDate - currentDate).TotalDays);
			return days < 0 ? 0: days;
		}

		private void UpdateTrialPeriod()
		{
			using (SqlConnection sql = new SqlConnection(connectionString))
			{
				using (SqlCommand cmd = new SqlCommand("Update License set TrialExpiryPeriod=@TrialExpiryPeriod", sql))
				{
					sql.Open();

					cmd.Parameters.AddWithValue("@TrialExpiryPeriod", DateTime.Now.Date.AddMonths(1));

					cmd.ExecuteNonQuery();
				}
			}
		}

		private ProductKey GetDetails()
		{
			ProductKey productKey = new ProductKey();

			using (SqlConnection sql = new SqlConnection(connectionString))
			{
				using (SqlCommand cmd = new SqlCommand("select * from License",sql))
				{
					sql.Open();

					SqlDataReader reader = cmd.ExecuteReader();

					if (reader.HasRows)
					{

						reader.Read();

						productKey.Name = reader[0].ToString();
						productKey.Key = reader[1].ToString();
						productKey.TrialPeriod = (DateTime)reader[2];

						return productKey;
					}
					else
					{
						return new ProductKey();
					}
				}
			}
		}
	}
}
