using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Xamarin.Forms;

namespace StudioB.Models
{
    public class Constants
    {
        public static bool IsDev = true;

        public static Color BackgroundColor = Color.FromRgb(58, 154, 215);
        public static Color MainTextColor = Color.White;

        public static int LoginIconHeight = 280;

        //--------Login---------------
        public static string LoginUrl = "https://test.com//api/Auth/Login";

        public static string NoInternetText = "No Internet, please reconnect";
    }
}
