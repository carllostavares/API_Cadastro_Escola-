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

        [Required(ErrorMessage = "O campo Complemento é obrigatório!")]
        [JsonProperty("complemento")]
        public string Complemento { get; set; }


        [Required(ErrorMessage = "O campo Bairro é obrigatório!")]
        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo Localidade é obrigatório!")]
        [JsonProperty("localidade")]
        public string Localidade { get; set; }

        [Required(ErrorMessage = "O campo UF é obrigatório!")]
        [JsonProperty("uf")]
        public string Uf { get; set; }

        [Required(ErrorMessage = "O campo IBGE é obrigatório!")]
        [JsonProperty("ibge")]
        public string Ibge { get; set; }

        [Required(ErrorMessage = "O campo GIA é obrigatório!")]
        [JsonProperty("gia")]
        public string Gia { get; set; }

        [Required(ErrorMessage = "O campo DDD é obrigatório!")]
        [JsonProperty("ddd")]
        public string Ddd { get; set; }


        [Required(ErrorMessage = "O campo DDD é obrigatório!")]
        [JsonProperty("sifai")]
        public string Siafi { get; set; }


    }
}
