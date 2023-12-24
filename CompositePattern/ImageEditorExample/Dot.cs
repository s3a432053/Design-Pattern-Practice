namespace CompositePattern.ImageEditorExample
{
    public class Dot : IGraphic
    {
        protected int x = 0;
        protected int y = 0;

        public Dot(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void Draw()
        {
            // Draw a dot at X and Y.
            Console.WriteLine($"畫一個位置在 ({x}, {y}) 的點");
        }

        public void Move(int x, int y)
        {
            this.x += x;
            this.y += y;
        }
    }
}
