using System.ComponentModel.DataAnnotations;

namespace myArtifactMIS.Models
{
    public class Category
    {

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}
