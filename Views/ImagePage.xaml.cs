using MauiTest.ViewModels;

namespace MauiTest;

public partial class ImagePage : ContentPage
{
    private ImagePageViewModel _viewModel;

    public ImagePage()
	{
		InitializeComponent();

        _viewModel = new ImagePageViewModel();
        BindingContext = _viewModel;
        _viewModel.Image = ImageXName;
    }
}