using InterfaceFB.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InterfaceFB.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : Shell
    {
        public Menu()
        {
            InitializeComponent();

            var statusbar = DependencyService.Get<IStatusBarPlatformSpecific>();
            statusbar.SetStatusBarColor(Color.White);

        }
    }
}