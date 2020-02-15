using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace loginregis.Models
{
    [NotMapped] //we dont care about the login information, so put on top.
    public class Login 
    {
        [EmailAddress]
        [Required]
        [MinLength(2)]
        public string lemail {get;set;}
        [DataType(DataType.Password)]
        public string lpassword {get;set;}
    }
}