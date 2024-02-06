using System.ComponentModel.DataAnnotations;

namespace Staggs_StackContactList.Server.Models
{
    public class PhoneNumber
    {
        [Key]
        public int PhoneID { get; set; }
        public string PhoneNum { get; set; }
        public int CustomerID { get; set; }
    }
}
