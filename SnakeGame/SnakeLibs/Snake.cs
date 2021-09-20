using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace SnakeLib
{
    public class Snake
    {
        public List<Point> snakeElements { get; set; }
        private int direction;
        public int Direction
        {
            get
            {
                return this.direction;
            }
            set
            {
                if (value >= 0 && value < 5 && DoesCanChangeDirection(value)) this.direction = value;
            }
        }
        public int DirectionBuffer { get; set; }
        public Snake(int squareSideLength)
        {
            this.snakeElements = new List<Point>();
            this.Direction = 1;
            this.DirectionBuffer = 1;
            this.snakeElements.Add(new Point() { X = 0, Y = 0});
            this.snakeElements.Add(new Point() { X = squareSideLength, Y = 0});
            this.snakeElements.Add(new Point() { X = squareSideLength*2, Y = 0 });
        }
       
        public bool DoesCanChangeDirection(int value)
        {
            if (this.direction == 0 && value != 2) return true;
            if (this.direction == 2 && value != 0) return true;
            if (this.direction == 1 && value != 3) return true;
            if(this.direction == 3 && value != 1) return true;
            return false;
        }

    }
}
