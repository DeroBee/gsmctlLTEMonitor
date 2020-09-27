using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace gsmctlLTEMonitor
{
	class Connection : IDisposable
	{
		private string ip;
		private string username;
		private string password;

		private ConnectionInfo connectionInfo;
		private SshClient client;
		private ShellStream stream;

		public Connection(string ip, string username, string password)
        {
			this.ip = ip;
			this.username = username;
			this.password = password;
        }

		/// <summary>
		/// Open a connection to the SSH router.
		/// </summary>
		/// <returns>
		/// <list type="bullet">
		/// <item><term>true</term><description>A connection was successfully established</description></item>
		/// <item><term>false</term><description>No connection could be established.</description></item></list>
		/// </returns>
		public bool Connect()
		{
			// get connection info

			// build connectionInfo
			// get passwort with windowprompt
			this.connectionInfo = new PasswordConnectionInfo(this.ip, this.username, this.password);

			// establish connection
			this.client = new SshClient(this.connectionInfo);
            this.client.Connect();

			// create ShellStream
			this.stream = this.client.CreateShellStream("", 80, 0, 0, 0, 1000);
			return true;
		}

		public void Dispose()
		{
            if (this.client.IsConnected)
            {
				this.client.Dispose();
				return;
            }
            else
            {
				return;
            }
		}


		/// <summary>
		/// Gets SINR RSRQ RSRQ and GSM Signal Level from the router
		/// </summary>
		/// <returns>A datarow containing all the requested data</returns>
		public DataRow GetData()
		{
			throw new NotImplementedException();
		}


		/// <summary>
		/// Sends the command via the SSH connection to the router and waits for the output
		/// </summary>
		/// <param name="command">SSH command to the router</param>
		/// <returns>Router output </returns>
		public string RunCommand(string command) 
		{
			SshCommand com = this.client.CreateCommand(command);
			com.Execute();

			return com.Result; 
		}
	}
}
