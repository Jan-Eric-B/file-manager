// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using Wpf.Ui.Abstractions.Controls;
using FileManager.ViewModels;

namespace FileManager.Views.Pages;

/// <summary>
/// Interaction logic for Page2.xaml
/// </summary>
public partial class Page2 : INavigableView<Page2ViewModel>
{
    public Page2(Page2ViewModel viewModel)
    {
        ViewModel = viewModel;
        DataContext = this;

        InitializeComponent();
    }

    public Page2ViewModel ViewModel
    {
        get;
    }
}