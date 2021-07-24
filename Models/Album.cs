using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MusicHub.Models
{
    public class Album
    {
            public int Id { get; set; }

            [Required]
            public string Title { get; set; }

            [Required]
            public string Artist { get; set; }

             public string Genre { get; set; }

            public string Description { get; set; }
            
            public string ImageUrl { get; set; }
           
            [Required]
            public int Year { get; set; }

            [DataType(DataType.Currency)]
            [Column(TypeName = "decimal(18,2)")]
            public decimal Price { get; set; }
    }
 }
