using Microsoft.Maui.Controls;

namespace SyncCurrencyConverter;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnRadioCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value) 
        {
            RadioButton selected = (RadioButton)sender;
            selected.BackgroundColor = Colors.DodgerBlue;
            selected.TextColor = Colors.White;
        }
        else 
        {
            RadioButton deselected = (RadioButton)sender;
            deselected.BackgroundColor = Colors.Transparent;
        }
    }
}