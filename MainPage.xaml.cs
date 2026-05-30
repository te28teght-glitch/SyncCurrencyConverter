namespace SyncCurrencyConverter;

public partial class MainPage : ContentPage
{
	int count = 0;
	int roundCount = 0;
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object? sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
	private void OnCounterClickedRound(object? sender, EventArgs e)
	{
		roundCount++;
		double newHeight = 40 + (roundCount * 10);	
		if (newHeight <=200)
		{
			Rounded.HeightRequest = newHeight;
			Rounded.Text = $"Round {roundCount}";
		}
		else
		{
			Rounded.Text = "Max!";
		}
		SemanticScreenReader.Announce(Rounded.Text);
	}
}
