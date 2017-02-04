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

namespace LicenseData
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

        private void Data_Loaded(object sender, RoutedEventArgs e)
        {
            var software = new List<LicenseInfo>();
            software.Add(new LicenseInfo("Microsoft Office", 20, 10));
            software.Add(new LicenseInfo("Professional Adobe", 10, 2));
            software.Add(new LicenseInfo("Lightroom", 9, 4));
            software.Add(new LicenseInfo("AutoCad", 5, 5));
            software.Add(new LicenseInfo("Matlab", 9, 4));
            software.Add(new LicenseInfo("Warcraft", 10, 7));

            var grid = sender as DataGrid;
            grid.ItemsSource = software;
        }

        private void Data_SelectedChanged(object sender, SelectionChangedEventArgs e)
        {
            var grid = sender as DataGrid;
            var selected = grid.SelectedItems;

            List<string> softwares = new List<string>();
            foreach (var item in selected)
            {
                var licenseinfo = item as LicenseInfo;
                softwares.Add(licenseinfo.Software);

            }

            this.Title = string.Join(", ", softwares);
        }

        private void DataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            var element = e.EditingElement as TextBox;
            var text = element.Text;

            if (text == "!")
            {
                this.Title = "Invalid";
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show("You wrote " + text);
            }
        }
    }
}
