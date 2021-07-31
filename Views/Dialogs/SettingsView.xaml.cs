using System.Windows;
using System.Diagnostics;

namespace YTExplorer.Views.Dialogs
{
    public partial class SettingsView
    {
        public SettingsView()
        {
            InitializeComponent();
        }

        public void DownFFMPEG()
        {
            //TODO
        }

        private void DarkModeToggleButton_Checked(object sender, RoutedEventArgs args) =>
            App.SetDarkTheme();

        private void DarkModeToggleButton_Unchecked(object sender, RoutedEventArgs args) =>
            App.SetLightTheme();
    }
}