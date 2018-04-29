using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallChaos
{
    [Serializable]
    public class BallDoc
    {
        public List<Ball> BallList { get; set; }
        private readonly Stack<Action> _undoStack;
        private readonly Stack<Action> _redoStack;

        public BallDoc()
        {
            BallList = new List<Ball>();
            _undoStack = new Stack<Action>();
            _redoStack = new Stack<Action>();
        }

        public void AddBall(Ball ball)
        {
            BallList.Add(ball);
            var action = new Action() {Ball = ball, CurrentAction = Actions.Add};
            _undoStack.Push(action);
        }

        public void Move(int left, int top, int width, int height)
        {
            foreach (var ball in BallList)
                ball.Move(left, top, width, height);
        }

        public void Draw(Graphics g)
        {
            foreach (var ball in BallList)
                ball.Draw(g);
        }

        public void CheckCollisions()
        {
            for (int i = 0; i < BallList.Count - 1; ++i)
            {
                for (int j = i + 1; j < BallList.Count; ++j)
                {
                    if (BallList[i].AreColiding(BallList[j]))
                    {
                        BallList[i].IsColided = true;
                        BallList[j].IsColided = true;
                    }
                }
            }

            for (int i = BallList.Count - 1; i >= 0; --i)
                if (BallList[i].IsColided)
                    BallList.RemoveAt(i);
        }

        public void Undo()
        {
            if (_undoStack.Count != 0)
            {
                var action = _undoStack.Pop();
                if (action.CurrentAction == Actions.Add)
                {
                    BallList.Remove(action.Ball);
                }

                _redoStack.Push(action);
            }
        }

        public void Redo()
        {
            if (_redoStack.Count != 0)
            {
                var action = _redoStack.Pop();
                if (action.CurrentAction == Actions.Add)
                {
                    BallList.Add(action.Ball);
                }

                _undoStack.Push(action);
            }
        }

        public void ClearRedoStack()
        {
            _redoStack.Clear();
        }
    }
}