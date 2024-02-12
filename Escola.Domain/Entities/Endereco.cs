using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Escola.Domain.Entities
{
    public class Endereco
    {
        [JsonPropertyName("cep")]
        public string? Cep { get; set; }

        public string Numero { get; set; }

        [JsonPropertyName("logradouro")]
        public string? Logradouro { get; set; }

        [JsonPropertyName("bairro")]
        public string? Bairro { get; set; }

        [JsonPropertyName("localidade")]
        public string? Localidade { get; set; }

        [JsonPropertyName("uf")]
        public string? Uf { get; set; }

        [Required(ErrorMessage = "O campo cpf é obrigatório!")]
        public string? Cpf { get; set; }

    }
}
