using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using InterfaceFB.Droid.Helpers;
using InterfaceFB.Helpers;
using Plugin.CurrentActivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Dependency(typeof(Statusbar))]
namespace InterfaceFB.Droid.Helpers
{
    public class Statusbar : IStatusBarPlatformSpecific
    {
        public Statusbar()
        {
        }

        public void SetStatusBarColor(Color color)
        {
            try
            {
                // The SetStatusBarcolor is new since API 21
                if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                {
                    var androidColor = color.AddLuminosity(-0.1).ToAndroid();
                    //Just use the plugin
                    CrossCurrentActivity.Current.Activity.Window.SetStatusBarColor(androidColor);
                }
                else
                {
                    // Here you will just have to set your 
                    // color in styles.xml file as shown below.
                }
            }
            catch (Exception)
            {
            }
        }
    }
}