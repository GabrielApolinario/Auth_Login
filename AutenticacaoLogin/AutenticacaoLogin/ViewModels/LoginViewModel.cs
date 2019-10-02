using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutenticacaoLogin.ViewModels
{
    public class LoginViewModel
    {
        //View model para atender as necessidades da tela de Login

        public string UrlRetorno { get; set; }

        [Required(ErrorMessage = "Informe seu login")]
        [MaxLength(50, ErrorMessage = "O login deve ter até 50 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe sua senha")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Sua senha deve conter no mínimo 6 caracteres")]
        public string Senha { get; set; }

    }
}