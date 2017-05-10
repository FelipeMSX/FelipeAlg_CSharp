using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
			ReportsMatched.Columns.Add("nu_threadID", typeof(string));
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

		List<String> buffer = new List<string>();

		private void PrintDataView(bool force)
		{
			lock (buffer)
			{
				if (buffer.Count >= 25 || force)
				{

					dataGridViewResult.Invoke((Action)(() =>
					{
						ShowResult(buffer, Process.GetCurrentProcess().Threads.Count);
					}));



					tsTotal.Text = $"Total de relatórios encontrados: {matchCounts} ";


					buffer.Clear();
				}

			}
		}

		private void putBuffer(String item)
		{
			lock (buffer)
			{
				buffer.Add(item);
				matchCounts++;
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();

			Reset();
			string directoryPath = txtDirectory.Text;
			String[] files = Directory.GetFiles(directoryPath);
			List<String> listFiles = files.ToList();
			//files.AsParallel().Where((x) => isMatchFile(x)).ForAll((x) => matchCounts++);

			//	resultFiles.ToString();
			//	ShowResult(resultFiles);

			Task<List<String>> taskSearch = new Task<List<String>>(() =>
			{
				List<String> resultFiles = new List<string>();
				Parallel.ForEach<String>(files, (filePath) =>
				{
					StreamReader file = null; ;
					try
					{
						string line;
						// Read the file and display it line by line.

						file = new System.IO.StreamReader(filePath);

						while ((line = file.ReadLine()) != null)
						{
							if (IsMatch(line))
							{
								putBuffer(filePath);
								PrintDataView(false);
								break;
							}
						}
					}
					catch (AggregateException ex)
					{
						MessageBox.Show(ex.InnerException.InnerException.Message.ToString());

					}
					finally
					{
						file.Close();
						file.Dispose();
					}
				});
				return resultFiles;
			});

			taskSearch.ContinueWith((xx) =>
			{
				PrintDataView(true);
				object xxx = xx.Result;
				tsTotal.Text = $"Total de relatórios encontrados: {matchCounts} ";
			});

			taskSearch.Start();
		}



		private void ShowResult(List<String> resultFiles, int threadID)
		{
			resultFiles.ForEach(file =>
			{
				DataRow newRow = ReportsMatched.NewRow();
				newRow["nm_file"] = file;
				ReportsMatched.Rows.Add(newRow);

			});
		}

		private void ShowResult(String file, int threadID)
		{
			DataRow newRow = ReportsMatched.NewRow();
			newRow["nm_file"] = file;
			newRow["nu_threadID"] = threadID;
			ReportsMatched.Rows.Add(newRow);
		}

		private bool isMatchFile(string filepath) => ReadFile(filepath).Result;
		private async Task<bool> ReadFile(string filePath)
		{

			string line;
			// Read the file and display it line by line.

			System.IO.StreamReader file = new System.IO.StreamReader(filePath);
			string fileDate = await file.ReadToEndAsync();

			//while ((line = file.ReadLineAsync()) != null)
			//{
			//	if (IsMatch(line))
			//	{
			//		return true;
			//	}
			//}
			file.Close();
			file.Dispose();
			return false;
		}

		private bool IsMatch(string line) => line.Contains(txtMatch.Text);



		private void txtMatch_TextChanged(object sender, EventArgs e)
		{
			btnSearch_Click(null, null);
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			Reset();
		}
	}
}
