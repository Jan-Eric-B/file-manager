# FileManager

![Screenshot](FileManagerScreenshot.png "Screenshot")

This is an application for editing files and directories. 
It is a tool that I have developed for my private handling of files and is mainly used to practice the development of an application.
Therefore I take no responsibility for lost files or other problems.
**Use the application at your own risk.**

## Development

This application is built with WPF on .NET 11.
The fancy UI is built using [WPF UI](https://github.com/lepoco/wpfui) 4.3.

* [.NET 11](https://dotnet.microsoft.com/) (`net11.0-windows`) with WPF
* [WPF UI](https://github.com/lepoco/wpfui) 4.3: Fluent window with Mica backdrop, `NavigationView`, light and dark themes
* [Microsoft.Extensions.Hosting](https://www.nuget.org/packages/Microsoft.Extensions.Hosting) 11: dependency injection and app lifetime
* [CommunityToolkit.Mvvm](https://www.nuget.org/packages/CommunityToolkit.Mvvm) 8.4: MVVM base classes
* [ExiftoolWrapper](https://www.nuget.org/packages/ExiftoolWrapper) 5.2: metadata removal through [ExifTool](https://exiftool.org/)
* [ImageComparison](https://www.nuget.org/packages/ImageComparison) 2.0: grouping similar images
* [Ookii.Dialogs.Wpf](https://www.nuget.org/packages/Ookii.Dialogs.Wpf) 5.0: folder picker

### Building from source

Requirements: Windows 10 version 1809 or later and the [.NET 11 SDK](https://dotnet.microsoft.com/download).

```shell
dotnet build src/FileManager/FileManager.csproj
dotnet run --project src/FileManager
```

## Installation

[WIP]

## Functions

* List files in directories and subdirectories + filtering them by search or extension
* Moving/grouping files
* Delete files, metadata or empty folders
* Renaming files by replacing, swapping, adding or capitalizing
* Fixing Extensions (replace with lowercase or standardize the extensions (.jpeg & .jpe to .jpg)

[WIP]
* Copying of names or paths of files
* Converting images or videos
* Showing metadata
* Flipping, rotating or grayscaling images or videos
* Extracting specific from a video
* Cutting and merging of videos
* Editing Folders

## Features

* Switching to dark and white theme
* saving of selected settings
* Moving Files onto application executable or in the path display
* Selecting all files, every second or by hovering over the checkboxes
* Highlighting the part to be replaced during renaming

[WIP]
* Setup file for installing
* automatic installing latest FFmpeg and ExifTool
* Settings window + more custom configurations

