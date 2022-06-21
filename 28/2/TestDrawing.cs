using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _2
{
    class TestDrawing : Control
    {
        protected override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.DrawEllipse(Brushes.Transparent, new Pen(Brushes.Black, 1), new Point(-300, -100), 10, 10);
            drawingContext.DrawEllipse(Brushes.Transparent, new Pen(Brushes.Black, 1), new Point(-300, -100), 20, 20);
            drawingContext.DrawEllipse(Brushes.Transparent, new Pen(Brushes.Black, 1), new Point(-300, -100), 30, 30);
            Rect rec = new Rect(-300, -50, Width = 30, Height = 50);
            Rect rec1 = new Rect(-280, -25, Width = 30, Height = 50);
            Rect rec2 = new Rect(-260, 0, Width = 30, Height = 50);
            Rect rec3 = new Rect(-240, 25, Width = 30, Height = 50);
            Rect rec4 = new Rect(-220, 50, Width = 30, Height = 50);

            Rect rec5 = new Rect(-200, -150, Width = 30, Height = 30);
            Rect rec6 = new Rect(-170, -150, Width = 30, Height = 30);
            Rect rec7 = new Rect(-140, -150, Width = 30, Height = 30);
            Rect rec8 = new Rect(-200, -120, Width = 30, Height = 30);
            Rect rec9 = new Rect(-170, -120, Width = 30, Height = 30);
            Rect rec10 = new Rect(-140, -120, Width = 30, Height = 30);
            Rect rec11 = new Rect(-200, -90, Width = 30, Height = 30);
            Rect rec12 = new Rect(-170, -90, Width = 30, Height = 30);
            Rect rec13 = new Rect(-140, -90, Width = 30, Height = 30);
            Rect rec14 = new Rect(40, 90, Width = 110, Height = 50);

            drawingContext.DrawRectangle(Brushes.Transparent, new Pen(Brushes.Black, 1),rec);
            drawingContext.DrawRectangle(Brushes.Transparent, new Pen(Brushes.Black, 1), rec1);
            drawingContext.DrawRectangle(Brushes.Transparent, new Pen(Brushes.Black, 1), rec2);
            drawingContext.DrawRectangle(Brushes.Transparent, new Pen(Brushes.Black, 1), rec3);
            drawingContext.DrawRectangle(Brushes.Transparent, new Pen(Brushes.Black, 1), rec4);

            drawingContext.DrawRectangle(Brushes.Black, new Pen(Brushes.Black, 1), rec5);
            drawingContext.DrawRectangle(Brushes.White, new Pen(Brushes.Black, 1), rec6);
            drawingContext.DrawRectangle(Brushes.Black, new Pen(Brushes.Black, 1), rec7);
            drawingContext.DrawRectangle(Brushes.White, new Pen(Brushes.Black, 1), rec8);
            drawingContext.DrawRectangle(Brushes.Black, new Pen(Brushes.Black, 1), rec9);
            drawingContext.DrawRectangle(Brushes.White, new Pen(Brushes.Black, 1), rec10);
            drawingContext.DrawRectangle(Brushes.Black, new Pen(Brushes.Black, 1), rec11);
            drawingContext.DrawRectangle(Brushes.White, new Pen(Brushes.Black, 1), rec12);
            drawingContext.DrawRectangle(Brushes.Black, new Pen(Brushes.Black, 1), rec13);

            drawingContext.DrawRoundedRectangle(Brushes.Black, new Pen(Brushes.Black, 1), rec14,12,12);
            base.OnRender(drawingContext);
        }
    }
}
