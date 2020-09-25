namespace gsmctlLTEMonitor
{
	partial class FrontEnd
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageConnect = new System.Windows.Forms.TabPage();
			this.tabPageData = new System.Windows.Forms.TabPage();
			this.tabPageSettings = new System.Windows.Forms.TabPage();
			this.labelIPPort = new System.Windows.Forms.Label();
			this.labelUser = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.labelPasswort = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.maskedTextIPPort = new System.Windows.Forms.MaskedTextBox();
			this.buttonConnect = new System.Windows.Forms.Button();
			this.labelConnectionState = new System.Windows.Forms.Label();
			this.buttonDisconnect = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPageConnect.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageConnect);
			this.tabControl1.Controls.Add(this.tabPageData);
			this.tabControl1.Controls.Add(this.tabPageSettings);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(776, 426);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPageConnect
			// 
			this.tabPageConnect.BackColor = System.Drawing.Color.White;
			this.tabPageConnect.Controls.Add(this.buttonDisconnect);
			this.tabPageConnect.Controls.Add(this.labelConnectionState);
			this.tabPageConnect.Controls.Add(this.buttonConnect);
			this.tabPageConnect.Controls.Add(this.maskedTextIPPort);
			this.tabPageConnect.Controls.Add(this.textBox2);
			this.tabPageConnect.Controls.Add(this.labelPasswort);
			this.tabPageConnect.Controls.Add(this.textBox1);
			this.tabPageConnect.Controls.Add(this.labelUser);
			this.tabPageConnect.Controls.Add(this.labelIPPort);
			this.tabPageConnect.Location = new System.Drawing.Point(4, 22);
			this.tabPageConnect.Name = "tabPageConnect";
			this.tabPageConnect.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageConnect.Size = new System.Drawing.Size(768, 400);
			this.tabPageConnect.TabIndex = 0;
			this.tabPageConnect.Text = "Connect";
			// 
			// tabPageData
			// 
			this.tabPageData.Location = new System.Drawing.Point(4, 22);
			this.tabPageData.Name = "tabPageData";
			this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageData.Size = new System.Drawing.Size(768, 400);
			this.tabPageData.TabIndex = 1;
			this.tabPageData.Text = "Data";
			this.tabPageData.UseVisualStyleBackColor = true;
			// 
			// tabPageSettings
			// 
			this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
			this.tabPageSettings.Name = "tabPageSettings";
			this.tabPageSettings.Size = new System.Drawing.Size(768, 400);
			this.tabPageSettings.TabIndex = 2;
			this.tabPageSettings.Text = "Settings";
			this.tabPageSettings.UseVisualStyleBackColor = true;
			// 
			// labelIPPort
			// 
			this.labelIPPort.AutoSize = true;
			this.labelIPPort.Location = new System.Drawing.Point(25, 38);
			this.labelIPPort.Name = "labelIPPort";
			this.labelIPPort.Size = new System.Drawing.Size(39, 13);
			this.labelIPPort.TabIndex = 0;
			this.labelIPPort.Text = "IP:Port";
			// 
			// labelUser
			// 
			this.labelUser.AutoSize = true;
			this.labelUser.Location = new System.Drawing.Point(37, 64);
			this.labelUser.Name = "labelUser";
			this.labelUser.Size = new System.Drawing.Size(27, 13);
			this.labelUser.TabIndex = 2;
			this.labelUser.Text = "user";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(70, 61);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(123, 20);
			this.textBox1.TabIndex = 3;
			// 
			// labelPasswort
			// 
			this.labelPasswort.AutoSize = true;
			this.labelPasswort.Location = new System.Drawing.Point(12, 90);
			this.labelPasswort.Name = "labelPasswort";
			this.labelPasswort.Size = new System.Drawing.Size(52, 13);
			this.labelPasswort.TabIndex = 4;
			this.labelPasswort.Text = "password";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(70, 87);
			this.textBox2.MaxLength = 64;
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(123, 20);
			this.textBox2.TabIndex = 5;
			// 
			// maskedTextIPPort
			// 
			this.maskedTextIPPort.Location = new System.Drawing.Point(70, 35);
			this.maskedTextIPPort.Mask = "000\\.000\\.000\\.000\\:00000";
			this.maskedTextIPPort.Name = "maskedTextIPPort";
			this.maskedTextIPPort.Size = new System.Drawing.Size(123, 20);
			this.maskedTextIPPort.TabIndex = 6;
			// 
			// buttonConnect
			// 
			this.buttonConnect.Location = new System.Drawing.Point(118, 113);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(75, 23);
			this.buttonConnect.TabIndex = 7;
			this.buttonConnect.Text = "Connect";
			this.buttonConnect.UseVisualStyleBackColor = true;
			// 
			// labelConnectionState
			// 
			this.labelConnectionState.BackColor = System.Drawing.Color.Red;
			this.labelConnectionState.Location = new System.Drawing.Point(89, 113);
			this.labelConnectionState.Name = "labelConnectionState";
			this.labelConnectionState.Size = new System.Drawing.Size(23, 23);
			this.labelConnectionState.TabIndex = 8;
			// 
			// buttonDisconnect
			// 
			this.buttonDisconnect.Location = new System.Drawing.Point(118, 142);
			this.buttonDisconnect.Name = "buttonDisconnect";
			this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
			this.buttonDisconnect.TabIndex = 9;
			this.buttonDisconnect.Text = "Disconnect";
			this.buttonDisconnect.UseVisualStyleBackColor = true;
			// 
			// FrontEnd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FrontEnd";
			this.Text = "FrontEnd";
			this.tabControl1.ResumeLayout(false);
			this.tabPageConnect.ResumeLayout(false);
			this.tabPageConnect.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageConnect;
		private System.Windows.Forms.TabPage tabPageData;
		private System.Windows.Forms.TabPage tabPageSettings;
		private System.Windows.Forms.Button buttonDisconnect;
		private System.Windows.Forms.Label labelConnectionState;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.MaskedTextBox maskedTextIPPort;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label labelPasswort;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label labelUser;
		private System.Windows.Forms.Label labelIPPort;
	}
}