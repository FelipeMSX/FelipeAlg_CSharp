
using Project_Report.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Report
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			ModelContainer model = new ModelContainer();
			Relatorio relatorio = new Relatorio();
			relatorio.sq_relatorio = 1;
			relatorio.sq_modulo = 1;
			relatorio.nm_arquivo = "Teste";
			relatorio.nmConteudo = new byte[4];
			object x = model.Database.Connection;
			model.RelatorioSet.Add(relatorio);
			model.SaveChanges();
		}
	}
}
