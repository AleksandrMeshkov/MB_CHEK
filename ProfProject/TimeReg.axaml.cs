using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace ProfProject;

public partial class TimeReg : Window
{
    public TimeReg()
    {
        InitializeComponent();
    }
    private bool isShiftStarted = false;

    private void RegBtnClick(object? sender, RoutedEventArgs e)
    {
        if (!isShiftStarted)
        {
            
            EventTb.Text = "Смена началась!";
            regBtn.Content = "Закончить смену"; 
            isShiftStarted = true; 
        }
        else
        {
            
            EventTb.Text = "Смена закончилась!";
            regBtn.Content = "Начать смену"; 
            isShiftStarted = false; 
        }
    }

    private void EventTbClick(object? sender, TextInputEventArgs e)
    {
        
    }
}