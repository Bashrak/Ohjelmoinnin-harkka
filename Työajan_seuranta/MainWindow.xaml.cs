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

namespace Työajan_seuranta
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void EditEmployee_Click(object sender, RoutedEventArgs e)
        {
            EditEmployeeWindow editwindow = new EditEmployeeWindow();
            editwindow.Show();
        }

        private void EditWorkHours_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SignToWork_Click(object sender, RoutedEventArgs e)
        {
            SignToWork signtowork = new SignToWork();
            signtowork.Show();
        }
    }
}
