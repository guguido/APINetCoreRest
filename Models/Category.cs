using System.ComponentModel.DataAnnotations;

namespace Confidence.Models
{
  public class Category
  {
    [Key]
    public int id {get; set; }

    [Required(ErrorMessage = "Este campo é Obrigatório")]
    [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
    [MinLength(3, ErrorMessage = "Este campo deve conter ente 3 e 60 caracteres")]

    public string Title {get; set; }
  }
}