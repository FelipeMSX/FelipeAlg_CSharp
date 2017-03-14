using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reactive.Linq;

namespace ReactiveProgramming
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			List<String> strings = new List<string>();
			strings.Add("Felipe");
			strings.Add("ABC");
			strings.Add("Moises");
			strings.Add("Fábio");
			strings.Add("123");

			object xd = strings.ToObservable().Do((x) => x.ToString());
		}
	}
}
