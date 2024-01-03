namespace AddFlyweightPattern
{
    // 樹的類型 - 此為 內部對象 只有常見的幾種屬性
    public class TreeType
    {
        public string _name;
        public string _color;
        public string _texture;

        public TreeType(string name, string color, string texture)
        {
            _name = name;
            _color = color;
            _texture = texture;
        }

        public void Draw(string canvas, int x, int y)
        {
            Console.WriteLine($"在 {canvas}畫布 的 座標位置({x}, {y}) 畫上一顆 {_color}色 的 {_name}樹 樹的紋理為{_texture}");
        }
    }
}
