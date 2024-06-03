using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class Zombietype
    {
        [Required(ErrorMessage ="Type Name has to be filled.")]
        public int Id { get; set; }
        [Display(Name ="TypeName")]
        public string TypeName { get; set; }
    }
}
