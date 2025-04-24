using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFuncional.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string? Nome { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = " preço deve ser maior que zero" )]
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int QuantidadeEstoque { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string? Descricao { get; set; }

    }
}
