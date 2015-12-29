
using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Algorithms.collection;
using Algorithms.exception;
using Algorithms.search;

namespace Algorithms
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			
		}

		private void button_Click(object sender, RoutedEventArgs e)
		{
			Stack<string> q = new Stack<string>();

			q.Push("Felipe");
			q.Push("Albert");
			q.Push("Diego Costa");
			q.Push("Zé Todinho");
		
			
			//	Int32[] v = { 1,2, 3, 4, 5, 6};

			Console.WriteLine(q.Pop());
			Console.WriteLine(q.Pop());
			Console.WriteLine(q.Pop());
			Console.WriteLine(q.Pop());
			Console.WriteLine(q.Pop());
		}
	}
}
