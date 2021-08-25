using HTA.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTA.Model.Models
{
    [Table("ContractApendix")]
    public class ContractApendix : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(AutoGenerateField = false)]
        public int ContractApendixId { get; set; }

        [Display(Name = "Thứ Tự")]
        public int Order { get; set; }

        [Display(Name = "Tên Phụ Lục")]
        public string ContractApendixName { get; set; }

        [Display(Name = "Chi tiết")]
        public string Description { get; set; }

        [Display(Name = "Giá trị điều chỉnh")]
        [DataType(DataType.Currency)]
        public double AdjustedValue { get; set; }

        [Display(Name = "Mã Hợp Đồng")]
        public int ContractId { get; set; }

        [Display(Name = "Hợp Đồng")]
        public virtual Contract Contract { get; set; }

        public override string ToString()
        {
            return ContractApendixName + " - " + Description;
        }
    }
}
