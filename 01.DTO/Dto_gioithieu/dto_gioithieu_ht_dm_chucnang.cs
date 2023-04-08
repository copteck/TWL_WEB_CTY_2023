using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace Dto_gioithieu
{
    [Table("gioithieu_ht_dm_chucnang")]
    public class dto_gioithieu_ht_dm_chucnang
    {
        [Key]
        public string ma_chucnang { get; set; }
        public string ten_chucnang { get; set; }
        public string loai_chucnang { get; set; }
        public Nullable<int> cap_menu { get; set; }
        public Nullable<int> LargeWidth { get; set; }
        public string RibbonStyle { get; set; }
        public Nullable<bool> BeginGroup { get; set; }
        public string IconImg { get; set; }
        public string url { get; set; }
        public string phanquyen_nsd { get; set; }
        public int? sott { get; set; }
        public string ma_chucnang_cha { get; set; }
        public string loai_menu { get; set; }
        public string is_web { get; set; }
        public Nullable<bool> khong_quanly { get; set; }
        public Nullable<bool> khong_sudung { get; set; }
        public Nullable<bool> khong_hienthi { get; set; }
        public Nullable<System.DateTime> ngaysua { get; set; }
        public string nguoisua { get; set; }
        public Nullable<int> daxoa { get; set; }
        public string rowlog { get; set; }
    }
}