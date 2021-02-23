using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Snakes
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        public ConsoleColor color;
        public Point(Point tail)
        {
        }
        public Point(int x_, int y_, char sym_, ConsoleColor color_)
        {
            x = x_;
            y = y_;
            sym = sym_;
            color = color_;
        }
        public Point(Point p, ConsoleColor color_)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
            color = color_;
        }

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else
            {
                y = y + offset;
            }

        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(sym);
        }
        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }

        internal bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
