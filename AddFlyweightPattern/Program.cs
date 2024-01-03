using AddFlyweightPattern;

// 宣告森林
Forest forest = new();

// 種樹
forest.PlantTree(10, 12, "橡膠", "綠", "橫紋");
forest.PlantTree(12, 9, "本樟", "紅", "橫紋");
forest.PlantTree(15, 22, "本樟", "紅", "橫紋");

// 將種好的樹畫在繪布上
forest.Draw("帆");
forest.Draw("棉");