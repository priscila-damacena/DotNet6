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
    [Required(ErrorMessage = " O título do Livro é obrigatório")]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
    
}
