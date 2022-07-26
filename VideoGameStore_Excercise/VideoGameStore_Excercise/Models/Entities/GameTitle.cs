using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoGameStore_Excercise.Models.Entities
{
    public class GameTitle
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
        
        [MaxLength(300)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        
        public Boolean IsReleased { get; set; }

        [Required]
        [MaxLength(80)]
        public string Developer { get; set; }

        [Required]
        [MaxLength(120)]
        public string Platforms { get; set; }
    }
}
