namespace CompositePattern.ImageEditorExample
{
    // 複合類別代表複雜的元件
    // 有孩子。 複合物通常委託實際的
    // 給他們的孩子工作，然後「總結」結果。
    public class CompoundGraphic : IGraphic
    {
        private List<IGraphic> _graphics = new();

        public void Add(IGraphic graphic)
        {
            _graphics.Add(graphic);
        }

        public void Remove(IGraphic graphic)
        {
            _graphics.Remove(graphic);
        }

        public void Draw()
        {
            foreach (IGraphic graphic in _graphics)
            {
                graphic.Draw();
            }
        }

        public void Move(int x, int y)
        {
            foreach (IGraphic graphic in _graphics)
            {
                graphic.Move(x, y);
            }
        }
    }
}
