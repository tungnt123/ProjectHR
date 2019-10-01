using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Data.EF
{
   public class NhanVienDbContext :DbContext
    {
        public NhanVienDbContext() : base("NhanVienDbContext")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Salary> Salaries { get; set; }

    }
}
