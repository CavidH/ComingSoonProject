using System.ComponentModel.DataAnnotations;

namespace ComingSoonProject.VievModels
{
    public class UserLoginVm
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }

    }
}
