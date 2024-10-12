using System.ComponentModel.DataAnnotations;

namespace LivrosApi.Models;


public class Usuario
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = " O nome é obrigatório")]
    public string Nome { get; set; }

    [Required(ErrorMessage = " O CPF é obrigatório")]
    public string Cpf { get; set; }

    [Required(ErrorMessage = " O data de nascimento é obrigatório")]
    public DateOnly DataDeNascimento{ get; set; }

    [Required(ErrorMessage = " O email é obrigatório")]
    public string Email { get; set; }

    public  List<Livro> Livro { get; set; }

}
