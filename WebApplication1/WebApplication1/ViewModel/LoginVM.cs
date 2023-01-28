using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModel
{
    public class LoginVM
    {
        [Required]
        [StringLength(20)]
        public string Username { get; set; }
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 8)]
        [DataType(DataType.Password)]

        public string Password { get; set; }
    }
}
