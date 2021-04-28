using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiro.api.Models.Usuarios
{
    public class LoginViewModelInput
    {
        [Required(ErrorMessage = "Login é OBRIGATÓRIO")] //seus atributos como obrigatório
        public string Login { get; set; }

        [Required(ErrorMessage = "Password é OBRIGATÓRIO")]
        public string Password { get; set; }
    }
}
