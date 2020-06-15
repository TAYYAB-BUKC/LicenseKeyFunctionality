using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseKey_Functionality
{
	public partial class LicenseForm : Form
	{
		public int TotalDaysLeft { get; set; }
		public LicenseForm()
		{
			InitializeComponent();			
		}

		private void LicenseForm_Load(object sender, EventArgs e)
		{
			TrialMessageLabel.Text = "You have " + TotalDaysLeft + " Days left in your Trial Period";

			if (TotalDaysLeft > 0)
			{
				ExitButton.Text = "Continue Trial";
			}
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			CheckDaysOnClosing(true);
		}

		private void CheckDaysOnClosing(bool closeForm)
		{
			//Program.mainForm.Hide();
			if (TotalDaysLeft == 0)
			{
				Application.Exit();
			}
			if (closeForm)
			{
				this.Close();
			}
		}

		private void LicenseForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			CheckDaysOnClosing(false);
		}
	}
}
