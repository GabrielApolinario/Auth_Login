using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AutenticacaoLogin.ViewModels
{

    /*Os ViewModels são classes que visam atender as necessidades de uma view, adaptando-se à exibição
     * ou captação de dados que não necessariamente estão no mesmo formato dos models.*/
    public class CadastroUsuarioViewModel
    {
        [Required(ErrorMessage = "Informe seu nome")]
        [MaxLength(50, ErrorMessage = "O nome deve ter até 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe seu login")]
        [MaxLength(50, ErrorMessage = "O login deve ter até 50 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe sua senha")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Sua senha deve conter no mínimo 6 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Confirme sua senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha")]
        [MinLength(6, ErrorMessage = "Sua senha deve conter no mínimo 6 caracteres")]
        [Compare (nameof(Senha), ErrorMessage = "A senha e a confirmação não são iguais")]
        public string ConfirmacaoSenha { get; set; }
    }
}