using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace StudentForm.Models
{
    public class AppUser : IdentityUser

    {
        [StringLength(50)]
        [MaxLength(50)]
        [Required]
        public string? Name{ get; set; }

        public string? Address { get; set; }
    }
}
