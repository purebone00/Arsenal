using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Arsenal.Models.ArsenalDataModels
{
    public class Transaction
    {
        [Key] 
        public int TransactionID { get; set; }

        [DisplayName("Date")]
        [DataType(DataType.Date)]
        public DateTime TransactionDate { get; set; }

        public string Description { get; set; }

        [DisplayName("Amount")]
        public double TotalAmount { get; set; }

        [DisplayName("GST")]
        public double GstAmount { get; set; }

        [DisplayName("PST")]
        public double PstAmount { get; set; }

        [DisplayName("Payment Type")]
        public string PaymentType { get; set; }


    }
}
