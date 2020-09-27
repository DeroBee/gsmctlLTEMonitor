using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsmctlLTEMonitor
{
	static class DataHandling
	{
		static private Connection c;

		static public void Connect(string ip, string username, string password)
        {
			c = new Connection(ip, username, password);
            try
            {
				c.Connect();
				Console.WriteLine(c.RunCommand("gsmctl -qWZM"));
            }catch(Exception e)
            {
				Console.WriteLine(e.Message);
            }
            finally
            {
				c.Dispose();
            }
				// send test command
			
			
        }


	}
}
