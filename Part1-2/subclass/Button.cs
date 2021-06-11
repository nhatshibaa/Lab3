using System;

namespace Part1_2
{
    public class Button : Window
    {
        public Button(int top, int left) : base(top, left)
        {
        }
        
        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at {0}, {1}\n", top,left);
        }
    }
}