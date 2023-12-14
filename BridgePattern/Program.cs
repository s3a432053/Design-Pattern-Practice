


using BridgePattern;

Company beijingCompany = new BeijingCompany();
TestType manualTest = new ManualTest();
Prodeuct managementProdeuct = new ManagementProdeuct(beijingCompany, manualTest);
managementProdeuct.Run();

Company shanghaiCompany = new ShanghaiCompany();
TestType autoTest = new AutoTest();
Prodeuct operationProdeuct = new ManagementProdeuct(shanghaiCompany, autoTest);
operationProdeuct.Run();

Console.Read();