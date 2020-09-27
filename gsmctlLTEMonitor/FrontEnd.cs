using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsmctlLTEMonitor
{
	public partial class FrontEnd : Form
	{
		public FrontEnd()
		{
			InitializeComponent();
		}

        private void buttonConnect_Click(object sender, EventArgs e)
        {
			DataHandling.Connect(this.textBoxIPPort.Text, this.textBoxUser.Text, this.textBoxPassword.Text);
        }
    }
}
