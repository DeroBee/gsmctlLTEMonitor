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
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.labelConnectionState = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPasswort = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelIPPort = new System.Windows.Forms.Label();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.textBoxIPPort = new System.Windows.Forms.TextBox();
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
            this.tabPageConnect.Controls.Add(this.textBoxIPPort);
            this.tabPageConnect.Controls.Add(this.buttonDisconnect);
            this.tabPageConnect.Controls.Add(this.labelConnectionState);
            this.tabPageConnect.Controls.Add(this.buttonConnect);
            this.tabPageConnect.Controls.Add(this.textBoxPassword);
            this.tabPageConnect.Controls.Add(this.labelPasswort);
            this.tabPageConnect.Controls.Add(this.textBoxUser);
            this.tabPageConnect.Controls.Add(this.labelUser);
            this.tabPageConnect.Controls.Add(this.labelIPPort);
            this.tabPageConnect.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnect.Name = "tabPageConnect";
            this.tabPageConnect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnect.Size = new System.Drawing.Size(768, 400);
            this.tabPageConnect.TabIndex = 0;
            this.tabPageConnect.Text = "Connect";
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
            // labelConnectionState
            // 
            this.labelConnectionState.BackColor = System.Drawing.Color.Red;
            this.labelConnectionState.Location = new System.Drawing.Point(89, 113);
            this.labelConnectionState.Name = "labelConnectionState";
            this.labelConnectionState.Size = new System.Drawing.Size(23, 23);
            this.labelConnectionState.TabIndex = 8;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(118, 113);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 7;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(70, 87);
            this.textBoxPassword.MaxLength = 64;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(123, 20);
            this.textBoxPassword.TabIndex = 5;
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
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(70, 61);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(123, 20);
            this.textBoxUser.TabIndex = 3;
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
            // labelIPPort
            // 
            this.labelIPPort.AutoSize = true;
            this.labelIPPort.Location = new System.Drawing.Point(25, 38);
            this.labelIPPort.Name = "labelIPPort";
            this.labelIPPort.Size = new System.Drawing.Size(39, 13);
            this.labelIPPort.TabIndex = 0;
            this.labelIPPort.Text = "IP:Port";
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
            // textBoxIPPort
            // 
            this.textBoxIPPort.Location = new System.Drawing.Point(70, 35);
            this.textBoxIPPort.Name = "textBoxIPPort";
            this.textBoxIPPort.Size = new System.Drawing.Size(123, 20);
            this.textBoxIPPort.TabIndex = 10;
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
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label labelPasswort;
		private System.Windows.Forms.TextBox textBoxUser;
		private System.Windows.Forms.Label labelUser;
		private System.Windows.Forms.Label labelIPPort;
        private System.Windows.Forms.TextBox textBoxIPPort;
    }
}