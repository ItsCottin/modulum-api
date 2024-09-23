using System.ComponentModel;

namespace modulum_api.Enum
{
    public enum TipoContato
    {
        /// <summary>
        /// Tipo "Telefone", utilizar ".toString()" para recuperar valor do tipo string "Telefone"
        /// </summary>
        [Description("Tipo Telefone")]
        Telefone = 1,

        /// <summary>
        /// Tipo "Celular", utilizar ".toString()" para recuperar valor do tipo string "Celular"
        /// </summary>
        [Description("Tipo Celular")]
        Celular = 2
    }
}
