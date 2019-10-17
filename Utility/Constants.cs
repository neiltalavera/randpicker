using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPicker.Utility
{
    static class Constants
    {
        //join message
        public const string JOIN = " has joined";

        //Base wage per round
        public const int BASE_WAGE = 3;

        //Up wage amount
        public const int UP_WAGE = 3;

        //Wage vote message
        public const string WAGE_VOTE = " has voted Wage increase";

        //Wage increase message
        public const string WAGE_INCREASE = "Wage has increased to ";

        //Help message
        public const string ADMIN_HELP = " don't do that here..";

        public const string NO_SESSION = "no active session";
    }

    static class FirebaseConstants
    {
        //Firebase database url
        public const string URL = "https://gas-randpick.firebaseio.com/";

        //Firebase secret key (pc-randpick)
        public const string SECRET = "sJ5qyjtrOK4VZazOzZTLMBt6HtzUNFfSL0Em2DRz";
    }
}
