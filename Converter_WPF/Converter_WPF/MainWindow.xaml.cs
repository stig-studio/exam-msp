using System;
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

namespace Converter_WPF {

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window {

        Converter.ConverterCore conv = new Converter.ConverterCore();

        public MainWindow() {
            InitializeComponent();
        }

        private void btn_deg_to_rad_Click( object sender, RoutedEventArgs e ) {
            txtb_rad_res.Text = conv.get_radians( Convert.ToDouble( this.txtb_deg.Text.Replace( '.', ',' ) ) ).ToString();
        }

        private void btn_rad_to_deg_Click( object sender, RoutedEventArgs e ) {
            txtb_deg_res.Text = conv.get_degrees( Convert.ToDouble( txtb_rad.Text.Replace( '.', ',' ) ) ).ToString();
        }

        private void btn_km_to_ml_Click( object sender, RoutedEventArgs e ) {
            txtb_ml_res.Text = conv.get_miles( Convert.ToDouble( txtb_km.Text.Replace( '.', ',' ) ) ).ToString();
        }

        private void btn_ml_to_km_Click( object sender, RoutedEventArgs e ) {
            txtb_km_res.Text = conv.get_kilometers( Convert.ToDouble( txtb_ml.Text.Replace( '.', ',' ) ) ).ToString();
        }

        private void txtb_deg_TextChanged( object sender, TextChangedEventArgs e ) {

            TextBox txtb = sender as TextBox;

            if ( txtb.Name == "txtb_deg" ) btn_deg_to_rad.IsEnabled = ( txtb.Text == "" ) ? false : true ;
            if ( txtb.Name == "txtb_rad" ) btn_rad_to_deg.IsEnabled = ( txtb.Text == "" ) ? false : true ;
            if ( txtb.Name == "txtb_km" ) btn_km_to_ml.IsEnabled = ( txtb.Text == "" ) ? false : true ;
            if ( txtb.Name == "txtb_ml" ) btn_ml_to_km.IsEnabled = ( txtb.Text == "" ) ? false : true ;
        }
    }
}