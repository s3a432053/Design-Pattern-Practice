using CompositePattern.ImageEditorExample;
using CompositePattern.SafeShoppingExample;
using CompositePattern.TransparentShoppingExample;

ImageEditor imageEditor = new();

imageEditor.Load();

List<IGraphic> graphics = new()
{
    new Dot(1, 2),
    new Dot(3, 4),
    new Circle(3, 4, 8)
};

imageEditor.GroupSelected(graphics);

Console.WriteLine("------------分隔線------------");


TransparentExecutor transparentExecutor = new();
transparentExecutor.ExecutePattern();

Console.WriteLine("------------分隔線------------");

SafeExecutor safeExecutor = new();
safeExecutor.ExecutePattern();