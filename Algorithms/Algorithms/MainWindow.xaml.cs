﻿using System;
using System.Collections.Generic;
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

			BinarySearch<Int32> bs = new BinarySearch<Int32>();
			Int32[] v = { 1,2, 3, 4, 5, 6};
			Int32 result = bs.Search(v, 54);
			Console.WriteLine(result);
			
		}
	}
}
