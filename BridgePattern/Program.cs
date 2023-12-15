using BridgePattern.CompanyExample.CompanyDocument;
using BridgePattern.CompanyExample.ProductDocument;
using BridgePattern.CompanyExample.TestDocument;
using BridgePattern.ShapeAndColor.After.ColorDocument;
using BridgePattern.ShapeAndColor.After.ShapeDocument;
using BridgePattern.ShapeAndColor.Before;

// 使用橋接模式 實現 不同公司 使用 不同測試方法 對 不同產品進行測試
Company beijingCompany = new BeijingCompany();
TestType manualTest = new ManualTest();
Prodeuct managementProdeuct = new ManagementProdeuct(beijingCompany, manualTest);
managementProdeuct.Run();

Company shanghaiCompany = new ShanghaiCompany();
TestType autoTest = new AutoTest();
Prodeuct operationProdeuct = new ManagementProdeuct(shanghaiCompany, autoTest);
operationProdeuct.Run();

Console.Read();

// 使用橋接模式前 產出 不同形狀 不同顏色 的 實體
Shape blueCircle = new BlueCircle();
Shape redCircle = new RedCircle();
Shape blueRectangle = new BlueRectangle();
Shape redRectangle = new RedRectangle();

blueCircle.Draw();
redCircle.Draw();
blueRectangle.Draw();
redRectangle.Draw();

Console.Read();

// 使用橋接模式後 產出 不同形狀 不同顏色 的 實體
AbstractShape blueCircle2 = new Circle(new Blue());
AbstractShape redCircle2 = new Circle(new Red());
AbstractShape blueRectangle2 = new Rectangle(new Blue());
AbstractShape redRectangle2 = new Rectangle(new Red());
blueCircle2.GetShape();
redCircle2.GetShape();
blueRectangle2.GetShape();
redRectangle2.GetShape();

Console.Read();