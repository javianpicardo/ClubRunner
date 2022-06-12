using System.ComponentModel.DataAnnotations;

namespace CRWebsite.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "FirstName is required.")]
        [DataType(DataType.Text)]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required.")]
        [DataType(DataType.Text)]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Email Id is required.")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*\\.([a-z]{2,4})$", ErrorMessage = "In-valid email format.")]
        [Display(Name = "Login/Email Id")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please select a Region.")]
        [DataType(DataType.Text)]
        [Display(Name = "Region")]
        public string? Region { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Country")]
        public string? Country { get; set; }
    }
}
