using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLNhaSach.Class
{
    class XLLOAISP: XLBANG
    {
        public XLLOAISP() : base("LOAISP") { }

        public XLLOAISP(string pQuery) : base("LOAISP", pQuery) { }
    }
}
