using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace MauiTest.ViewModels
{
    public class ImagePageViewModel : ObservableObject
    {
        public Image Image { get; set; }

        public ICommand ChangeImageCommand { get; }

        public ImagePageViewModel() 
        {
            ChangeImageCommand = new Command(OnChangeImageClicked);
        }

        private void OnChangeImageClicked()
        {
            Image.Source = "campus.jpg";
        }
    }
}
