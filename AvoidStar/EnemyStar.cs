using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AvoidStar
{   // 별의 위치, 별의 존재여부
    class EnemyStar
    {
        int ex;
        int ey;

        #region Property
        public int Ex
        {
            get { return ex; }
            set { ex = value; }
        }

        public int Ey
        {
            get { return ey; }
            set { ey = value; }
        }

        
        #endregion
        public EnemyStar() { }

        public EnemyStar(int ex, int ey)
        {
            this.ex = ex;
            this.ey = ey;
        }

    }
}
