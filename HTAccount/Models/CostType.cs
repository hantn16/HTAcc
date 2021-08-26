using HTAccount.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTAccount.Models
{
    [Table("CostType")]
    public class CostType : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CostTypeId { get; set; }

        [Display(Name = "Tên Loại Chi Phí")]
        public string CostTypeName { get; set; }
        [Display(Name = "Mã Loại Chi Phí")]
        public string Code { get; set; }

        public virtual ICollection<Work> Works { get; set; }

        public override string ToString()
        {
            return Code;
        }
    }
    //public enum CostType
    //{
    //    Construction =1,
    //    Equipment = 2,
    //    ProjectManagement = 3,
    //    Clearance = 4,
    //    Sale = 6,
    //    ConsultancyAndDesign = 5,
    //    Other = 7
    //}
}
