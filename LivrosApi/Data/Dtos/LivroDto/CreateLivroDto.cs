using System.ComponentModel.DataAnnotations;

namespace Livros.Api.Data.Dtos.LivroDto
{
    public class CreateLivroDto
    {

        [Required(ErrorMessage = " O título do Livro é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = " O gênero do Livro é obrigatório")]
        [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
        public string Genero { get; set; }
        [Required(ErrorMessage = " A quantidade de páginas é obrigatório")]
        [Range(0, 3000, ErrorMessage = "A quantidade de páginas deve ser entre 0 e 3000 minutos")]
        public int QtdePagina { get; set; }

        [Required(ErrorMessage = " O nome do autor é obrigatório")]
        [MaxLength(100, ErrorMessage = "O tamanho do nome do autor não pode exceder 100 caracteres")]
        public int Autor { get; set; }

        [Required(ErrorMessage = "A imagem do Livro é obrigatório")]
        public string Imagem { get; set; }

    }
}
