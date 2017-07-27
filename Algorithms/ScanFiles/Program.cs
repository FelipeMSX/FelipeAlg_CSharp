using ScanFiles.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanFiles
{
	static class Program
	{
       public static  ModelEntityContainer  modelContainer = new ModelEntityContainer();
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FileSearch());
		}
	}
}
