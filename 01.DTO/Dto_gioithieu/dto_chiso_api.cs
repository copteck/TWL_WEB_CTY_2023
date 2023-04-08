using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto_gioithieu
{
    public class dto_chiso_api
    {

        public string  ma { get; set; }
        public string ten { get; set; }
        public string hinhah_banner { get; set; }
        public string hinhanh_icon { get; set; }
        public int? stt { get; set; } = 0;
        public string tieude { get;set; }
        public string noidung { get; set; }
        public dto_chiso_api() { 
        }

    }
}
