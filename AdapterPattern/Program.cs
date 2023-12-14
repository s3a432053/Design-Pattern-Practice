
using AdapterPattern;

IHero hero = new MyHero();
IHero unionHero = new HeroAdapter(new UnionHero());
// 自家英雄進行 Attack
hero.Attack();
// 合作英雄透過 轉換器 後 也可以進行 Attack
unionHero.Attack();