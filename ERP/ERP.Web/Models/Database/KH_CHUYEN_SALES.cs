//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Web.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class KH_CHUYEN_SALES
    {
        public int ID { get; set; }
        public string MA_KHACH_HANG { get; set; }
        public string SALE_HIEN_THOI { get; set; }
        public string SALE_SAP_CHUYEN { get; set; }
        public string SALE_CU { get; set; }
        public string SALE_CU_2 { get; set; }
    
        public virtual CCTC_NHAN_VIEN CCTC_NHAN_VIEN { get; set; }
        public virtual CCTC_NHAN_VIEN CCTC_NHAN_VIEN1 { get; set; }
        public virtual CCTC_NHAN_VIEN CCTC_NHAN_VIEN2 { get; set; }
        public virtual CCTC_NHAN_VIEN CCTC_NHAN_VIEN3 { get; set; }
        public virtual KH KH { get; set; }
    }
}