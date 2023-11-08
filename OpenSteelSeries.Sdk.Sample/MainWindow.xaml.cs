using OpenSteelSeries.Sonar.Sdk.Interfaces;
using System.Windows;

namespace OpenSteelSeries.Sdk.Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ISonarClassicVolumeSettingsService _sonarClassicVolumeSettings;
        public MainWindow(ISonarClassicVolumeSettingsService sonarClassicVolumeSettingsService)
        {
            InitializeComponent();
            _sonarClassicVolumeSettings = sonarClassicVolumeSettingsService;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as System.Windows.Controls.Button;
            var mute = btn.Content.Equals("mute");
            await _sonarClassicVolumeSettings.SetMasterMuteAsync(mute);
        }
    }
}
