using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HTA.Model.Abstracts
{
    interface IAuditable
    {
        bool IsActive { get; set; }
        DateTime CreatedAt { get; set; }
        string CreatedBy { get; set; }
        DateTime? ModifiedAt { get; set; }
        string ModifiedBy { get; set; }
    }
    public class Auditable : IAuditable
    {
        [Display(Name = "Tình trạng")]
        public bool IsActive { get; set; }

        [Display(Name = "Ngày tạo")]
        [DisplayFormat(DataFormatString ="dd/MM/yyyy hh:mm:ss")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Người tạo")]
        public string CreatedBy { get; set; }

        [Display(Name = "Ngày sửa")]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy hh:mm:ss")]
        public DateTime? ModifiedAt { get; set; }

        [Display(Name = "Người sửa")]
        public string ModifiedBy { get; set; }
    }
}
