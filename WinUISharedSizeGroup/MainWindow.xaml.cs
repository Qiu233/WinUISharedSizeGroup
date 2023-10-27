using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WinUISharedSizeGroup.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUISharedSizeGroup
{
	/// <summary>
	/// An empty window that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainWindow : Window
	{
		private ObservableCollection<Data> DataCollection = new ObservableCollection<Data>();
		public MainWindow()
		{
			this.InitializeComponent();
			DataCollection.Add(new Data("A", 100));
			DataCollection.Add(new Data("BB", 200));
			DataCollection.Add(new Data("CCC", 300));
			DataCollection.Add(new Data("DDDD", 400));
			DataCollection.Add(new Data("EEE", 500));
			DataCollection.Add(new Data("FF", 600));
			DataCollection.Add(new Data("G", 700));
		}
	}
}
