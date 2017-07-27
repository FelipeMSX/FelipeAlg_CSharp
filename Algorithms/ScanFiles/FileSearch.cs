using ScanFiles.Model;
using ScanFiles.Resources;
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
	public partial class FileSearch : DevComponents.DotNetBar.Office2007Form
    {
        private List<String> FileNameException = new List<string> { "DESIGNER", "RESX", "CONTABILIS.CSPROJ" };
        private List<String> DirectoryException = new List<string> { "BIN", "REPORTS", "CHARTS", "SOUNDS", "PROPERTIES", "IMAGES" };


        private void Initialize()
		{
            DataSetMain d = new DataSetMain();

         
		}
		public FileSearch()
		{
			InitializeComponent();
			Initialize();
		}

		private void btnDirectory_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				txtDirectory.Text = folderBrowserDialog.SelectedPath;
			}
		}

		private void Reset()
		{
			tsTotal.Text = String.Empty;
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

			//taskSearch.ContinueWith((xx) =>
			//{
			//	PrintDataView(true);
			//	object xxx = xx.Result;
			//	tsTotal.Text = $"Total de relatórios encontrados: {matchCounts} ";
			//});

			//taskSearch.Start();
		}

        private List<String> GetAllFiles(string path, List<String> files = null)
        {
            if(files == null)
            {
                files = new List<string>();
            }

            foreach(String file in Directory.GetFiles(path))
            {
                if (IsValidFile(file))
                    files.Add(file);
            }
            foreach (String directory in Directory.GetDirectories(path))
            {
                if (IsValidDirectory(directory))
                    GetAllFiles(directory, files);
            }
                return files;
            
        }
        //FileType fileType = (FileType)bindingSource.AddNew();

        private bool IsValidFile(string fileName) => !FileNameException.AsEnumerable().Any(x => fileName.ToUpper().Contains(x));

        private bool IsValidDirectory(string directoryName) => !DirectoryException.AsEnumerable().Any(x => directoryName.ToUpper().Contains(x));



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
		private void buttonClear_Click(object sender, EventArgs e)
		{
			Reset();
		}

        private void buttonSearch_Click(object sender, EventArgs e)
        {
          GetAllFiles(txtDirectory.Text);
        }
    }
}
