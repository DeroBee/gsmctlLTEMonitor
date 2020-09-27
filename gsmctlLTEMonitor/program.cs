using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsmctlLTEMonitor
{
	class program
	{
		[STAThread]
		public static void Main(string[] args)
        {
			Application.EnableVisualStyles();
			Application.Run(new FrontEnd());
		}
		
	}
}
