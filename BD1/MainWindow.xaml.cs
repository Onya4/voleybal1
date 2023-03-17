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
using BD1.DataSet1TableAdapters;

namespace BD1
{
    public partial class MainWindow : Window
    {
        playersTableAdapter players = new playersTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            VoleybalGrid.ItemsSource = players.GetData();

        }
        private void Players_Click(object sender, RoutedEventArgs e)
        {

        }
        private void two_Navigated(object sender, NavigationEventArgs e)
        {

        }
        private void groopV_Click(object sender, RoutedEventArgs e)
        {
            two.Content = new VolumPage();
        }
    }
}
