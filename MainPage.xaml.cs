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
            
            // Подписываем событие для поля ввода
            amountEntry.TextChanged += OnEntryTextChanged;
        }

        // Событие при изменении текста в поле ввода
        private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            string inputValue = e.NewTextValue; // Получаем новый текст
            string inputSum = e.NewTextValue;
            if (string.IsNullOrEmpty(inputValue))
            {
                statusLabel.Text = "Введите сумму в рублях...";
                return;
            }

            if ()
            {
                
            }
            
            if (double.TryParse(inputValue, out double amount))
            {
                if (selectedButton != null)
                {
                    statusLabel.Text = $"Выбрана: {selectedButton.Text}, Сумма: {amount} ₽";
                }
                else
                {
                    statusLabel.Text = $"Сумма: {amount} ₽. Выберите валюту";
                }
            }
            else
            {
                statusLabel.Text = "Введите корректное число!";
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
            
    
        }
    }
}