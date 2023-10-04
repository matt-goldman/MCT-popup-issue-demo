using ModalPopupTest.Pages;

namespace ModalPopupTest;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnModalClicked(object sender, EventArgs e)
	{
		Console.WriteLine("[MainPage] Show  modal clicked");
		await Navigation.PushModalAsync(new ModalPage());
	}
}


