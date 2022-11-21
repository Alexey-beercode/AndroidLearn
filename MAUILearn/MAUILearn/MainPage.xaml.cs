namespace MAUILearn;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		CounterBtn.Text = $"Нажато {count} раз";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

