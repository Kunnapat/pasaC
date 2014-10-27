
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace _2190152_lab08_inClass_5631216321
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var i1 = (info)e.Parameter;
            nameTB.Text = i1.name;
            heightTB.Text = i1.height;
            genderTB.Text = i1.gender;

            String temp = "";
            if (i1.tennis)
            {
                temp = temp + "\nTennis";
            }
            if (i1.football)
            {
                temp = temp + "\nFootball";
            }
            if (i1.basketball)
            {
                temp = temp + "\nBasketball";
            }
            if(i1.dancing){
                temp = temp + "\nDancing";
            }

            hb.Text = temp;
        }

        private void onClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
 




        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>

    }
}
