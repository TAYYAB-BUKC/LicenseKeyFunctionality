namespace LicenseKey_Functionality
{
	partial class LicenseForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TrialMessageLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.LicenseKeyMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.VerifyButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// TrialMessageLabel
			// 
			this.TrialMessageLabel.AutoSize = true;
			this.TrialMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TrialMessageLabel.ForeColor = System.Drawing.Color.Blue;
			this.TrialMessageLabel.Location = new System.Drawing.Point(45, 27);
			this.TrialMessageLabel.Name = "TrialMessageLabel";
			this.TrialMessageLabel.Size = new System.Drawing.Size(512, 31);
			this.TrialMessageLabel.TabIndex = 1;
			this.TrialMessageLabel.Text = "You have 40 Days left in your Trial Period";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(46, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Name: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(31, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(141, 25);
			this.label3.TabIndex = 3;
			this.label3.Text = "Product Key: ";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::LicenseKey_Functionality.Properties.Resources.licenseKey;
			this.pictureBox1.Location = new System.Drawing.Point(563, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(225, 236);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// LicenseKeyMaskedTextBox
			// 
			this.LicenseKeyMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LicenseKeyMaskedTextBox.Location = new System.Drawing.Point(178, 155);
			this.LicenseKeyMaskedTextBox.Mask = ">AAAAA-AAAAA-AAAAA-AAAAA-AAAAA";
			this.LicenseKeyMaskedTextBox.Name = "LicenseKeyMaskedTextBox";
			this.LicenseKeyMaskedTextBox.Size = new System.Drawing.Size(369, 29);
			this.LicenseKeyMaskedTextBox.TabIndex = 1;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameTextBox.Location = new System.Drawing.Point(178, 95);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(369, 29);
			this.NameTextBox.TabIndex = 0;
			// 
			// VerifyButton
			// 
			this.VerifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VerifyButton.Location = new System.Drawing.Point(196, 203);
			this.VerifyButton.Name = "VerifyButton";
			this.VerifyButton.Size = new System.Drawing.Size(158, 45);
			this.VerifyButton.TabIndex = 2;
			this.VerifyButton.Text = "Verify";
			this.VerifyButton.UseVisualStyleBackColor = true;
			this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExitButton.Location = new System.Drawing.Point(376, 203);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(158, 45);
			this.ExitButton.TabIndex = 3;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// LicenseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 266);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.VerifyButton);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.LicenseKeyMaskedTextBox);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TrialMessageLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LicenseForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LicenseForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LicenseForm_FormClosed);
			this.Load += new System.EventHandler(this.LicenseForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TrialMessageLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MaskedTextBox LicenseKeyMaskedTextBox;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.Button VerifyButton;
		private System.Windows.Forms.Button ExitButton;
	}
}