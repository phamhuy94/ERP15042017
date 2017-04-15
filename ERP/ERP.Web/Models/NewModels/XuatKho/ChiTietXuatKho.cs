﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP.Web.Models.NewModels.XuatKho
{
    public class ChiTietXuatKho
    {

        public string MA_HANG { get; set; }
        public string KHO { get; set; }
        public decimal DON_GIA { get; set; }
        public int SO_LUONG { get; set; }

        public string DVT { get; set; }
        public string TK_NO { get; set; }
        public string TK_CO { get; set; }
        public string TK_KHO { set; get; }
        public string DON_GIA_VON { set; get; }
    }
}