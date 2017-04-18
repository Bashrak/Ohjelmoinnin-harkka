using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Classit.Models.BL_ViewModels;

namespace Classit {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow()
		{
			InitializeComponent();
			try {
				WorkDayControls test = new WorkDayControls();
				test.LoadFromMysql();
				test.InsertToMysql();
				dgWorkDayItems.DataContext = test.WorkDayItems;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
				throw;
			}
		}
	}
}
