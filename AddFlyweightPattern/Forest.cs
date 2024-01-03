namespace AddFlyweightPattern
{
    /// <summary>
    /// 森林 包含多個 Tree
    /// </summary>
    public class Forest
    {
        public List<Tree> trees = new();

        /// <summary>
        /// 種樹 透過 Factory 取得 TreeType
        /// 生成 Tree 後存入 trees
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="texture"></param>
        public void PlantTree(int x, int y, string name, string color, string texture)
        {
            TreeType type = TreeFactory.GetTreeType(name, color, texture);
            Tree tree = new(x, y, type);
            trees.Add(tree);
        }

        /// <summary>
        /// 將森林中所有 Tree 繪製到 繪布 上
        /// </summary>
        /// <param name="canvas">繪布</param>
        public void Draw(string canvas)
        {
            foreach(Tree tree in trees)
            {
                tree.Draw(canvas);
            }
        }
    }
}
