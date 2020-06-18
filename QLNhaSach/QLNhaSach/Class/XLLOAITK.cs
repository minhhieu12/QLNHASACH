using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLNhaSach.Class
{
    class XLLOAITK: XLBANG
    {
        public XLLOAITK() : base("LOAITK") { }

        public XLLOAITK(string pQuery) : base("LOAITK", pQuery) { }
    }
}
