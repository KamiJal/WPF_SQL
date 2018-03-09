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
using ADONET;

namespace WPF_ADONET
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SQLDB sqldb = new SQLDB();
            ManufacturerList.ItemsSource = sqldb.Manufacturer.ToList();
            CBArea.ItemsSource = sqldb.Area.Select(area => area.Name).ToList();

        }

        private void ManufacturerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Manufacturer click = ((ListView)sender).SelectedItem as Manufacturer;
            ManufInfo.DataContext = click;
        }
    }
}
