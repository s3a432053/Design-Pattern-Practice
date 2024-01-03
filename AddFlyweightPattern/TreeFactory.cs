namespace AddFlyweightPattern
{
    /// <summary>
    /// 樹工廠 負責檢查 TreeType 是否存在
    /// 已存在 => 直接回傳
    /// 不存在 => 創建新的回傳
    /// 注意 Factory 必須宣告為 static 內部的 _treeTypes 才可以保持唯一性
    /// </summary>
    public static class TreeFactory
    {
        private static List<TreeType> _treeTypes = new();

        public static TreeType GetTreeType(string name,string color,string texture)
        {
            TreeType? type = _treeTypes.Find(x => x._name == name && x._color == color && x._texture == texture);

            if (type == null)
            {
                type = new TreeType(name, color, texture);
                _treeTypes.Add(type);
            }

            return type;
        }
    }
}
