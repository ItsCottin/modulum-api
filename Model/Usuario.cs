#pragma warning disable CS1591
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Diagnostics.CodeAnalysis;
using modulum_api.Filters;
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace modulum_api.Model
{
    //[Table("TBL_USUARIO")]
    public class Usuario : IdentityUser
    {

        /// <summary>
        /// Nome Completo do Usuário
        /// </summary>
        //[Column("NOME_USU")]
        public override string? UserName { get; set; }

        /// <summary>
        /// Nome Completo do Usuario Normalizado
        /// </summary>
        /// [StringLength(100)]
        [JsonIgnore]
        //[Column("NOME_USU_NORM")]
        public override string? NormalizedUserName { get; set; }

        /// <summary>
        /// E-mail do usuário. 
        /// </summary>
        [Required]
        [StringLength(50)]
        //[Column("EMAIL_USU")]
        public override string? Email { get; set; }

        /// <summary>
        /// E-mail do Usuario Normalizado
        /// </summary>
        [JsonIgnore]
        //[Column("EMAIL_USU_NORM")]
        public override string? NormalizedEmail { get; set; }

        /// <summary>
        /// Campo que diz se o e-mail foi confirmado ou não
        /// </summary>
        //[Column("EMAIL_CONFIRM")]
        public override bool EmailConfirmed { get; set; }

        /// <summary>
        /// Obtém ou define uma representação com sal e hash da senha desse usuário.
        /// </summary>
        [JsonIgnore]
        //[Column("SENHA_USU")]
        public override string? PasswordHash { get; set; }

        /// <summary>
        /// Obtém ou define uma representação com sal e hash da senha desse usuário.
        /// </summary>
        public string? Password { get; set; }

        /// <summary>
        /// Um valor aleatório que deve ser alterado sempre que as credenciais de um usuário forem alteradas (senha alterada, login removido)
        /// </summary>
        [JsonIgnore]
        //[Column("SECURITY_STAMP_USU")]
        public override string? SecurityStamp { get; set; }

        /// <summary>
        /// Um valor aleatório que deve mudar sempre que um usuário persistir na loja
        /// </summary>
        [JsonIgnore]
        //[Column("CURRENT_SECURITY_STAMP_USU")]
        public override string? ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Obtém ou define um sinalizador que indica se a autenticação de dois fatores está habilitada para este usuário.
        /// </summary>
        /// <value>Se "True" então 2fa está habilitado, se "false" então está desabilitado.</value>
        //[Column("2FA_USU")]
        public override bool TwoFactorEnabled { get; set; }

        /// <summary>
        /// Obtém ou define o número de tentativas de login malsucedidas do usuário atual.
        /// </summary>
        //[Column("COUNT_FAILED_ACESS")]
        public override int AccessFailedCount { get; set; }

        /// <summary>
        /// Obtém ou define um sinalizador que indica se o usuário pode ser bloqueado.
        /// </summary>
        /// <value>"true" caso o usuário esteja "Bloqueado", caso "false" o usuario está "Desbloqueado"</value>
        //[Column("LOCK_USU")]
        public override bool LockoutEnabled { get; set; }

        /// <summary>
        /// CPF do Usuário com formatação '000.000.000-00'.
        /// </summary>
        [StringLength(14)]
        //[Column("CPF_USU")]
        public string? cpf { get; set; }

        /// <summary>
        /// Lista de Contato do usuario
        /// </summary>
        //[Column("EMAIL_USU")] // TODO - Esse atributo deve ser o map de uma tabela
        public List<Contato>? contato { get; set; }

        /// <summary>
        /// Data de Alteração / Cadastro do Usuário
        /// </summary>
        //[Column("DT_ALTER_USU")]
        public DateTime dataAlter { get; set; }

        public string[] Roles { get; set; } = new string[0];

        [NotMapped][JsonIgnore] public override string? PhoneNumber { get; set; }
        [NotMapped][JsonIgnore] public override bool PhoneNumberConfirmed { get; set; }
        [NotMapped][JsonIgnore] public override DateTimeOffset? LockoutEnd { get; set; }

    }
}