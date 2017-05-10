using Algorithms.util;
using DevComponents.DotNetBar.Controls;
using Project_Cadimuns.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Cadimuns
{
	public partial class Main : DevComponents.DotNetBar.Office2007Form
	{

		ModelContainer modelContainer = new ModelContainer();
		Connection connection;

		SqlConnection myConnection = null;
		public Main()
		{
			InitializeComponent();
		}

		private void mskTextBox_KeyDown(object sender, KeyEventArgs e)
		{



		}

		private void mskTextBox_Validating(object sender, CancelEventArgs e)
		{
			Regex addressIP = new Regex(RegexExpressions.AddressIP);
			bool valid = addressIP.IsMatch(mskAddressIP.Text.Replace(",", "."));
			if (valid)
			{
				errorProvidermskAddress.Clear();
			}
			else
			{
				errorProvidermskAddress.SetError(mskAddressIP, "Error");
			}
			//e.Cancel = !s;
		}

		private void comboBoxDataBase_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}



		private void Main_Load(object sender, EventArgs e)
		{
			connection = (Connection)bindingSourceConnection.AddNew();
		}
		private void bindingSourceConnection_AddingNew(object sender, AddingNewEventArgs e)
		{

		}

		private void bindingSourceConnection_BindingComplete(object sender, BindingCompleteEventArgs e)
		{

		}

		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{

		}

		private void bindingSourceConnection_DataError(object sender, BindingManagerDataErrorEventArgs e)
		{

		}

		private void bindingSourceConnection_CurrentChanged(object sender, EventArgs e)
		{

		}
		private void comboBoxDataBase_KeyDown(object sender, KeyEventArgs e)
		{
			e.SuppressKeyPress = true;
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			TestConnection();
			//connection.Port = "88";
			//bindingSourceConnection.EndEdit();
			//modelContainer.SaveChanges();
			//modelContainer.ConnectionSet.Add(connection);

		}

		public void TestConnection()
		{
			connection.Address = connection.Address.Replace(',', '.');
			//MyConnection = new SqlConnection("Data Source=ServerName;Initial Catalog=DataBaseName;User id=UserName;Password=Secret;");
			myConnection = new SqlConnection($"Data Source={connection.Address};User id={connection.UserName};Password={connection.Password};");
			Task result = myConnection.OpenAsync();
			result.ContinueWith((task) =>
			{
				if (task.Exception.InnerException != null)
				{
					MessageBox.Show("Um erro ocorreu ao tentar estabelecer a conexão com o banco de dados.", "Tentativa de conexão", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
				}
			});
		}
		Task animationProgress;
		CancellationTokenSource cancellationTokenProgress;
		public void configureTaskAnimation()
		{
			cancellationTokenProgress = new CancellationTokenSource();
			cancellationTokenProgress.CancelAfter(TimeSpan.FromSeconds(10));
			cancellationTokenProgress.Token.Register(DisableAnimation);
			circularProgress.Visible = true;
			circularProgress.Value = 0;
			labelProcessamento.Visible = true;
	
			animationProgress = new Task(() => 
			{
				int increment = 1;
				while (!cancellationTokenProgress.IsCancellationRequested)
				{
					circularProgress.Value += increment;			
					Thread.Sleep(10);
					if (circularProgress.Value == 100)
						circularProgress.Value = 0;
					//	increment = -1;
					//if (circularProgress.Value == 0)
					//	increment = 1;
				}
			}, cancellationTokenProgress.Token);
			animationProgress.Start();
		}

		public void DisableAnimation()
		{
			labelProcessamento.Visible = false;
			circularProgress.Visible = false;
		}

		private void buttonTaskTest_Click(object sender, EventArgs e)
		{

			configureTaskAnimation();
		}

		private void buttonX1_Click(object sender, EventArgs e)
		{
			cancellationTokenProgress.Cancel();
		}
	}
	//SqlDataReader dataReader;
	//SqlCommand command = new SqlCommand("SELECT * FROM Sys.Databases", MyConnection);
	//dataReader = command.ExecuteReader();

	//List<String> dataBaseNames = new List<string>();
	//int i = 1;
	//while (dataReader.Read())
	//{
	//	DataBase dataBase = new DataBase();
	//	dataBase.Id = i++;
	//	dataBase.Name = dataReader["name"].ToString();
	//	dataBase.TableId = int.Parse(dataReader["database_id"].ToString());
	//	bindingSourceDataBase.Add(dataBase);

	//}



	////while (dataReader.Read())
	////{
	////	MessageBox.Show(dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2));
	////}
	//dataReader.Close();
	//command.Dispose();
	//MyConnection.Close();


}
