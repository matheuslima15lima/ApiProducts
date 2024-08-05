using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductWebApi.Domains
{
    public class Products
    {
        [Key]
       public Guid IdProduct { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "O campo e obrigatorio")]
        [Column(TypeName = "varchar(100)")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "O campo e obrigatorio")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal? Price { get; set; }
    }
}
