using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    public static class Utilities
    {
        //static classes are Not instantiated by the outsider user (developer)
        //static class items are referred using the classname.xxxx
        //method within this class have the keyword static in their signature
        //static classes are shared between all outside user at the SAME time
        //DO not consider saving data within a static class because you cannot be
        //  certain it will be there went you use the class again
        //consider placing GENERIC re-usable methods within a static class

        //sample of overloaded methods
        //the method signatures are different
        public static bool IsZeroPositive(int value)
        {
            bool valid = true;
            if (value < 0)
            {
                valid = false;
            }
            return valid;
        }
        public static bool IsZeroPositive(double value)
        {
            bool valid = true;
            if (value < 0)
            {
                valid = false;
            }
            return valid;
        }
        public static bool IsZeroPositive(decimal value)
        {
            bool valid = true;
            if (value < 0)
            {
                valid = false;
            }
            return valid;
        }
    }
}

