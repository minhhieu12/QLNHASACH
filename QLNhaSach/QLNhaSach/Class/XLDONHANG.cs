using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLNhaSach.Class
{
    class XLDONHANG: XLBANG
    {
        public XLDONHANG() : base("DONHANG") { }

        public XLDONHANG(string pQuery) : base("DONHANG", pQuery) { }
    }
}
