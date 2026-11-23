using CommunityToolkit.Mvvm.ComponentModel;
using System.Threading.Tasks;
using Wpf.Ui.Abstractions.Controls;

namespace FileManager.ViewModels;

public class Page2ViewModel : ObservableObject, INavigationAware
{
    private bool _dataInitialized = false;

    public Task OnNavigatedFromAsync()
        => Task.CompletedTask;

    public Task OnNavigatedToAsync()
    {
        if (!_dataInitialized)
            InitializeData();

        return Task.CompletedTask;
    }

    private void InitializeData()
    {
        _dataInitialized = true;
    }
}
