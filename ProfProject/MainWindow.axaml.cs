using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Tmds.DBus.Protocol;

namespace ProfProject;

public partial class MainWindow : Window
{
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private async void Block()
    {
        if (!string.IsNullOrEmpty(PsdBox.Text) && !string.IsNullOrEmpty(LgBox.Text))
        {
            SignBtn.IsEnabled = true;
            var newWindow = new Menu();
            newWindow.Show();
            this.Close();
        }
        else
        {
            ErorBlock.Text = "Заполните все поля";
            SignBtn.IsEnabled = false; 
            await Task.Delay(5000); 
            SignBtn.IsEnabled = true; 
        }
    }

    
    private void ButtonClicked(object? sender, RoutedEventArgs e)
    {
        Block();
        
        
        
    }

    private void LinkClicked(object? sender, RoutedEventArgs e)
    {
        
    }

    
    private void LgTextChanged(object? sender, TextChangedEventArgs e)
    {
        
    }

    private void PsdTextChanged(object? sender, TextChangedEventArgs e)
    {
        
    }

    private void ErorTB(object? sender, TextInputEventArgs e)
    {
        
    }
}