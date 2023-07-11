using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace MauiTest.ViewModels
{
    internal class DetailsPageViewModel : ObservableObject
    {
        private Color _color;
        public Color ColorProperty
        {
            get => _color;
            set
            {
                if (_color == value) return;
                _color = value;
                OnPropertyChanged();
            }
        }

        public GraphicsView GraphicsView { get; set; }

        public ICommand ColorCommand { get; }

        public DetailsPageViewModel()
        {
            ColorCommand = new Command(() => OnColorButtonClicked());
            ColorProperty = Colors.Black;
        }

        private void OnColorButtonClicked()
        {
            ColorProperty = Colors.Blue;
            GraphicsView.Invalidate(); 
        }
    }

    internal class RectangleDrawable : BindableObject, IDrawable
    {
        public static readonly BindableProperty ColorValueProperty = BindableProperty.Create(nameof(ColorValue), typeof(Color), typeof(RectangleDrawable));

        public Color ColorValue
        {
            get => (Color)GetValue(ColorValueProperty);
            set => SetValue(ColorValueProperty, value);
        }

        public RectangleDrawable()
        {
            ColorValue = Colors.Red;
        }

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            var centerPoint = new PointF(320, 100);
            var circleRadius = 5;

            canvas.FillColor = Colors.Black;
            canvas.FillCircle(centerPoint, circleRadius);

            canvas.StrokeColor = ColorValue;
            canvas.StrokeSize = 4;
            canvas.DrawRectangle(10, 10, 100, 50);
        }
    }
}
