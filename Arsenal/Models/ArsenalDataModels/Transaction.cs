using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Arsenal.Models.ArsenalDataModels
{
    public class Transaction
    {
        [Key] 
        public int TransactionID { get; set; }

        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }

        public int TotalAmount { get; set; }

        public int GstAmount { get; set; }

        public int PstAmount { get; set; }

        public string PaymentType { get; set; }

    }
}
