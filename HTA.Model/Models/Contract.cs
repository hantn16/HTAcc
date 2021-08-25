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
    [Table("Contract")]
    public class Contract : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(AutoGenerateField = false)]
        public int ContractId { get; set; }

        [Display(Name = "Tên Hợp Đồng")]
        public string ContractName { get; set; }

        [Display(Name = "Ngày ký")]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime SigningDate { get; set; }

        [Display(Name = "Mã Hạng Mục")]
        public int WorkId { get; set; }

        [Display(Name = "Hạng Mục")]
        public virtual Work Work { get; set; }

        [Display(Name = "Nội Dung")]
        public string ContractContent { get; set; }

        [Display(Name = "Mã Nhà Thầu")]
        public int ContractorId { get; set; }

        [Display(Name = "Nhà Thầu")]
        public virtual Contractor Contractor { get; set; }

        [Display(Name = "Đã Thanh Lý")]
        public bool IsTerminated { get { return TerminateDate.HasValue; }}

        [Display(Name = "Ngày Thanh Lý")]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime? TerminateDate { get; set; }

        [Display(Name = "GTHĐ Ban Đầu")]
        [DisplayFormat(DataFormatString = "n0")]
        public double ContractOriginValue { get; set; }

        [DisplayFormat(DataFormatString = "n0")]
        [Display(Name = "GTHĐ Hiện Tại")]
        public virtual double ContractValue {
            get {
                return ContractOriginValue + (ContractApendixes==null? 0 : ContractApendixes.Sum(x => x.AdjustedValue));
            }
        }

        [DisplayFormat(DataFormatString = "n0")]
        [Display(Name = "GTNT Lũy kế")]
        public virtual double CompletedValue {
            get {
                return PaymentPeriods.Sum(x => x.ValueAccepted);
            }
        }

        [DisplayFormat(DataFormatString = "n0")]
        [Display(Name = "GT Xuất HĐ Lũy Kế")]
        public virtual double InvoicedValue
        {
            get {
                return PaymentPeriods.Sum(x => x.InvoicedValue);
            }
        }

        [DisplayFormat(DataFormatString = "n0")]
        [Display(Name = "GTTT Lũy Kế")]
        public virtual double PaidValue
        {
            get
            {
                return PaymentPeriods.Sum(x => x.ValuePaid);
            }
        }

        [Display(Name = "Danh Sách Phụ Lục")]
        public virtual ICollection<ContractApendix> ContractApendixes { get; set; }

        [Display(Name = "Danh Sách Lần Thanh Toán")]
        public virtual ICollection<PaymentPeriod> PaymentPeriods { get; set; }

        public override string ToString()
        {
            return ContractName;
        }
    }
}
