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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace _2190152_lab08_inClass_5631216321
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int height = 150;
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void onClick(object sender, RoutedEventArgs e)
        {
            info i1 = new info(nameTextBox.Text,  heightTextBox.Text, genderComboBox.SelectionBoxItem.ToString() , tennisCheckBox.IsChecked == true , footballCheckBox.IsChecked == true , basketballCheckBox.IsChecked == true , dancingCheckBox.IsChecked == true);
            Frame.Navigate(typeof(BlankPage1), i1);

            
        }

        private void inClick(object sender, RoutedEventArgs e)
        {
            height = height + 1;
            String temp = height.ToString();
            heightTextBox.Text = temp;
        }

        private void deClick(object sender, RoutedEventArgs e)
        {
            height = height - 1;
            String temp = height.ToString();
            heightTextBox.Text = temp;
        }

        private void heightChanged(object sender, TextChangedEventArgs e)
        {
            int.TryParse(heightTextBox.Text, out height);
            heightTextBox.Text = height.ToString();
        }





 


    }
}
