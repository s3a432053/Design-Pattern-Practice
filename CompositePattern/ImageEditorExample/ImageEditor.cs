namespace CompositePattern.ImageEditorExample
{
    // 客戶端程式碼通過所有元件的基本
    // 介面. 這樣，客戶端程式碼就可以支援簡單的葉片
    // 元件以及複雜的複合元件。
    public class ImageEditor
    {
        private readonly CompoundGraphic _all = new();

        public void Load()
        {
            _all.Add(new Dot(1, 2));
            _all.Add(new Circle(5, 3, 10));
        }

        // 將選定的組件合併為一個複合組件
        public void GroupSelected(List<IGraphic> graphics)
        {
            CompoundGraphic group = new();

            foreach (IGraphic graphic in graphics)
            {
                group.Add(graphic);
                _all.Remove(graphic);
            }

            _all.Add(group);

            // All components will be drawn.
            _all.Draw();
        }
    }
}
