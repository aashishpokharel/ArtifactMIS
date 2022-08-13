using myArtifactMIS.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myArtifactMIS.Models
{
    public class Artifact
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string a_name { get; set; }

        [Required]
        public int status { get; set; }

        [DataType(DataType.Date)]
        public DateTime added_date { get; set; }

        [ForeignKey("Category")]
        public int categoryID { get; set; }

        [ForeignKey("Status")]
        public int StatusId { get; set; }

        [ForeignKey("Staff")]
        public int StaffId { get; set; }


        public Category Categories { get; set; }

        public Status Status { get; set; }

        public Staff Staffs { get; set; }
    }
}
