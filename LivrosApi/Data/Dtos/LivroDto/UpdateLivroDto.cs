using System.ComponentModel.DataAnnotations;

namespace Livros.Api.Data.Dtos.LivroDto
{
    public class UpdateLivroDto
    {

        [Required(ErrorMessage = " O título do Livro é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = " O gênero do Livro é obrigatório")]
        [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
        public string Genero { get; set; }
        [Required(ErrorMessage = " O título do Livro é obrigatório")]
        [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
        public int QtdePagina { get; set; }
        [Required(ErrorMessage = " O nome do autor é obrigatório")]
        [MaxLength(100, ErrorMessage = "O tamanho do nome do autor não pode exceder 100 caracteres")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "A imagem do Livro é obrigatório")]
        public string Imagem { get; set; }

    }
}
