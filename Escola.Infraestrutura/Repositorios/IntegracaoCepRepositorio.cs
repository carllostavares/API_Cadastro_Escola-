using Escola.Domain.Entities;
using Escola.Infraestrutura.Interfaces;
using RestSharp;
using System.Text.Json;


namespace Escola.Infraestrutura.Repositorios
{

    public  class IntegracaoCepRepositorio : IIntegracaoCepRepositorio
    {
        public  Endereco BuscarCep(string cep)
        {    
            RestClient restClient = new RestClient("https://viacep.com.br/ws/"+cep+"/json/");

            RestRequest restRequest = new RestRequest("", Method.Get);

            var response = restClient.Execute(restRequest);

            if (response.IsSuccessStatusCode && response.Content != null)
            {
                //Console.WriteLine(response.Content);

                Endereco novoEndereco = JsonSerializer.Deserialize<Endereco>(response.Content);

                return novoEndereco;
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
                return null;
            }
        }


    }
}
