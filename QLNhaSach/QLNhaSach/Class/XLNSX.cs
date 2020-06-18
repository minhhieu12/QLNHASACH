using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLNhaSach.Class
{
    class XLNSX: XLBANG
    {
        public XLNSX() : base("NSX") { }

        public XLNSX(string pQuery) : base("NSX", pQuery) { }
    }
}
