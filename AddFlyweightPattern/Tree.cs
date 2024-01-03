namespace AddFlyweightPattern
{
    // 此為樹 - 包含了 外部屬性 x, y 以及 TreeType(內部屬性)
    public class Tree
    {
        private int _x, _y;
        private TreeType _type;

        public Tree(int x, int y, TreeType type)
        {
            _x = x;
            _y = y;
            _type = type;
        }

        /// <summary>
        /// 在繪布上繪製樹
        /// </summary>
        /// <param name="canvas">繪布</param>
        public void Draw(string canvas)
        {
            _type.Draw(canvas, _x, _y);
        }
    }
}
