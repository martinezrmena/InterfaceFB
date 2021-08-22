using Foundation;
using InterfaceFB.Helpers;
using InterfaceFB.iOS.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: Dependency(typeof(Statusbar))]
namespace InterfaceFB.iOS.Helpers
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
                UIView statusBar = UIApplication.SharedApplication.ValueForKey(
                                new NSString("statusBar")) as UIView;

                if (statusBar != null && statusBar.RespondsToSelector(
                new ObjCRuntime.Selector("setBackgroundColor:")))
                {
                    // change to your desired color 
                    statusBar.BackgroundColor = color.ToUIColor();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}