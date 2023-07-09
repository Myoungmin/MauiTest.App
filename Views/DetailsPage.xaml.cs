using MauiTest.ViewModels;

namespace MauiTest;

public partial class DetailsPage : ContentPage
{
    DetailsPageViewModel viewModel;
    public DetailsPage()
	{
		InitializeComponent();
        viewModel = new DetailsPageViewModel();
        BindingContext = viewModel;
    }
}