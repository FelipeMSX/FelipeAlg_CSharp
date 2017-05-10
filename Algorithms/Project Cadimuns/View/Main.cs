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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Cadimuns
{
	public partial class Main : DevComponents.DotNetBar.Office2007Form
	{

		ModelContainer modelContainer = new ModelContainer();
		Connection connection;
		public Main()
		{
			InitializeComponent();
		}

		private void mskTextBox_KeyDown(object sender, KeyEventArgs e)
		{



		}

		private void mskTextBox_Validating(object sender, CancelEventArgs e)
		{

			Regex addressIP = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
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

		private void comboBoxDataBase_KeyDown(object sender, KeyEventArgs e)
		{
			e.SuppressKeyPress = true;
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			connection.Port = "88";
			bindingSourceConnection.EndEdit();
			modelContainer.SaveChanges();

		}

		private void Main_Load(object sender, EventArgs e)
		{
			connection = (Connection)bindingSourceConnection.AddNew();

			SqlConnection MyConnection;

			String IP;
			String userName;
			string password;
			string database;
			//MyConnection = new SqlConnection("Data Source=ServerName;Initial Catalog=DataBaseName;User id=UserName;Password=Secret;");
			MyConnection = new SqlConnection("Data Source=187.33.29.42;User id=usr_contabilis;Password=q1w2e3r4t5;");
			SqlDataReader dataReader;
			MyConnection.Open();

			SqlCommand command = new SqlCommand("SELECT * FROM Sys.Databases", MyConnection);
			dataReader = command.ExecuteReader();

			List<String> dataBaseNames = new List<string>();
			int i = 1;
			while (dataReader.Read())
			{
				DataBase dataBase = new DataBase();
				dataBase.Id = i++;
				dataBase.Name = dataReader["name"].ToString();
				dataBase.TableId = int.Parse(dataReader["database_id"].ToString());
				bindingSourceDataBase.Add(dataBase);

			}



			//while (dataReader.Read())
			//{
			//	MessageBox.Show(dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2));
			//}
			dataReader.Close();
			command.Dispose();
			MyConnection.Close();
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
	}
}
