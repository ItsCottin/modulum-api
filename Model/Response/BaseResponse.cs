namespace modulum_api.Model.Response
{
    public class BaseResponse
    {
        /// <summary>
        /// Status da Requisição, pode ser "Sucesso" ou "Erro"
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// Lista de Mensagens, para saber se são mensagens de "Sucesso" ou "Erro", verificar no campo "Status"
        /// </summary>
        public string[]? Mensagens { get; set; }
    }
}
