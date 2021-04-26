using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE_06___OOP_STATIC{
    //----------------------START | OBJ CONVERTER------------------------//
    class Converter{
        public static double Iof = 6;
        public static double DolarToReal(double amount, double price) {
            double total = amount * price;
            return total + (total * Iof / 100);
        }
    }
    //---------------------------- END ---------------------------------//
}
