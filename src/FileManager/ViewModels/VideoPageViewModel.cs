using CommunityToolkit.Mvvm.ComponentModel;
using System.Threading.Tasks;
using Wpf.Ui.Abstractions.Controls;

namespace FileManager.ViewModels
{
    public class VideoPageViewModel : ObservableObject, INavigationAware
    {
        #region Main

        private bool _dataInitialized;

        public ContainerViewModel Container { get; set; }

        #endregion

        //____________________________________________________________

        #region Main

        public VideoPageViewModel(ContainerViewModel container)
        {
            Container = container;
        }

        public Task OnNavigatedFromAsync()
        {
            return Task.CompletedTask;
        }

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

        #endregion

    }
}