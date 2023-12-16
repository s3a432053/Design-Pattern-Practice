using AbstractFactoryPattern.FactoryDocument;
using AbstractFactoryPattern.ProductDocument.AudiProduct;
using AbstractFactoryPattern.ProductDocument.BMWProduct;

// 實現 SUV 系列工廠
AbstractFactory factorySUV = new SUVFactory();
Console.WriteLine("----- SUV Factory -----");

// 透過 SUV 工廠 產出 奧迪 品牌的車
Audi suvAudi = factorySUV.createAudi();
Console.WriteLine(suvAudi.getBrand() + "的" + suvAudi.getType());

// 透過 SUV 工廠 產出 BMW 品牌的車
BMW suvBMW = factorySUV.createBMW();
Console.WriteLine(suvBMW.getBrand() + "的" + suvBMW.getType());


// 實現 吉普車 系列工廠
AbstractFactory factoryJeep = new JeepFactory();
Console.WriteLine("----- Jeep Factory -----");

// 透過 吉普車 工廠 產出 奧迪 品牌的車
Audi jeepAudi = factoryJeep.createAudi();
Console.WriteLine(jeepAudi.getBrand() + "的" + jeepAudi.getType());

// 透過 吉普車 工廠 產出 BMW 品牌的車
BMW jeepBMW = factoryJeep.createBMW();
Console.WriteLine(jeepBMW.getBrand() + "的" + jeepBMW.getType());