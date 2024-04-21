using Avalonia.Controls.ApplicationLifetimes;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RaspyberryPiGui.Views;
using System;

namespace RaspyberryPiGui.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";
    private bool _isGreeting = true;

    [RelayCommand]
    public void Shutdown()
    {
        if (App.Current!.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.Shutdown();
        }
    }

    [RelayCommand]
    public void ChangeText()
    {
        Greeting = _isGreeting ? " !(^_^)!" : "Welcome to Avalonia!";
        _isGreeting = !_isGreeting;
    }
}
