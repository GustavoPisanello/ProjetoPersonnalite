using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetinhoLaDre.Models
{
    public class Usuario
    {
        [Display(Name = "Nome do usuário")]
        [Required(ErrorMessage = "O nome é obrigatório")]

        public string NomeUsuario { get; set; }

        [Display(Name = "Observação")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira de 5 a 50 caracteres")]

        public string Observação { get; set; }

        [Display(Name = "Idade do usuário")]
        [Range(18, 70, ErrorMessage = "Idade permitida entre 18 e 70")]

        public string Idade { get; set; }

        [Display(Name = "Email Profissional")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email Inválido")]

        public string Email { get; set; }

        [Display(Name = "Crie seu login")]
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente Letras e de 5 a 15 caracteres")]
        [Required(ErrorMessage = "Login obrigatório")]
        //[Remote("LoginUnico", "usuario", ErrorMessage = "Login já cadastrado")]

        public string Login { get; set; }

        [Display(Name = "Crie sua senha")]
        [Required(ErrorMessage = "Senha obrigatória")]

        public string Senha { get; set; }

        [Display(Name = "Confirmar Senha")]
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "A senha não corresponde")]
        public string Consenha { get; set; }

    }
}