using System.ComponentModel.DataAnnotations;

namespace LivrosApi.Models;

public class Livro
{
    [Key]
    [Required]
    public int Id { get;  set; }

    [Required(ErrorMessage = " O título do Livro é obrigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = " O gênero do Livro é obrigatório")]
    [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }
    [Required(ErrorMessage = " A quantidade de páginas é obrigatório")]
    [Range(0, 3000, ErrorMessage = "A quantidade de páginas deve ser entre 0 e 3000 minutos")]
    public int QtdePagina { get; set; }
    
}
