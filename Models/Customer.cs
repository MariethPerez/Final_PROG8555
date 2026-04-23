using System.ComponentModel.DataAnnotations;
namespace bank.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        
        [Required(ErrorMessage = "First name is required")]
        [MaxLength(50, ErrorMessage = "First name cannot exceed 50 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [MaxLength(50, ErrorMessage = "Last name cannot exceed 50 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        List<Account> Accounts { get; set; }
    }
}


