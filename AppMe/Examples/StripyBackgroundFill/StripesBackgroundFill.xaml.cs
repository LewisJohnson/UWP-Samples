using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using System.Threading.Tasks;
using System;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AppMe.Examples
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StripesBackgroundFill : Page
    {
        public StripesBackgroundFill()
        {
            this.InitializeComponent();
        }

        private void FrameworkElement_OnLoaded(object sender, RoutedEventArgs e)
        {
            BackgroundAnimation.RepeatBehavior = RepeatBehavior.Forever;
            BackgroundAnimation2.RepeatBehavior = RepeatBehavior.Forever;
            BackgroundAnimation.Begin();
            BackgroundAnimation2.Begin();
        }
    }
}
