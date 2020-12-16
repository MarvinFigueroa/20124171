using System.ComponentModel.DataAnnotations;

namespace DogKeepers.Shared.QueryFilters
{
    public class SingInQueryFilter
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}