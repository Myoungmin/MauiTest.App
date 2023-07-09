using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.ViewModels
{
    internal class DetailsPageViewModel
    {
        public DetailsPageViewModel() 
        {
            RectangleDrawable rectangleDrawable = new RectangleDrawable();
        }
    }

    internal class RectangleDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.StrokeColor = Colors.Red;
            canvas.StrokeSize = 4;
            canvas.DrawRectangle(10, 10, 100, 50);
        }
    }
}
