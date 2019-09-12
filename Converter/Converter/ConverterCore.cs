using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter {

    public class ConverterCore {

        public double get_radians( double degrees ) {
            return ( degrees * Math.PI / 180 );
        }

        public double get_degrees( double radians ) {
            return ( radians * 180 / Math.PI );
        }

        public double get_miles( double kilometers ) {
            return ( kilometers / 1.609 );
        }

        public double get_kilometers( double miles ) {
            return ( miles * 1.609 );
        }
    }
}