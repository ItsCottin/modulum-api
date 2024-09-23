namespace modulum_api.Model
{
    public class EmailRequest
    {
        /// <summary>
        /// Enderedo de E-mail para onde deve ser enviado
        /// </summary>
        public string? To { get; set; }

        /// <summary>
        /// Titulo do E-mail
        /// </summary>
        public string? Subject { get; set; }

        /// <summary>
        /// Corpo do E-mail
        /// </summary>
        public string? Message { get; set; }
    }
}
