using Microsoft.VisualStudio.TestTools.UnitTesting;
using Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Converter.Tests {

    [TestClass()]
    public class ConverterCoreTests {

        Converter.ConverterCore core = new ConverterCore();

        double dergrees = 130;
        double radians = 2.6;

        double kilometers = 117;
        double miles = 89;

        StringBuilder log = new StringBuilder();

        [TestMethod()]
        public void get_radiansTest() {

            double res = conv( "deg -> rad", dergrees );
            Assert.AreEqual<double>( res.CompareTo( 2.269 ), -1 );
        }

        [TestMethod()]
        public void get_degreesTest() {

            double res = conv( "rad -> deg", radians );
            Assert.AreEqual<double>( res.CompareTo( 148.969 ), -1 );
        }

        [TestMethod()]
        public void get_milesTest() {

            double res = conv( "km -> ml" , kilometers );
            Assert.AreEqual<double>( res.CompareTo( 72.7004 ), -1 );
        }

        [TestMethod()]
        public void get_kilometersTest() {

            double res = conv( "ml -> km", miles );
            Assert.AreEqual<double>( res.CompareTo( 143.201 ), -1 );
        }

        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public double conv( string way, double val ) {

            double res = 0.0;

            if( way == "deg -> rad" ) {

                double rad = core.get_radians( val );

                if( rad != 2.269 )
                    log.Append( $"\n[1] -- Ошибка при выполнении теста конвертации градусов в радианы.\nПришло: { val }\nОжидаемый результат: 2,269\nПолучено: { rad }" );
            }
            else if( way == "rad -> deg" ) {

                double deg = core.get_degrees( val );

                if( deg != 148.969  )
                    log.Append( $"[2] -- Ошибка при выполнении теста конвертации радиан в градусы.\nПришло: { val }\nОжидаемый результат: 148,969\nПолучено: { deg }" );
            }
            else if( way == "km -> ml" ) {

                double ml = core.get_miles( val );

                if ( ml != 72.7004 )
                    log.Append($"[3] -- Ошибка при выполнении теста конвертации километров в мили.\nПришло: { val }\nОжидаемый результат: 72,7004\nПолучено: { ml }");
            }

            else if( way == "ml -> km" ) {

                double km = core.get_kilometers( val );

                if ( km != 143.201 )
                    log.Append($"[4] -- Ошибка при выполнении теста конвертации миль в километры.\nПришло: { val }\nОжидаемый результат: 143,201\nПолучено: { km }");

                write_log();
            }

            return res;
        }

        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public void write_log() {

            if ( log.ToString() == "" ) log.Append( $"[{ DateTime.Now.ToString( "dd.MM.yyyy" )} { DateTime.Now.ToString( "hh:mm:ss" ) }] -- Все тесты выполнены успешно!" );

            StreamWriter stream = new StreamWriter( "auto_test_log.txt", true );
            stream.Write( this.log.ToString() );
            stream.Close();
        }

        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    }
}