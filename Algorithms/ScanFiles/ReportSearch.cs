using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanFiles
{
	public partial class ReportSearch : Form
	{
		private int matchCounts;
		private DataTable ReportsMatched;

		private void Initialize()
		{
			ReportsMatched = new DataTable();
			ReportsMatched.Columns.Add("nm_file", typeof(string));
			ReportsMatched.AcceptChanges();
		}
		public ReportSearch()
		{
			InitializeComponent();
			Initialize();
			dataGridViewResult.DataSource = ReportsMatched;
		}

		private void btnDirectory_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				txtDirectory.Text = folderBrowserDialog.SelectedPath;
				txtMatch.Focus();
			}

		}

		private void Reset()
		{
			ReportsMatched.Clear();
			tsTotal.Text = String.Empty;
			matchCounts = 0;
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			Reset();
			string directoryPath = txtDirectory.Text;
			String[] files = Directory.GetFiles(directoryPath);
			foreach (String filePath in files)
			{
				ReadFile(filePath);
			}

		}

		private void ReadFile(string filePath)
		{

			string line;
			// Read the file and display it line by line.
			System.IO.StreamReader file = new System.IO.StreamReader(filePath);
			while ((line = file.ReadLine()) != null)
			{
				if (IsMatch(line))
				{
					DataRow newRow = ReportsMatched.NewRow();
					newRow["nm_file"] = filePath;
					ReportsMatched.Rows.Add(newRow);
					matchCounts++;
					tsTotal.Text = $"Total de relatórios encontrados: {matchCounts} ";
					break;
				}
			}
			file.Close();
		}

		private bool IsMatch(string line) => line.Contains(txtMatch.Text);



		private void txtMatch_TextChanged(object sender, EventArgs e)
		{
			btnSearch_Click(null, null);
		}
	}
}
