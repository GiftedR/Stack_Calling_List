using System.ComponentModel.DataAnnotations;

namespace Staggs_StackContactList.Server.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; } // 1 - 1
        [Required]
        public string CustomerFirstName { get; set; } // 1 - 1
        [Required]
        public string CustomerLastName { get; set; } // 1 - 1
        [Required]
        public DateTime CustomerBirthdate { get; set; } // 1 - 1
        public ICollection<CustomerAddresses> CustomerAddress { get; set; } // 0N - 0N
        public ICollection<Emails> CustomerEmails { get; set; } // 0 - N
        // Navigation Property
        public ICollection<PhoneNumber> CustomerPhoneNumber { get; set; } // 0 - N
    }
}
