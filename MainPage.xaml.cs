using Microsoft.Maui.Controls;
using System;

namespace SyncCurrencyConverter
{
    public partial class MainPage : ContentPage
    {
        private Button selectedButton;
        private double currentAmount = 0;

        public MainPage()
        {
            InitializeComponent();
            
            amountEntry.TextChanged += OnEntryTextChanged;
        }

        private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            string inputValue = e.NewTextValue;
            
            if (string.IsNullOrEmpty(inputValue))
            {
                statusLabel.Text = "Введите сумму в рублях...";
                currentAmount = 0;
                return;
            }
            
            if (double.TryParse(inputValue, out double amount))
            {
                currentAmount = amount;
                
                if (selectedButton != null)
                {
                    statusLabel.Text = $"{amount} ₽ → {selectedButton.Text}";
                }
                else
                {
                    statusLabel.Text = $"{amount} ₽. Выберите валюту";
                }
            }
            else
            {
                statusLabel.Text = "Введите корректное число!";
                currentAmount = 0;
            }
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
            
            // Устанавливаем символ валюты во второе поле
            currencySymbolEntry.Text = selectedButton.Text;
            
            // Обновляем статус
            if (currentAmount > 0)
            {
                statusLabel.Text = $"{currentAmount} ₽ → {selectedButton.Text}";
            }
            else
            {
                statusLabel.Text = $"Выбрана валюта: {selectedButton.Text}. Введите сумму";
            }
        }
    }
}