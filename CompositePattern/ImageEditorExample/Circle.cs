namespace CompositePattern.ImageEditorExample
{
    public class Circle : Dot
    {
        private int radius = 0;

        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            // Draw a circle at X and Y with radius R.
            Console.WriteLine($"畫一個 位置在 ({x}, {y}) 半徑為 {radius} 的圓");
        }
    }
}
