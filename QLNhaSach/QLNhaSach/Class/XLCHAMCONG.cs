using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLNhaSach.Class
{
    class XLCHAMCONG: XLBANG
    {
        public XLCHAMCONG() : base("CHAMCONG") { }

        public XLCHAMCONG(string pQuery) : base("CHAMCONG", pQuery) { }
    }
}
