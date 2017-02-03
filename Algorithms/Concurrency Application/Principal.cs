using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
		}

		public void st()
		{
		
	
			txtConsole.AppendText("\r\n Estamos Fora da Thread");
		}

		private  async void button1_Click(object sender, EventArgs e)
		{

			TaskStudy task = new TaskStudy();
			int result = await task.ObserveOneExceptionAsync();
			txtConsole.AppendText("\r\nAsync B1");

		}

		private async void buttonAsyncSecond_Click(object sender, EventArgs e)
		{

			TaskStudy task = new TaskStudy();
			int result = await task.ObserveOneExceptionAsync();
			txtConsole.AppendText("\r\nAsync B2");

		}

		private void btLoop_Click(object sender, EventArgs e)
		{
			var oteste = txtConsole.Text;
			int i = 0;
			while (i < 100000000)
			{
				i++;
			}
			txtConsole.AppendText(" \r\n Async Teste código bloqueando...");
		}

		public void teste()
		{

		}

		private void btSameTime_Click(object sender, EventArgs e)
		{
			button1_Click(null, null);
			buttonAsyncSecond_Click(null, null);

		}
	}
}
