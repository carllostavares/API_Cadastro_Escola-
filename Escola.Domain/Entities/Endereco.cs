using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Escola.Domain.Entities
{
    public class Endereco
    {
        [Required(ErrorMessage = "O campo Cep é obrigatório!")]
        [StringLength(8)]
        [JsonProperty("cep")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo Logradouro é obrigatório!")]
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo Bairro é obrigatório!")]
        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo Localidade é obrigatório!")]
        [JsonProperty("localidade")]
        public string Localidade { get; set; }

        [Required(ErrorMessage = "O campo UF é obrigatório!")]
        [JsonProperty("uf")]
        public string Uf { get; set; }


    }
}
