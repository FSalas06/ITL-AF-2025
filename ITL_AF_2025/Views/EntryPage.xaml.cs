using ITL_AF_2025.ViewModels;

namespace ITL_AF_2025.Views;

public partial class EntryPage : ContentPage
{
	private EntryViewModel entryViewModel;
	public EntryPage()
	{
		InitializeComponent();
		BindingContext = entryViewModel = new EntryViewModel();
    }
}
