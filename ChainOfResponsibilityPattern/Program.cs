using ChainOfResponsibilityPattern;

// 宣告不同管理層
Leader teamManager = new TeamManager();
Leader departmentManager = new DepartmentManager();
Leader technicalDirector = new TechnicalDirector();
Leader cto = new CTO();

// 組裝責任練

// 團隊經理 審核完 => 換 部門經理 審核
teamManager.SetNext(departmentManager);
// 部門經理 審核完 => 換 院長 審核
departmentManager.SetNext(technicalDirector);
// 院長 審核完 => 換 技術長 審核
technicalDirector.SetNext(cto);

// 提交 請假 請求 (請越多天假需要越高階的長官來審核)
teamManager.HandleRequest(8);
teamManager.HandleRequest(30);