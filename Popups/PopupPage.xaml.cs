using CommunityToolkit.Maui.Views;

namespace ModalPopupTest.Popups;

public partial class PopupPage : Popup
{
	public PopupPage()
	{
		InitializeComponent();
	}

    protected override async Task OnDismissedByTappingOutsideOfPopup()
    {
        //return base.OnDismissedByTappingOutsideOfPopup();
        await App.Current.MainPage.Navigation.PopModalAsync();
    }
}
