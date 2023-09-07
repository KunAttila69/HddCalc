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

namespace HddCalc
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double capUnit, speedUnit;
            double cap = (int)tb.Text

            switch (cbx_1.SelectedItem)
            {
                case "MegaByte":
                    capUnit = 1;
                    break;
                case "GigaByte":
                    capUnit = 1000;
                    break;
                case "TeraByte":
                    capUnit = 1000000;
                    break;
                default:
                    break;
            }

            switch (cbx_2.SelectedItem)
            {
                case "mb/s":
                    speedUnit = 0.125;
                    break;
                case "KB/s":
                    speedUnit = 0.001;
                    break;
                case "MB/s":
                    speedUnit = 1;
                    break;
                case "GB/s":
                    speedUnit = 100;
                    break;
                default:
                    break;
            }

            lbl_2.Content = Convert.ToString((cap*capUnit)/(speed*speedUnit));
        }

        
    }
}
