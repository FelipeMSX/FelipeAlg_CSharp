using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AspectProgramming.Objects;

namespace AspectProgramming
{
	public partial class Principal : Form
	{
		public Principal()
		{
			InitializeComponent();
		}

		private void btOK_Click(object sender, EventArgs e)
		{
			Abastecimento abastecimento = new Abastecimento();
			//abastecimento.Teste(); 
			abastecimento.Excluir(new List<Abastecimento> { new Abastecimento() });
		}
	}
}
