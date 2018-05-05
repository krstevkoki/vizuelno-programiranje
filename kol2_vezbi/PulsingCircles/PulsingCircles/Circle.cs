using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulsingCircles
{
    [Serializable]
    public class Circle
    {
        public Color Color { get; set; }
        public Point Center { get; set; }
        private static readonly int StartRadius = 30;

        private int _currentRadius = StartRadius;
        private int _currentDiameter = 2 * StartRadius;

        public Circle(Point center, Color color)
        {
            Center = center;
            Color = color;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X - _currentRadius, Center.Y - _currentRadius,
                _currentDiameter, _currentDiameter);
            brush.Dispose();
        }

        public void IncrementRadius()
        {
            int increment = (int) ((10 / 100.0) * StartRadius);

            if (_currentRadius + increment > StartRadius * 2)
                _currentRadius = StartRadius;
            else
                _currentRadius += increment;

            _currentDiameter = 2 * _currentRadius;
        }
    }
}