using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssemblyAuthentication.Shared
{
    public class UserLoginModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
