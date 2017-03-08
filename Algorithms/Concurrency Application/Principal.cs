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
using static Concurrency_Application.Principal;

namespace Concurrency_Application
{

	//Aba Main
	public partial class Principal : Form
	{
		public enum operation { INC_COUNT, SET_PERSON, GET_PERSON, GET_COUNT }

		public readonly string[] operationDescription =
			{
				"Incrementar o valor do contador.",
				"Setar a pessoa.",
				"Obter a pessoa.",
				"Obter o valor do contador."
			};

		public SharedResource sharedResource = new SharedResource();

		public string GetOperationDescription(operation op)
		{
			return operationDescription[(int)op];
		}

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


		private void btSameTime_Click(object sender, EventArgs e)
		{
			button1_Click(null, null);
			buttonAsyncSecond_Click(null, null);

		}

		private void btnLancarNormal_Click(object sender, EventArgs e)
		{

		}

		private void TaskReport(Task t)
		{
			t.ContinueWith((x) =>
			{
			});
		}


	}

	public class TaskDescrption
	{
		public int ID { get; set; }

		public operation Operation { get; set; }
	}
}
