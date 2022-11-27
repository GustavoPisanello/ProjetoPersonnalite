using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetinhoLaDre.Models
{
    public class Usuario
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome é obrigatório")]

        public string NomeUsuario { get; set; }


        [Display(Name = "Idade")]
        [Range(18, 70, ErrorMessage = "Idade permitida entre 18 e 70")]

        public string Idade { get; set; }

        [Display(Name = "Email Pessoal")]
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