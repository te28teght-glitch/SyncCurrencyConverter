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
                selectedButton.BackgroundColor = Color.FromArgb("#FF860CB6");
                selectedButton.TextColor = Colors.White;
            }
            
            clickedButton.BackgroundColor = Colors.White;
            clickedButton.TextColor = Color.FromArgb("#FF860CB6");
            
            selectedButton = clickedButton;
            
            statusLabel.Text = $"Выбрана: {clickedButton.Text}";
        }
    }
}