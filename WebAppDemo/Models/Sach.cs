//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppDemo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sach
    {
        public string Ma { get; set; }
        public string MaPhanLoai { get; set; }
        public string Ten { get; set; }
        public string HinhBia { get; set; }
        public string TomTat { get; set; }
        public string Link { get; set; }
        public System.DateTime NgayXuatBan { get; set; }
        public string NhaXuatBan { get; set; }
        public string TenTacGia { get; set; }
        public bool DaXoa { get; set; }
        public System.DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public Nullable<System.DateTime> NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public Nullable<System.DateTime> NgayXoa { get; set; }
        public string NguoiXoa { get; set; }
    
        public virtual PhanLoaiSach PhanLoaiSach { get; set; }
    }
}