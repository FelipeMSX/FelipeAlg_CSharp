
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
using Algorithms.sort;

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

				Int32[] v = { 10,-2, 337, 4,4, 50, 61};
			Int32[] result = Sort< Int32>.MergeSort(v);


		}

		
	}

	public class ObjectTeste : IComparable<ObjectTeste>
	{
		string Name;
		int age;
		public int CompareTo(ObjectTeste obj)
		{
			return Name.CompareTo(obj.Name);
		}
	}
}
