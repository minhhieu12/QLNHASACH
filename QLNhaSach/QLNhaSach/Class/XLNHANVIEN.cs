﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLNhaSach.Class
{
    class XLNHANVIEN: XLBANG
    {
        public XLNHANVIEN() : base("NHANVIEN") { }

        public XLNHANVIEN(string pQuery) : base("NHANVIEN", pQuery) { }
    }
}
