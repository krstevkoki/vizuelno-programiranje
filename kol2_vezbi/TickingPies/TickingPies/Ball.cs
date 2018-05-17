using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickingPies
{
    [Serializable]
    public class Ball
    {
        public Point Center { get; set; }
        public Color Color { get; set; }
        public bool Disappeared { get; set; }

        public static readonly int Radius = 25;
        private static readonly int Diameter = 2 * Radius;

        private int _quarter;

        public Ball(Point center, Color color)
        {
            Center = center;
            Color = color;
            Disappeared = false;
            _quarter = 360;
        }

        public void DrawPie(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillPie(brush, Center.X - Radius, Center.Y - Radius,
                    Diameter, Diameter, 0, _quarter);
            }
        }

        public bool Tick()
        {
            _quarter -= 90;
            return _quarter == 0;
        }
    }
}
