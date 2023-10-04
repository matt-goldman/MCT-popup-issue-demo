using CommunityToolkit.Maui.Views;
using ModalPopupTest.Popups;

namespace ModalPopupTest.Pages;

public partial class ModalPage : ContentPage
{
	public ModalPage()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		var popup = new PopupPage();

		this.ShowPopup(popup);
    }
}
