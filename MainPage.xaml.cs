using Microsoft.Maui.Controls;
using System;

namespace SyncCurrencyConverter
{
    public partial class MainPage : ContentPage
    {
        private Button selectedButton;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            
            if (selectedButton == clickedButton)
                return;
            
            if (selectedButton != null)
            {
                selectedButton.BackgroundColor = Colors.Transparent;
                selectedButton.TextColor = Colors.White;
            }
            
            clickedButton.BackgroundColor = Color.FromArgb("#FF860CB6");
            clickedButton.TextColor = Colors.White;
            
            selectedButton = clickedButton;

        }
    }
}