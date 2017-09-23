using System.ComponentModel.DataAnnotations;

namespace VideoRentingSystem.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Driving License")]
        public string DriversLicense { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [StringLength(50)]
        public string PhoneNumber { get; set; }
    }
}
