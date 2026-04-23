using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using bank.Models.Enums;

namespace bank.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        [Required(ErrorMessage = "Account Number is required")]
        public string AccountNumber { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Balance should be higher than 0")]
        public decimal Balance { get; set; }
        public AccountType AccountType { get; set; }

        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }
        List<Transaction> Transactions { get; set; }
    }
}