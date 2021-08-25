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
    [Table("Contractor")]
    public class Contractor : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(AutoGenerateField = false)]
        public int ContractorId { get; set; }

        [MinLength(4)]
        [MaxLength(16)]
        [Display(Name = "Mã Nhà Thầu")]
        public string ContractorCode { get; set; }

        [Display(Name = "Tên Nhà Thầu")]
        public string ContractorName { get; set; }

        [MinLength(10)]
        [MaxLength(14)]
        [Display(Name = "Mã Số Thuế")]
        public string TaxCode { get; set; }

        [Display(Name = "Địa Chỉ")]
        public string Address { get; set; }

        [Display(Name = "Người Đại Diện")]
        public string Representative { get; set; }

        [Display(Name = "TK Ngân Hàng Số")]
        public string BankAccountNo { get; set; }

        [Display(Name = "Tại Ngân Hàng")]
        public string BankName { get; set; }

        [Display(Name = "SĐT")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Danh Sách Hợp Đồng")]
        public virtual ICollection<Contract> Contracts { get; set; }

        public override string ToString()
        {
            return (ContractorCode + '-' + ContractorName); 
        }

    }
}
