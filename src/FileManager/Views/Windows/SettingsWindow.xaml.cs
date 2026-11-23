namespace FileManager.Views.Windows
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow
    {
        public SettingsWindow()
        {
            InitializeComponent();

            // The settings pages have parameterless constructors, so the NavigationView creates them itself.
            Loaded += (_, _) => RootNavigation.Navigate(typeof(Pages.SettingsGeneralPage));
        }
    }
}
