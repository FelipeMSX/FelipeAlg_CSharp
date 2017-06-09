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
	public partial class ReportSafe : Form
	{
		private int matchCounts;

		private void Initialize()
		{
		}
		public ReportSafe()
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


		
	}
}
