//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLPG.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoiVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoiVien()
        {
            this.BuoiTap = new HashSet<BuoiTap>();
            this.ChiTietDK_GoiTap = new HashSet<ChiTietDK_GoiTap>();
        }
    
        public int id_HV { get; set; }
        public Nullable<int> id_TV { get; set; }
        public string HinhAnh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string CCCD { get; set; }
        public Nullable<bool> TinhTrang { get; set; }
        public Nullable<System.DateTime> NgayGiaNhap { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuoiTap> BuoiTap { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDK_GoiTap> ChiTietDK_GoiTap { get; set; }
        public virtual ThanhVien ThanhVien { get; set; }
    }
}
