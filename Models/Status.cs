using System.ComponentModel.DataAnnotations;

namespace myArtifactMIS.Models
{
    public class Status
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string s_name { get; set; }
    }
}
