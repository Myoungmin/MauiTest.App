using MauiTest.ViewModels;

namespace MauiTest;

public partial class DetailsPage : ContentPage
{
    private DetailsPageViewModel _viewModel;
    public DetailsPage()
	{
		InitializeComponent();
        _viewModel = new DetailsPageViewModel();
        BindingContext = _viewModel;
        _viewModel.GraphicsView = GraphicsViewName;
    }
}