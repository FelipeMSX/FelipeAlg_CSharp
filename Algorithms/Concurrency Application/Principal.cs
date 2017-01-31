using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concurrency_Application
{
	public partial class Principal : Form
	{
		public Principal()
		{
			InitializeComponent();
			st();
		}

		public void st()
		{
			TaskStudy task = new TaskStudy();
			int  x1 =  task.Somar(4).Result;
			int x2 = task.Somar(4).Result;
			int x3 = task.Somar(4).Result;
			int x4 = task.Somar(4).Result;

		}
	}
}
