using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsmctlLTEMonitor
{
	static class Connection
	{

		/// <summary>
		/// Open a connection to the SSH router.
		/// </summary>
		/// <returns>
		/// <list type="bullet">
		/// <item><term>true</term><description>A connection was successfully established</description></item>
		/// <item><term>false</term><description>No connection could be established.</description></item></list>
		/// </returns>
		static public bool Connect()
		{
			throw new NotImplementedException();
		}


		/// <summary>
		/// Gets SINR RSRQ RSRQ and GSM Signal Level from the router
		/// </summary>
		/// <returns>A datarow containing all the requested data</returns>
		static public DataRow GetData()
		{
			throw new NotImplementedException();
		}


		/// <summary>
		/// Sends the command via the SSH connection to the router and waits for the output
		/// </summary>
		/// <param name="command">SSH command to the router</param>
		/// <returns>Router output </returns>
		static public string RunCommand(string command) 
		{
			throw new NotImplementedException();
		}
	}
}
