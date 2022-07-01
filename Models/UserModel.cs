using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Co_Mute.Models
{
    public class UserModel
    {

        [Required]
        [DisplayName("First name")]
        public string Name{ get; set; }
        [Required]
        [DisplayName("Last name")]
        public string Surname { get; set; }

        [DisplayName ("Moblie or landline number")]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DisplayName ("Password")]
        public string Password { get; set; }


        

        

    }
}
