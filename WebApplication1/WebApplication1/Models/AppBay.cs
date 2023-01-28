using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class AppBay
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:75)]
      
        public string Title1 { get; set; }

        [Required]
        [StringLength(maximumLength: 300)]
        public string Desc { get; set; }

		[Required]
		public string Icon { get; set; }

	}
}
