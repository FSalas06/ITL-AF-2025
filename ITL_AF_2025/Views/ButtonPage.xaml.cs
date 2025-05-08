using ITL_AF_2025.ViewModels;

namespace ITL_AF_2025.Views;

public partial class ButtonPage : ContentPage
{
	private ButtonViewModel _viewModel;

	public ButtonPage()
	{
		InitializeComponent();
		BindingContext = _viewModel =new ButtonViewModel();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		_viewModel.OnAppearing();
    }
}
