using System.ComponentModel.DataAnnotations;


namespace WebAPI.Model
{
    public class Clientes
    {
        [Key]
        [Required(ErrorMessage = " O campo cpf é Obrigatório")]
        [StringLength(11, ErrorMessage = "Campo contem mais caracteres que o requerido")]
        public string? CPF { get; set; }

        [Required(ErrorMessage = " O campo nome é Obrigatório")]
        [StringLength(50, ErrorMessage = "Campo contem mais caracteres que o requerido")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = " O campo sexo é Obrigatório")]
        [StringLength(1, ErrorMessage = "Campo contem mais caracteres que o requerido")]
        public string? Sexo { get; set; }

        [Required(ErrorMessage = " O campo tipo é Obrigatório")]
        [StringLength(7, ErrorMessage = "Campo contem mais caracteres que o requerido")]
        public string? Tipo { get; set; }

        [Required(ErrorMessage = " O campo situação é Obrigatório")]
        public bool Situacao { get; set; }

        

    }

}
