using StateDiagram;

Player user = new();
user.level = 1; // 玩家等級
user.oldStateWork(); // 玩家狀態處理
user.level = 20;
user.oldStateWork();
user.level = 62;
user.oldStateWork();
user.level = 93;
user.oldStateWork();

Console.ReadLine();