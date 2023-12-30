using chronos.presenters.ViewModel;

namespace chronos.ui.Pages;

public partial class WatchPage : ContentPage
{
	public WatchPage(Watch vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}