using Android.App;
using Android.Content;
using Android.Net;
using StudioB.Data;
using StudioB.Droid.Data;

[assembly: Xamarin.Forms.Dependency(typeof(NetworkConnection))]
namespace StudioB.Droid.Data
{
    public class NetworkConnection : INetworkConnection
    {
        public bool IsConnected { get; set; }

        public void CheckNetworkConnection()
        {
            ConnectivityManager connectivityManager = (ConnectivityManager)Application.Context.GetSystemService(Context.ConnectivityService);

            NetworkInfo networkInfo = connectivityManager.ActiveNetworkInfo;

            if (networkInfo != null && networkInfo.IsConnectedOrConnecting)
            {
                IsConnected = true;
            }
            else
            {
                IsConnected = false;
            }
        }
    }
}