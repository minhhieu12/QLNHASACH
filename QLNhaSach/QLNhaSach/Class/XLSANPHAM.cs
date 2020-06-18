using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLNhaSach.Class
{
    class XLSANPHAM: XLBANG
    {
        public XLSANPHAM() : base("SANPHAM") { }

        public XLSANPHAM(string pQuery) : base("SANPHAM", pQuery) { }
    }
}
