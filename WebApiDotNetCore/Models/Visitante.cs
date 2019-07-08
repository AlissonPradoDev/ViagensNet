using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiDotNetCore.Models
{
    [Table("Comportamento")]
    public class Visitante
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Navegador { get; set; }
        [Required]
        public string Identificador { get; set; }
    }

}
