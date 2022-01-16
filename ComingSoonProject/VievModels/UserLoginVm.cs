using System.ComponentModel.DataAnnotations;

namespace ComingSoonProject.VievModels
{
    public class UserLoginVm
    {
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
      
    }
}
