using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using AppMe.Examples;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AppMe
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ExamplesListView.ItemsSource = Scenarios;
        }



        private void ExamplesListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var scenarioListBox = sender as ListBox;
            var s = scenarioListBox?.SelectedItem as Scenario;
            HostFrame.Navigate(s.ClassType);
        }

        public List<Scenario> Scenarios { get; } = new List<Scenario>
        {
            new Scenario() { Title = "Circle background",   ClassType = typeof(CircleBackgroundFill) },
            new Scenario() { Title = "Stripy background",   ClassType = typeof(StripesBackgroundFill) },
             new Scenario() { Title = "Shimmer",   ClassType = typeof(Shimmer) },
        };
    }

    public class Scenario
    {
        public string Title { get; set; }
        public Type ClassType { get; set; }
    }

    public class ScenarioBindingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            Scenario s = value as Scenario;
            return s.Title;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return true;
        }
    }
}
