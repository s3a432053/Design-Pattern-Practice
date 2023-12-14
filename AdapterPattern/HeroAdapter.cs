using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    // 轉換器 => 符合英雄標準(繼承Interface)
    public class HeroAdapter : IHero
    {
        private UnionHero unionHero = null;
        public HeroAdapter(UnionHero unionHero)
        {
            // 注入合作英雄
            this.unionHero = unionHero;
        }

        // 將英雄行為改成 Attack()
        public void Attack()
        {
            unionHero.Touch();
        }
    }
}
