using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineEduWebApp.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [MaxLength(50, ErrorMessage = "Username field contain max 50 characters")]
        [MinLength(3, ErrorMessage = "Username field contain min 3 characters")]
        [Required(ErrorMessage = "Username field is required")]
        [Index(IsUnique = true)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Email field is required")]
        [Column(TypeName = "nvarchar")]
        [MaxLength(50, ErrorMessage = "Email field contain max 50 characters")]
        
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password field is required")]
        [Column(TypeName = "nvarchar")]
        [MaxLength(70,ErrorMessage ="Password field contain max 70 characters")]
        [MinLength(5, ErrorMessage = "Password field must contain min 5 characters")]
        public string Password { get; set; }
        [Required(ErrorMessage ="This field is required")]
        [Column(TypeName = "nvarchar")]
        [NotMapped]
        [Compare("Password",ErrorMessage = "Passwords not same")]
        public string ConfirmPassword { get; set; }
        [NotMapped]
        public bool IsAgree { get; set; }
    }
}