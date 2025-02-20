using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace ProfProject;

public partial class Menu : Window
{
    public Menu()
    {
        InitializeComponent();
    }

    private void dockClicked(object? sender, RoutedEventArgs e)
    {
        
    }

    private void rabClicked(object? sender, RoutedEventArgs e)
    {
        
    }

    private void lernClicked(object? sender, RoutedEventArgs e)
    {
        
    }

    private void regClicked(object? sender, RoutedEventArgs e)
    {
        var newWindow = new TimeReg();
        newWindow.Show();
        this.Close();
    }

    private void tehClicked(object? sender, RoutedEventArgs e)
    {
        
    }
}