#nullable enable

using System;
using System.Windows;
using Wpf.Ui.Abstractions;

namespace FileManager.Services;

/// <summary>
/// Resolves navigation pages from the DI container.
/// </summary>
public class PageService : INavigationViewPageProvider
{
    private readonly IServiceProvider _serviceProvider;

    public PageService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    /// <inheritdoc />
    public object? GetPage(Type pageType)
    {
        if (!typeof(FrameworkElement).IsAssignableFrom(pageType))
            throw new InvalidOperationException("The page should be a WPF control.");

        return _serviceProvider.GetService(pageType);
    }
}
