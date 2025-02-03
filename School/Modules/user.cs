using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Modules
{
    public class user
    {
        [Key]
        public int UserId { get; set; }
        
       
         [Column(TypeName = "varchar"), StringLength(50)]

        public string FirstName { get; set; }
        [Column(TypeName = "varchar"), StringLength(50)]

        public string LastName { get; set; }
        [Column(TypeName = "varchar"), StringLength(7)]
        public string Gender { get; set; }
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Role { get; set; }
        [PasswordPropertyText]
        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string Password { get; set; }
        [NotMapped]
        [Required]
        [Compare("Password", ErrorMessage = "Password and Confirm Password do not match.")]
        public string ConfirmPassword { get; set; }
       
    }
}
