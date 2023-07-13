using CommunityToolkit.Mvvm.ComponentModel;
using System.IO;
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

        private async void OnChangeImageClicked()
        {
            //Image.Source = "campus.jpg";

            byte[] imageAsBytes = await Download("https://aka.ms/campus.jpg");
            var stream = new MemoryStream(imageAsBytes);
            Image.Source = ImageSource.FromStream(() => (Stream)stream);
        }

        public async Task<byte[]> Download(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                byte[] fileArray = await client.GetByteArrayAsync(url);
                return fileArray;
            }
        }
    }
}
