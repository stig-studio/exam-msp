using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter_WF {

    public partial class main_form : Form {

        Converter.ConverterCore conv = new Converter.ConverterCore();

        public main_form() {
            InitializeComponent();
        }

        private void main_form_Load(object sender, EventArgs e ) {

        }
        
        private void txtb_TextChanged( object sender, EventArgs e ) {

            TextBox txtb = sender as TextBox;

            if ( txtb.Name == "txtb_deg" ) btn_deg_to_rad.Enabled = ( txtb.Text == "" ) ? false : true ;
            if ( txtb.Name == "txtb_rad" ) btn_rad_to_deg.Enabled = ( txtb.Text == "" ) ? false : true ;
            if ( txtb.Name == "txtb_km" ) btn_km_to_ml.Enabled = ( txtb.Text == "" ) ? false : true ;
            if ( txtb.Name == "txtb_ml" ) btn_ml_to_km.Enabled = ( txtb.Text == "" ) ? false : true ;

        }

        private void btn_deg_to_rad_Click( object sender, EventArgs e ) {
            
            txtb_rad_res.Text = conv.get_radians( Convert.ToDouble( this.txtb_deg.Text.Replace( '.', ',' ) ) ).ToString();
        }

        private void btn_rad_to_deg_Click( object sender, EventArgs e ) {
            txtb_deg_res.Text = conv.get_degrees( Convert.ToDouble( txtb_rad.Text.Replace( '.', ',' ) ) ).ToString();
        }

        private void btn_km_to_ml_Click( object sender, EventArgs e ) {
            txtb_ml_res.Text = conv.get_miles( Convert.ToDouble( txtb_km.Text.Replace( '.', ',' ) ) ).ToString();
        }

        private void btn_ml_to_km_Click( object sender, EventArgs e ) {
            txtb_km_res.Text = conv.get_kilometers( Convert.ToDouble( txtb_ml.Text.Replace( '.', ',' ) ) ).ToString();
        }
    }
}