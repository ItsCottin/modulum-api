using modulum_api.Enum;

namespace modulum_api.Model
{
    public class Contato
    {
        /// <summary>
        /// Id do contato, verificar se é preciso a existencia desse atributo
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Numero do contato
        /// </summary>
        public string? numero { get; set; }

        /// <summary>
        /// Tipo do contato definido como "Telefone" ou "Celular"
        /// </summary>
        public TipoContato tipo { get; set; }
    }
}
