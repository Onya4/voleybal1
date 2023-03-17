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
    
    public partial class VolumPage : Page
    {
        groopTableAdapter groop = new groopTableAdapter();
        public VolumPage()
        {
            InitializeComponent();
            VolGrid.ItemsSource = groop.GetData();
        }
        private void VoleybalGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
