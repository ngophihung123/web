//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wwââ.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;


    public partial class AnhChiTietSP
    {
        [DisplayName("Mã ảnh")]
        public string MaAnh { get; set; }
        [DisplayName("Mã sản phẩm theo mẫu")]
        public string MaSPTheoMau { get; set; }
        [DisplayName("Tên File ảnh")]
        public string TenFileAnh { get; set; }
        [DisplayName("Sản phẩm theo mẫu")]
        public virtual SPtheoMau SPtheoMau { get; set; }
    }
}
