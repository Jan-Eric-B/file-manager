using System;
using System.Windows;
using Wpf.Ui;
using Wpf.Ui.Abstractions;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;
using Wpf.Ui.TaskBar;
using FileManager.Services;
using FileManager.ViewModels;

namespace FileManager.Views;

/// <summary>
/// Interaction logic for Container.xaml
/// </summary>
public partial class Container : INavigationWindow
{
    private readonly ITaskBarService _taskBarService;
    private readonly IWindowService _windowService;
    private readonly IThemeService _themeService;
    private bool _initialized = false;

    public Container(
        ContainerViewModel viewModel,
        INavigationService navigationService,
        INavigationViewPageProvider pageProvider,
        IThemeService themeService,
        ITaskBarService taskBarService,
        ISnackbarService snackbarService,
        IContentDialogService contentDialogService,
        IWindowService windowService)
    {
        ViewModel = viewModel;
        DataContext = this;

        _themeService = themeService;
        _taskBarService = taskBarService;
        _windowService = windowService;

        InitializeComponent();

        // Pages are resolved from the DI container.
        SetPageService(pageProvider);

        // Lets INavigationService navigate this window's NavigationView from anywhere.
        navigationService.SetNavigationControl(RootNavigation);

        // Lets ISnackbarService and IContentDialogService show snackbars and dialogs in this window.
        snackbarService.SetSnackbarPresenter(RootSnackbar);
        contentDialogService.SetDialogHost(RootContentDialog);

        Loaded += (_, _) => InitializeUi();
    }

    public ContainerViewModel ViewModel { get; }

    /// <summary>
    /// Closing the main window shuts down the application.
    /// </summary>
    protected override void OnClosed(EventArgs e)
    {
        base.OnClosed(e);

        Application.Current.Shutdown();
    }

    #region INavigationWindow methods

    public void CloseWindow()
        => Close();

    public INavigationView GetNavigation()
        => RootNavigation;

    public bool Navigate(Type pageType)
        => RootNavigation.Navigate(pageType);

    public void SetPageService(INavigationViewPageProvider navigationViewPageProvider)
        => RootNavigation.SetPageProviderService(navigationViewPageProvider);

    public void SetServiceProvider(IServiceProvider serviceProvider)
        => RootNavigation.SetServiceProvider(serviceProvider);

    public void ShowWindow()
        => Show();

    #endregion INavigationWindow methods

    private void InitializeUi()
    {
        if (_initialized)
            return;

        _initialized = true;

        _taskBarService.SetState(this, TaskBarProgressState.Indeterminate);

        Navigate(typeof(Pages.Page1));

        _taskBarService.SetState(this, TaskBarProgressState.None);
    }

    private void NavigationButtonTheme_OnClick(object sender, RoutedEventArgs e)
    {
        _themeService.SetTheme(_themeService.GetTheme() == ApplicationTheme.Dark
            ? ApplicationTheme.Light
            : ApplicationTheme.Dark);
    }

    private void OpenSettings_OnClick(object sender, RoutedEventArgs e)
    {
        _windowService.Show<Windows.SettingsWindow>();
    }
}
