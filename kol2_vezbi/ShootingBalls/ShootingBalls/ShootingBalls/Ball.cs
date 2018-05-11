using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingBalls
{
    [Serializable]
    public class Ball
    {
        public Point Center { get; set; }
        public Color Color { get; set; }
        public int Radius { get; set; }
        public bool Disappeared { get; set; }
        private int _colorIndex;
        private int _diameter;

        public Ball(int width, int height)
        {
            var random = new Random();
            _colorIndex = random.Next(ColorPicker.Count);
            Color = ColorPicker.Pick(_colorIndex);
            Radius = random.Next(20, 80);
            _diameter = 2 * Radius;
            Center = new Point(random.Next(_diameter, width - _diameter),
                random.Next(_diameter + 30, height - _diameter - 15));
            Disappeared = false;
        }

        // Only for bombs
        public Ball(Point center, Color color)
        {
            Center = center;
            Color = color;
            Radius = 50;
            _diameter = 2 * Radius;
            Disappeared = false;
            _colorIndex = -1;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, _diameter, _diameter);
            brush.Dispose();
        }

        public bool Tick()
        {
            if (Disappeared)
                return true;
            _colorIndex = (_colorIndex + 1) % ColorPicker.Count;
            Color = ColorPicker.Pick(_colorIndex);
            Radius -= 5;
            _diameter = 2 * Radius;
            return Radius <= 10;
        }

        public int IsHit(Point point)
        {
            var hit = CalculateDistance.Calculate(Center, point) <= _diameter;
            int points = 0;

            if (hit)
            {
                Color = Color.Red;
                points = (_colorIndex + 1) * 5;
            }

            return points;
        }

        public bool Colide(Ball ball)
        {
            var distance = CalculateDistance.Calculate(Center, ball.Center);
            return distance <= (Radius + ball.Radius);
        }
    }

    public static class CalculateDistance
    {
        public static double Calculate(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        }
    }

    public static class ColorPicker
    {
        private static readonly Color[] Colors = new Color[] {Color.Orange, Color.Blue, Color.Green};

        public static int Count
        {
            get { return Colors.Length; }
        }

        public static Color Pick(int index)
        {
            if (index >= 0 && index < Count)
                return Colors[index];
            return Color.Empty;
        }
    }
}