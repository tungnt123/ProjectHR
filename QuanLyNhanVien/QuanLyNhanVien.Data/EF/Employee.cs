using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Data
{
    public class Employee
    {

        [Key]
        public int IDE { get; set; }
        [Required]
        [Column(TypeName = "Nvarchar")]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Nhập địa chỉ ")]
        [Column(TypeName = "Nvarchar")]
        [MaxLength(100)]
        public string Adress { get; set; }
        [Required]
        [Column(TypeName = "Varchar")]
        [MaxLength(200)]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string PassWord { get; set; }
        [Column(TypeName = "Nvarchar")]
        [MaxLength(50)]
        public string Position { get; set; }
        [Column(TypeName = "Nvarchar")]
        [MaxLength(50)]
        public string Education { get; set; }
        public bool Status { get; set; }

        //public virtual ICollection<Salary> Salaries { get; set; }

    }
}
