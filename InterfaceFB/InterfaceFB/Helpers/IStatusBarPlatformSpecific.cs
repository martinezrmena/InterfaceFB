using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace InterfaceFB.Helpers
{
    public interface IStatusBarPlatformSpecific
    {
        void SetStatusBarColor(Color color);
    }
}
