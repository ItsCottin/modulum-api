namespace modulum_api.Model.Response
{
    public class CadastroUsuarioResponse
    {
        /// <summary>
        /// Status da Requisição, pode ser "Sucesso" ou "Erro"
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// Lista de Mensagens, para saber se são mensagens de "Sucesso" ou "Erro", verificar no campo "Status"
        /// </summary>
        public string? Mensagem { get; set; }

        /// <summary>
        /// URL para ativação do e-mail (provisório)
        /// </summary>
        public string? url { get; set; }
    }
}
