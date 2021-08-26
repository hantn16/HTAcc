
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
    [Table("PaymentPeriod")]
    public class PaymentPeriod : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(AutoGenerateField = false)]
        public int PaymentPeriodId { get; set; }

        [Display(Name = "Tên Lần TT")]
        public string Name { get; set; }

        [Display(Name = "Mô Tả")]
        public string Description { get; set; }

        [Display(Name = "Mã Hợp Đồng")]
        public int ContractId { get; set; }

        [Display(Name = "Hợp Đồng")]
        public virtual Contract Contract { get; set; }

        [Display(Name = "Thứ Tự")]
        public int Order { get; set; }

        [Display(Name = "Mã Kiểu TT")]
        public int PaymentTypeId { get; set; }

        [Display(Name = "Kiểu TT")]
        public virtual PaymentType PaymentType { get; set; }

        [Display(Name = "Số Tiền Đề Nghị")]
        [DisplayFormat(DataFormatString = "n0")]
        public double ValueRequested { get; set; }

        [Display(Name = "Ngày Đề Nghị")]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime RequestedDate { get; set; }

        [Display(Name = "Số Tiền Thanh Toán")]
        [DisplayFormat(DataFormatString = "n0")]
        public double ValuePaid { get; set; }

        [Display(Name = "Ngày Thanh Toán")]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime PaidDate { get; set; }

        [Display(Name = "Giá Trị NTHT")]
        [DisplayFormat(DataFormatString = "n0")]
        public double ValueAccepted { get; set; }

        [Display(Name = "Ngày nghiệm thu")]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime? AcceptedDate { get; set; }

        [Display(Name = "Hóa Đơn")]
        public virtual ICollection<Invoice> Invoices { get; set; }

        //public bool HasInvoice { get { return InvoiceId != null; } }

        public override string ToString()
        {
            return Order + ". " + Name;
        }


        public virtual double InvoicedValue {
            get {
                return Invoices.Sum(x => (x.PretaxValue + x.VatValue));
            }
        }
    }

}
