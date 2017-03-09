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

		public readonly string[] operationDescriptionNormal =
			{
				"Incrementar o valor do contador.",
				"Setar a pessoa.",
				"Obter a pessoa.",
				"Obter o valor do contador."
			};

		public SharedResource sharedResource = new SharedResource();


		public int SleepTime;

		public string GetOperationDescription(operation op)
		{
			return operationDescriptionNormal[(int)op];
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
			RadioButton selectedRadioButton = GetSelectedRadioButton(gbTaskNormal);
			operation currentOperation = getNormalTaskOperation(selectedRadioButton);

			Task<TaskDescrption> task = new Task<TaskDescrption>(()=> 
			{
				switch (currentOperation)
				{
					case (operation.INC_COUNT):
						IncrementCount();
						break;
					case (operation.SET_PERSON):
						SetPerson();
						break;
					case (operation.GET_PERSON):
						IncrementCount();
						break;
					case (operation.GET_COUNT):
						GetCount();
						break;
				}

				return new TaskDescrption(sharedResource.ID++, currentOperation,sharedResource.Count);
			});

			TaskReport(task);
			task.Start();

		}

		private void btnLancarBloqueante_Click(object sender, EventArgs e)
		{
			Task<TaskDescrption> task = new Task<TaskDescrption>(() =>
			{
				int taskID = sharedResource.ID++;
				sharedResource.IncrementWithLockInstance();

				return new TaskDescrption(taskID, operation.GET_COUNT,sharedResource.Count);
			});

			TaskReport(task);
			task.Start();
		}

		private void TaskReport(Task<TaskDescrption> task)
		{

			task.ContinueWith((x) =>
			{
				this.BeginInvoke((Action)delegate ()
				   {
					   txtConsoleLock.AppendText($"Task ID: {x.Result.ID} ------- Task Description: {x.Result.Operation} ------- Task Result: {x.Result.ResultOperation}  \n");
				   });

			});
		
		}


		private operation getNormalTaskOperation(RadioButton radioButton)
		{
			if (rbIncCount == radioButton)
			{
				return operation.INC_COUNT;
			}
			else if (rbSetPerson == radioButton)
			{
				return operation.SET_PERSON;
			}
			else if (rbGetPerson == radioButton)
			{
				return operation.GET_PERSON;
			}else
			{
				return operation.GET_COUNT;
			}
		}

		/// <summary>
		/// Dado um determinado groupBox retorna o elemento que está selecionado.
		/// </summary>
		private RadioButton GetSelectedRadioButton(GroupBox groupBox) => (RadioButton)groupBox.Controls.Cast<Control>().First((x) => x is RadioButton && ((RadioButton)x).Checked);
		

		/// <summary>
		/// Ação da opção incrementar contador sem bloquear o recurso.
		/// </summary>
		public void IncrementCount() => sharedResource.IncrementNormal();

		/// <summary>
		/// Coloca uma pessoa do recurso compartihado  sem bloquear o recurso.
		/// </summary>
		public void SetPerson() => sharedResource.SetPersonNormal("Felipe", 18);

		/// <summary>
		/// Obtém uma pessoa do recurso compartilhado  sem bloquear o recurso.
		/// </summary>
		/// <returns></returns>
		public Person GetPerson() => sharedResource.Person;

		/// <summary>
		/// Obtém o contador do recurso compartilhado sem bloquear o recurso.
		/// </summary>
		/// <returns></returns>
		public int GetCount() => sharedResource.Count;


	}

	public class TaskDescrption
	{
		public int ID { get; set; }

		public operation Operation { get; set; }

		public object ResultOperation { get; set; }

		public TaskDescrption(int ID, operation op, object resultOperation)
		{
			this.ID = ID;
			this.Operation = op;
			this.ResultOperation = resultOperation;
		}
	}
}
