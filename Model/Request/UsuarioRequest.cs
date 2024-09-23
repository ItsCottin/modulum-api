using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace modulum_api.Model.Request
{
    public class UsuarioRequest
    {
        /// <summary>
        /// Contém o "O Nome Completo" do usuário
        /// </summary>
        public string? userName { get; set; }

        /// <summary>
        /// Contém o "E-mail" do usuário
        /// </summary>
        public string? email { get; set; }

        /// <summary>
        /// Contém o Senha" do usuário
        /// </summary>
        public string? password { get; set; }

    }
}
