﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseKey_Functionality
{
	static class Program
	{
		public static MainForm mainForm; 
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//mainForm = new MainForm();
			//Application.Run(mainForm);
			Application.Run(new MainForm());
		}
	}
}
