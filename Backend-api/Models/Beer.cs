using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_api.Models
{
    public class Beer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BeerId { get; set; }
        public string? Name { get; set; }

        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }

    }
}
