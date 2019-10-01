using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Data
{
   public class Salary
    {
        [Key]
        public int IDS { get; set; }
        public DateTime NgayDiLam { get; set; }
        public int TongSoNgayDiLam { get; set; }
        public int NgayNghiViec { get; set; }
        public int LuongCoBan { get; set; }
        public int TongSoLuong { get; set; }
        public int IDE { get; set; }

        //public virtual Employee Employee { get; set; }
    }
}
