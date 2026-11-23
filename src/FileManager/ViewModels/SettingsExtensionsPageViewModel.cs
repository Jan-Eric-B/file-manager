using CommunityToolkit.Mvvm.ComponentModel;
using FileManager.Models;
using FileManager.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Composition.Scenes;
using System.Threading.Tasks;
using Wpf.Ui;
using Wpf.Ui.Abstractions.Controls;

namespace FileManager.ViewModels
{
    public class SettingsExtensionsPageViewModel : ObservableObject, INavigationAware
    {
      

        private readonly ISnackbarService _snackbarService;

        #region Main

        private bool _dataInitialized;

        public ContainerViewModel Container { get; set; }

        #endregion

        //____________________________________________________________

        #region Main

        public SettingsExtensionsPageViewModel(ContainerViewModel container, ISnackbarService snackbarService)
        {
            Container = container;
            _snackbarService = snackbarService;
        }

        public Task OnNavigatedFromAsync()
        {
            return Task.CompletedTask;
        }

        public Task OnNavigatedToAsync()
        {
            if (!_dataInitialized)
            {
                InitializeData();
            }

            return Task.CompletedTask;
        }

        private void InitializeData()
        {
            _dataInitialized = true;
        }

        #endregion




    }
}