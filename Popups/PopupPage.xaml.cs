using CommunityToolkit.Maui.Views;

namespace ModalPopupTest.Popups;

public partial class PopupPage : Popup
{
	public PopupPage()
	{
		InitializeComponent();
	}

    // WORKAROUND: Uncomment the following code for a minor workaround

    //protected override async Task OnDismissedByTappingOutsideOfPopup()
    //{
    //    //return base.OnDismissedByTappingOutsideOfPopup();
    //    await App.Current.MainPage.Navigation.PopModalAsync();
    //}
}
