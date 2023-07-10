using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiTest.ViewModels
{
    internal class DetailsPageViewModel : ObservableObject
    {
        private float _someScore;
        public float SomeScore
        {
            get => _someScore;
            set
            {
                if (_someScore == value) return;
                _someScore = value;
                OnPropertyChanged();
            }
        }

        public DetailsPageViewModel() 
        {
            SomeScore = 100;
        }
    }

    internal class RectangleDrawable : BindableObject, IDrawable
    {
        public static readonly BindableProperty ScoreProperty = BindableProperty.Create(nameof(Score), typeof(float), typeof(RectangleDrawable));

        public float Score
        {
            get => (float)GetValue(ScoreProperty);
            set => SetValue(ScoreProperty, value);
        }

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            var centerPoint = new PointF(320, Score);
            var circleRadius = 5;

            canvas.FillColor = Colors.Black;
            canvas.FillCircle(centerPoint, circleRadius);

            canvas.StrokeColor = Colors.Red;
            canvas.StrokeSize = 4;
            canvas.DrawRectangle(10, 10, 100, 50);
        }
    }
}
