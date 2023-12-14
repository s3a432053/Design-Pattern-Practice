using Microsoft.Extensions.Configuration;
using SimpleFactoryPattern;

// 透過 .json 檔 的 accessType 欄位來決定向工廠要什麼實體
IConfiguration config = new ConfigurationBuilder()
           .AddJsonFile("appSetting.json", optional: true, reloadOnChange: true)
           .Build();

ReportStatistic reportStatistic = new(config["accessType"]);
Console.WriteLine(reportStatistic.Sum());
Console.ReadLine();