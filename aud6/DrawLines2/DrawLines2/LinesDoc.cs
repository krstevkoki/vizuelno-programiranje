using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLines2
{
    public class LinesDoc
    {
        public bool Positioner { get; set; }
        public Color Color { get; set; }
        public int Thickness { get; set; }
        public Point CurrentLocation { get; set; }

        private Point _previousLocation;
        private readonly int _width;
        private readonly int _height;
        private readonly List<Line> _lines;
        private readonly Stack<Action> _undoStack;
        private readonly Stack<Action> _redoStack;

        public LinesDoc(int width, int height)
        {
            _width = width;
            _height = height;
            Color = Color.Black;
            Thickness = Convert.ToInt32(LineThickness.Normal);
            Positioner = true;

            _previousLocation = Point.Empty;
            _lines = new List<Line>();
            _undoStack = new Stack<Action>();
            _redoStack = new Stack<Action>();
        }

        public void AddLine(Point location)
        {
            if (!_previousLocation.IsEmpty)
            {
                var line = new Line(_previousLocation, location, Color, Thickness);
                _lines.Add(line);
                _undoStack.Push(new Action() {Line = line, Type = ActionType.Add});
                _redoStack.Clear();
            }

            _previousLocation = location;
        }

        public void Draw(Graphics g)
        {
            foreach (var line in _lines)
                line.Draw(g);

            if (Positioner)
            {
                Pen pen = new Pen(Color.Gray, 1);
                pen.DashStyle = DashStyle.Dot;
                g.DrawLine(pen, new Point(0, CurrentLocation.Y), new Point(_width, CurrentLocation.Y));
                g.DrawLine(pen, new Point(CurrentLocation.X, 0), new Point(CurrentLocation.X, _height));
                pen.Dispose();
            }
        }

        public void Move(int dx, int dy)
        {
            foreach (var line in _lines)
            {
                line.Start = new Point(line.Start.X + dx, line.Start.Y + dy);
                line.End = new Point(line.End.X + dx, line.End.Y + dy);
                _previousLocation = line.End;
            }
        }

        public void Undo()
        {
            if (_undoStack.Count != 0)
            {
                var action = _undoStack.Pop();
                _lines.Remove(action.Line);
                _redoStack.Push(action);
                _previousLocation = action.Line.Start;
            }
        }

        public void Redo()
        {
            if (_redoStack.Count != 0)
            {
                var action = _redoStack.Pop();
                _lines.Add(action.Line);
                _undoStack.Push(action);
                _previousLocation = action.Line.End;
            }
        }

        public void UpdateLocation(Point newLocation)
        {
            CurrentLocation = newLocation;
        }

        public int GetLinesNumber()
        {
            return _lines.Count;
        }
    }
}