using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using bank.Models.Enums;

namespace bank.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Balance should be higher than 0")]
        public decimal Amount { get; set; }
        public TransactionType TransactionType { get; set; }
        
        public DateTime TransactionDate { get; set; }

        public string Description { get; set; }
        public int AccountId { get; set; }

        [ForeignKey(nameof(AccountId))]
        public Account Account { get; set; }


    }
}