namespace MauiApp2;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void DigitClicked(object sender, EventArgs e)
	{
		DisplayLabel.Text += (sender as Button).Text;
	}
	private void CrossClicked(object sender, EventArgs e)
	{
		DisplayLabel.Text = "";
	}

	private void CheckMarkClicked(object sender, EventArgs e)
	{
		string _password = "1234";

		if (DisplayLabel.Text == _password)
		{
			DisplayLabel.Text = "Your Password is correct!";

			foreach (var btn in Container.Children.OfType<Button>())
			{
				btn.IsEnabled = false;
			}
		}
		else
		{
            CrossClicked(sender, e);
        }
    }
}

