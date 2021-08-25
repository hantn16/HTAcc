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
    [Table("Project")]
    [DisplayColumn("Name")]
    public class Project : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(AutoGenerateField = false)]
        public int ProjectId { get; set; }

        [MaxLength(8)]
        [Display(Name ="Mã Dự Án")]
        public string Code { get; set; }

        [Display(Name = "Tên Dự Án")]
        public string Name { get; set; }

        [Display(Name = "Ngày Khởi Công")]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime? StartDate { get; set; }

        [Display(Name = "Ngày Hoàn Công")]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Danh Sách Hạng Mục")]
        public virtual ICollection<Work> Works { get; set; }

        [Display(Name = "Danh Sách Hợp Đồng")]
        public virtual IEnumerable<Contract> Contracts {
            get {
                return Works.SelectMany(x => x.Contracts);
            }
        }

        public override string ToString()
        {
            return Code + " - " + Name;
        }

    }
}
